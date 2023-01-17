using SampleFrameworksApp.Practical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp.Partical
{
    class HashSetCollection
    {
        HashSet<Customer> customers = new HashSet<Customer>();

       public void AddNewCustomer (Customer cst)
        {
            customers.Add(cst);
        }

        public HashSet<Customer> AllCustomer => customers;

        
    }
}
