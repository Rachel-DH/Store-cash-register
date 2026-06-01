namespace BlImplementation;

internal class CustomerImplementation : BlApi.ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int Create(BO.Customer customer)
    {
        try { return _dal.customer.Create(customer.ConversBoProductToDoProduct()); }
        catch (DO.DalIdAlreadyExistsException e) { throw new BO.BlCustomerAlreadyExistsException(e.Message, e); }
    }

    public void Delete(int id)
    {
        try { _dal.customer.Delete(id); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlCustomerIdNotFoundException(e.Message, e); }
    }

    public bool IsExist(BO.Customer customer)
    {
        try { _dal.customer.Read(customer.Id); return true; }
        catch (DO.DalIdNotFoundException) { return false; }
    }

    public BO.Customer? Read(int id)
    {
        try { return _dal.customer.Read(id).ConversDoProductToBoProduct(); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlCustomerIdNotFoundException(e.Message, e); }
    }

    public BO.Customer? Read(Func<BO.Customer, bool> filter)
    {
        try { return _dal.customer.Read(c => filter(c.ConversDoProductToBoProduct()))?.ConversDoProductToBoProduct(); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlCustomerIdNotFoundException(e.Message, e); }
    }

    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter)
    {
        try
        {
            var list = _dal.customer.ReadAll(filter == null ? null : c => filter(c.ConversDoProductToBoProduct()));
            return (from c in list select (BO.Customer?)c.ConversDoProductToBoProduct()).ToList();
        }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlCustomerIdNotFoundException(e.Message, e); }
    }

    public void Update(BO.Customer customer)
    {
        try { _dal.customer.Update(customer.ConversBoProductToDoProduct()); }
        catch (DO.DalIdNotFoundException e) { throw new BO.BlCustomerIdNotFoundException(e.Message, e); }
    }
}
