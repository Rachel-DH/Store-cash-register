using BlApi;

namespace BlImplementation;
internal class BL : IBl
{
    public ICustomer customer => new CustomerImplementation();

    public ISale sale =>  new SaleImplementation();

    public IProduct product =>  new ProductImplementation();

    public IOrder order =>  new OrderImplementation();
}


