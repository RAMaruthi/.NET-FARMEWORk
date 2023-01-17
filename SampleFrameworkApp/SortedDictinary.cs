using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{

    class SortedDictinary
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> s = new SortedDictionary<string, long>();
            s.Add("Maruthi", 545454);
            s.Add("Arvind", 78788);
            s.Add("Vishwa", 545454);
            s.Add("Ramu", 78788);
            s.Add("Tarun", 545454);
            s.Add("Eswarh", 78788);
            foreach (var item in s)
            {
                Console.WriteLine(item.Key);
            }


        }
    }
}
