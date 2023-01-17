using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{
    class SortedList
    {
        public static void Sorted()
        {
            SortedList<string, long> g = new SortedList<string, long>();
            g.Add("Maruthi", 9886545072);
            g.Add("Arvind", 9875656565);
            foreach (var item in g)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");
            }

        }

        static void Main(string[] args)
        {
            Sorted();
        }
    }
}
