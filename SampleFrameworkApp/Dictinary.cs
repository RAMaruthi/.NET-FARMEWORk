using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{
    class Dictinary
    {
     

        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("SampleName", "Example123");
            hashtable["Test Name"] = "Test123";
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine("{0}-{1}", item.Key, item.Value);
            }
        }
    }
}
