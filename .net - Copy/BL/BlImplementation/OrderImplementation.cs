namespace BlImplementation;

internal class OrderImplementation : BlApi.IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    List<BO.SaleInProduct> BlApi.IOrder.AddProductToOrder(BO.Order order, int productId, int amount)
    {
        try
        {
            DO.Product product = _dal.product.Read(productId);
            BO.ProductInOrder? currentProduct = order.Products.FirstOrDefault(p => p.Id == productId);

            if (currentProduct != null)
            {
                if (currentProduct.AmountInOrder + amount > product.amount)
                    throw new BO.BlNotEnoughInStockException("the amount is too big");
                currentProduct.AmountInOrder += amount;
            }
            else
            {
                if (amount > product.amount)
                    throw new BO.BlNotEnoughInStockException("the amount is too big");
                currentProduct = new BO.ProductInOrder(productId, product.name, product.price, amount, null, product.price * amount);
                order.Products.Add(currentProduct);
            }

            ((BlApi.IOrder)this).SearchSaleForProduct(currentProduct, order.IsMemberCustomer);
            ((BlApi.IOrder)this).CalcTotalPriceForProduct(currentProduct);
            ((BlApi.IOrder)this).CalcTotalPrice(order);
            return currentProduct.Sales;
        }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlProductIdNotFoundException(e.Message, e); }
    }

    void BlApi.IOrder.CalcTotalPrice(BO.Order order)
    {
        order.TotalPrice = order.Products.Sum(p => p.TotalPrice);
    }

    void BlApi.IOrder.CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
    {
        int count = productInOrder.AmountInOrder;
        double total = 0;
        List<BO.SaleInProduct> implementedSales = new List<BO.SaleInProduct>();

        foreach (BO.SaleInProduct sale in productInOrder.Sales)
        {
            if (count < sale.AmountToSale)
                continue;
            int times = count / sale.AmountToSale;
            total += times * sale.Price;
            implementedSales.Add(sale);
            count -= times * sale.AmountToSale;
            if (count == 0)
                break;
        }

        total += count * productInOrder.BasePrice;
        productInOrder.TotalPrice = total;
        productInOrder.Sales = implementedSales;
    }

    void BlApi.IOrder.DoOrder(BO.Order order)
    {
        try
        {
            order.Products.ForEach(x =>
            {
                DO.Product d = _dal.product.Read(x.Id);
                _dal.product.Update(d with { amount = d.amount - x.AmountInOrder });
            });
        }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlProductIdNotFoundException(e.Message, e); }
    }

    void BlApi.IOrder.SearchSaleForProduct(BO.ProductInOrder productInOrder, bool isMember)
    {
        try
        {
            var sales = from s in _dal.sale.ReadAll(s => s.barcode == productInOrder.Id
                            && s.begin_date <= DateTime.Now && s.end_date >= DateTime.Now
                            && (s.to_members == false || isMember))
                        orderby s.price / s.min_amount
                        select s.ConversDoSaleToBoSaleInProduct();

            productInOrder.Sales = sales.ToList();
        }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlProductIdNotFoundException(e.Message, e); }
    }
}
