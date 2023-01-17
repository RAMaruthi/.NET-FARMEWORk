using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{

   
     
    class ParameterizedThread1
    {
        static void LargeFuncWithParameters(object data)
        {
            string filename = data.ToString();
            //var contents = File.ReadAllLines(filename);
            Console.WriteLine(filename);
            Console.WriteLine("The Complete set of records is read");
        }

        static void ParameterizedOperation()
        {
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(LargeFuncWithParameters);
            Thread th = new Thread(threadStart);
            th.IsBackground = true;
            th.Start("Maruthi");
        }
        static void Main(string[] args)
        {
            ParameterizedOperation();
            Console.WriteLine("Main is Diong job");
            for (int i = 0; i < 1; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("The main doing some job");
            }
            Console.WriteLine("The MAin has ended , UR App now Terminates");
        }

    }
}
