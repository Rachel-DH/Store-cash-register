using DalApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public sealed class DalList : IDal
    {
        private DalList() { }
        public static DalList Instance { get; } = new DalList();

        public IProduct product => new ProductImplementation();
        public Icustomer customer => new CustomerImplementation();
        public Isale sale=>new SaleImplementation();
    }
}
