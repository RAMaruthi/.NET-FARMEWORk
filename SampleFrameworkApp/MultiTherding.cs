using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{
    class MultiTherding
    {
        static void LargeFunction()
        {
            Console.WriteLine("The large function has started");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Large Func is doing some job!!!");
            }
            Console.Clear();
            Console.WriteLine("The large function has completed");


        }
        static void Main(string[] args)
        {
            ThreadStart tFunc = new ThreadStart(LargeFunction);
            Thread thread = new Thread(tFunc);
            thread.Start();
            Console.WriteLine("Main is doing its job");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Main is doing some job!!!");
            }
            Console.WriteLine("The Main has ended, UR App now Terminates!!!!");
        }

    }
}
