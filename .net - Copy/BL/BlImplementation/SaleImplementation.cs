namespace BlImplementation;

internal class SaleImplementation : BlApi.ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Sale sale)
    {
        try { return _dal.sale.Create(sale.ConversBoSaleToDoSale()); }
        catch (DO.DalIdAlreadyExistsException e) { throw new BO.BlSaleAlreadyExistsException(e.Message, e); }
    }

    public void Delete(int id)
    {
        try { _dal.sale.Delete(id); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlSaleIdNotFoundException(e.Message, e); }
    }

    public BO.Sale? Read(int id)
    {
        try { return _dal.sale.Read(id).ConversDoSaleToBoSale(); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlSaleIdNotFoundException(e.Message, e); }
    }

    public BO.Sale? Read(Func<BO.Sale, bool> filter)
    {
        try { return _dal.sale.Read(s => filter(s.ConversDoSaleToBoSale()))?.ConversDoSaleToBoSale(); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlSaleIdNotFoundException(e.Message, e); }
    }

    public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter)
    {
        try
        {
            var list = _dal.sale.ReadAll(filter == null ? null : s => filter(s.ConversDoSaleToBoSale()));
            return list.Select(s => (BO.Sale?)s.ConversDoSaleToBoSale()).ToList();
        }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlSaleIdNotFoundException(e.Message, e); }
    }

    public void Update(BO.Sale sale)
    {
        try { _dal.sale.Update(sale.ConversBoSaleToDoSale()); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlSaleIdNotFoundException(e.Message, e); }
    }
}
