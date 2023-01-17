using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{
    class Customer2 : IComparable<Customer2>
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int BillAmount { get; set; }

        public int CompareTo(Customer2 other)
        {
            return CustomerName.CompareTo(other.CustomerName);
        }
        
        public override string ToString()
        {
            return
               $"Name:{CustomerName} from {CustomerAddress} with BillAmout :{BillAmount}";
        }

    }

    enum Criteria { ID, Name, Address, Bill }
    class CustomerComparer : IComparer<Customer2>
    {
        private Criteria criteria;
        public CustomerComparer(Criteria criteria)
        {
            this.criteria = criteria;
        }

        public int Compare(Customer2 x, Customer2 y)
        {
            switch (criteria)
            {
                case Criteria.ID:
                    return x.CustomerId.CompareTo(y.CustomerId);
                case Criteria.Name:
                    return x.CustomerName.CompareTo(y.CustomerName);
                case Criteria.Address:
                    return x.CustomerAddress.CompareTo(y.CustomerAddress);
                case Criteria.Bill:
                    return x.BillAmount.CompareTo(y.BillAmount);

            }
            return 0;
        }
       
    }
    class SortedString
    {
        static void Customer1()
        {
            List<Customer2> customers = new List<Customer2>();

            customers.Add(new Customer2
            {
                CustomerId = 1,
                CustomerName = "David",
                BillAmount = 500,
                CustomerAddress = "New York"
            });

            customers.Add(new Customer2
            {
                CustomerId = 2,
                CustomerName = "Anna",
                BillAmount = 300,
                CustomerAddress = "New York"
            });

            customers.Add(new Customer2
            {
                CustomerId = 3,
                CustomerName = "Jane",
                BillAmount = 250,
                CustomerAddress = "New Jersy"
            });

            customers.Add(new Customer2
            {
                CustomerId = 4,
                CustomerName = "Tom",
                BillAmount = 100,
                CustomerAddress = "Yorkshire"
            });

            Console.WriteLine("Enter the Criteria to Sort");
            Array values = Enum.GetValues(typeof(Criteria));
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Criteria selected = (Criteria)Enum.Parse(typeof(Criteria), Console.ReadLine());
            customers.Sort(new CustomerComparer(selected));
            foreach (var cst in customers)
                Console.WriteLine(cst);

          
        }

        static void Main(string[] args)
        {

            SortedString.Customer1();
        }
    }
}
