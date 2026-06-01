namespace BlImplementation;

internal class ProductImplementation : BlApi.IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Product product)
    {
        try { return _dal.product.Create(product.ConversBoProductToDoProduct()); }
        catch (DO.DalIdAlreadyExistsException e) { throw new BO.BlProductAlreadyExistsException(e.Message, e); }
    }

    public void Delete(int id)
    {
        try { _dal.product.Delete(id); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlProductIdNotFoundException(e.Message, e); }
    }

    public void GetSales(BO.ProductInOrder productInOrder, bool isMember)
    {
        try
        {
            var sales = _dal.sale.ReadAll(s => s.barcode == productInOrder.Id
                && s.begin_date <= DateTime.Now && s.end_date >= DateTime.Now
                && (!s.to_members || isMember))
                .Select(s => s.ConversDoSaleToBoSaleInProduct())
                .OrderBy(s => s.Price / s.AmountToSale)
                .ToList();

            productInOrder.Sales = sales;
        }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlProductIdNotFoundException(e.Message, e); }
    }

    public BO.Product? Read(int id)
    {
        try { return _dal.product.Read(id).ConversDoProductToBoProduct(); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlProductIdNotFoundException(e.Message, e); }
    }

    public BO.Product? Read(Func<BO.Product, bool> filter)
    {
        try { return _dal.product.Read(p => filter(p.ConversDoProductToBoProduct()))?.ConversDoProductToBoProduct(); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlProductIdNotFoundException(e.Message, e); }
    }

    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter)
    {
        try
        {
            var list = _dal.product.ReadAll(filter == null ? null : p => filter(p.ConversDoProductToBoProduct()));
            return (from p in list select (BO.Product?)p.ConversDoProductToBoProduct()).ToList();
        }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlProductIdNotFoundException(e.Message, e); }
    }

    public void Update(BO.Product product)
    {
        try { _dal.product.Update(product.ConversBoProductToDoProduct()); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlProductIdNotFoundException(e.Message, e); }
    }
}
