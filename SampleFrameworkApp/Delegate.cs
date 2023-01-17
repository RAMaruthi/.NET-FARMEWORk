using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworkApp
{
    delegate double ArithmeticOpertation(double v1,double v2);
   
    class MathCompnent
    {
        public static void PerformOpertion(ArithmeticOpertation opertation)
        {
            var v1 = double.Parse(Utilities.Prompt("Enter The frist Vaule"));

            var v2 = double.Parse(Utilities.Prompt("Enter The Second Vaule"));
            //var res = opertation(v1, v2);
            //Console.WriteLine("The result of this Opertion :" + res);
            Delegate[] allOperation = opertation.GetInvocationList();
            foreach (Delegate item in allOperation)
            {
                Console.WriteLine(item.Method.Name);
                Console.WriteLine("The result is :" + item.DynamicInvoke(v1, v2));
            }

        }
    }



    class Delegate1
    {
        static double addFunc(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //MathCompnent.PerformOpertion(new ArithmeticOpertation(addFunc));
            //MathCompnent.PerformOpertion(delegate (double v1, double v2)
            //{
            //    return v2 - v1;
            //});

            //MathCompnent.PerformOpertion((a, b) => a * b);

            ArithmeticOpertation opertation = new ArithmeticOpertation(addFunc);


            opertation += new ArithmeticOpertation(subFunc);
           
            opertation += new ArithmeticOpertation(delegate (double v1, double v2)
            {
                return v2 * v1;
            });

            MathCompnent.PerformOpertion(opertation);

        }

        private static double subFunc(double v1, double v2)
        {
            return v1 - v2;
        }
       



    }
}
