using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{
    class CustomerArray : IEnumerable
    {
        List<string> name = new List<string>();
        public void AddName(string name)
        {
            this.name.Add(name);

        }

        public void DeleteName(int index)
        {
            if (index < name.Count)
            {
                name.RemoveAt(index);
            }
            else
                throw new Exception("Id is not found");
        }

        public IEnumerator GetEnumerator()
        {
           
                foreach (var item in name)
                    yield return item;

            
        }

        public string this[int index]
        {
            get
            {
                return name[index];
            }
            set
            {
                if (index<name.Count)
                {
                    name[index] = value;
                }
            }
        }
       
        public int NameCount=> name.Count;
    }
    class CustoCollection
    {
        static void Main(string[] args)
        {
            CustomerArray array = new CustomerArray();
            array.AddName("Phaniraj");
            array.AddName("Ramesh");
            array.AddName("Rajeev");
            array.AddName("Bansal");

            for (int i = 0; i < array.NameCount; i++)
            {
                string old = array[i];
                array[i] = "Welcome to " + old;
                Console.WriteLine(array[i]);
            }
            foreach (string name in array)
                Console.WriteLine(name);

        }
    }
}
