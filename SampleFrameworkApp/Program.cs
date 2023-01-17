using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Mango");
            list.Add("Orange");
            list.Add("Apple");
            list.Add("Bare fruit");
            list.Remove("Apple");
            list.Insert(1, "Ahvli");

            Console.WriteLine("The Number Of Fruit  :" +list.Count);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
