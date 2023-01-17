using DataLayer;
using SampleFrameworksApp.Practical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLayer;

namespace SampleFrameworkApp.Partical
{
    class MainUI
    {
        static IDataComponent component = null;
        static MainUI()
        {
            //Console.WriteLine("Enter the Name of the Component as : List or ArrayList");
            //component = CustomerFactory.GetComponent(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            HashSetCollection collection = new HashSetCollection();
            collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Phaniraj", CustomerAddress = "Bangalore", BillAmount = 5600 });
            collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Phaniraj", CustomerAddress = "Mysore", BillAmount = 5600 });
            collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Phaniraj", CustomerAddress = "Chennai", BillAmount = 5600 });
            collection.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Phaniraj", CustomerAddress = "Bangalore", BillAmount = 5600 });
            collection.AddNewCustomer(new Customer { CustomerId = 112, CustomerName = "Phaniraj", CustomerAddress = "Bangalore", BillAmount = 5600 });
            Console.WriteLine("The Total Number Of Customers :"+collection.AllCustomer.Count);
            foreach (var Customer in collection.AllCustomer)
                Console.WriteLine(Customer);

        }

        private static void factoryTesting()
        {
            component.AddNewCustomer(new Customer { CustomerId = 111, CustomerName = "Ramesh Adiga", CustomerAddress = "Kundapur", BillAmount = 5600 });
            component.AddNewCustomer(new Customer { CustomerId = 131, CustomerName = "Arvind", CustomerAddress = "Ballery", BillAmount = 56000});
            component.AddNewCustomer(new Customer { CustomerId = 121, CustomerName = "Maruthi", CustomerAddress = "Davangere", BillAmount = 99600 });

            component.UpdateCustomer(new Customer { CustomerId = 111, CustomerName = "ramesh adiga", CustomerAddress = "udupi", BillAmount = 5600 });
            var data = component.GetAllCustomers();
            foreach (Customer customer in data)
                Console.WriteLine(customer.CustomerId+" " + customer.CustomerName+" "+customer.CustomerAddress+" "+customer.BillAmount);
            component.DeleteCustomer(121);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}
