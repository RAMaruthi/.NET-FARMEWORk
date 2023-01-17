using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{
    class FileIO
    {
        private static void Main(string[] args)
        {
            string file = "../../FileIo.cs";
            if (!File.Exists(file))
            {
                Console.WriteLine("File path is Wrong");
            }
            else
            {
                var con = File.ReadAllText(file);
                Console.WriteLine(con);
            }

        }
        
    }
}
