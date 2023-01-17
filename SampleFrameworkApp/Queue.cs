using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace SampleFrameworkApp
{
    class main
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            main c = new main();
            do
            {
                var input = Utilities.Prompt("Enter the item");
                c.ViewItem(input);

            } while (true);

        }
        private Queue<string> _recentList = new Queue<string>();

        public void ViewItem(string itm)
        {
           
            if (_recentList.Count == 2) _recentList.Dequeue();
            _recentList.Enqueue(itm);
           
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(itm);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Recently viewed Items");
            Thread.Sleep(2000);
            Console.Clear();

            var data = _recentList.Reverse();
            foreach (var item in data)
            {
                Console.WriteLine("*******");
                Console.WriteLine(item);
                Console.WriteLine("******");
            }




           
        }
       
    }
   }
