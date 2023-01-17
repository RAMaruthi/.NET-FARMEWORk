using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp.Partical
{
    class HashSet
    {
        static void Main(string[] args)
        {
            HashSet<string> hash = new HashSet<string>();
            hash.Add("Maruthi");
            hash.Add("maru");
            hash.Add("Maruthi");
            hash.Add("maru");
            Console.WriteLine("The number of count" + hash.Count);
        }
    }
}