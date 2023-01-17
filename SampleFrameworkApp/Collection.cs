using SampleFrameworksApp.Practical;
using System;
using System.Collections;
using UtilitiesLayer;

namespace DataLayer
{
    interface IDataComponent
    {
        void AddNewCustomer(Customer cst);
        void UpdateCustomer(Customer cst);
        Array GetAllCustomers();
        void DeleteCustomer(int id);
    }

    class CustomerDatabase : IDataComponent
    {
        private ArrayList _listOfCustomers = new ArrayList();//UR Array is replaced by ArrayList. 
        public void AddNewCustomer(Customer cst)
        {
            _listOfCustomers.Add(cst);
           //Console.WriteLine("Add sucessfully");
           
        }

        public void DeleteCustomer(int id)
        {
            
            foreach (var item in _listOfCustomers)
            {
                if (item is Customer)
                {
                    var unbox = item as Customer;
                    if (unbox.CustomerId==id)
                    {
                        _listOfCustomers.Remove(unbox);

                    }
                    return;
                }
            }
            throw new Exception("Id is Not found");
        }

        public Array GetAllCustomers()
        {
            Customer[] array = new Customer[_listOfCustomers.Count];
            for (int i = 0; i < _listOfCustomers.Count; i++)
            {
                array[i] = _listOfCustomers[i] as Customer;
            }
            return array;
        }

        public void UpdateCustomer(Customer Customer)
        {
            foreach (var cst in _listOfCustomers)
            {
                if (cst is Customer)
                {
                    var unbox = cst as Customer;
                    if (unbox.CustomerId==Customer.CustomerId)
                    {
                        unbox.CustomerName = Customer.CustomerName;
                        unbox.CustomerAddress = Customer.CustomerAddress;
                        unbox.BillAmount = Customer.BillAmount;
                        return;
                    }

                    
                }
            }
            throw new CustomerException("The Is Not found");
        }
       
    }


}
