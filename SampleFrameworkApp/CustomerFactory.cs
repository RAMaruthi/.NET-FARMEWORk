
using System.Configuration;
using DataLayer;
using System;


namespace UtilitiesLayer
{
   static class CustomerFactory
    {
        public static IDataComponent GetComponent(string type)
        {
            IDataComponent component = null;
            switch (type.ToLower())
            {
                case "list": return new ListCollection();
                case "arraylist": return new CustomerDatabase();
                default:
                    throw new CustomerException("This type is not supported by us");
            }
        }

    }
}
