using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int a = 1000;


             byte b = (byte)a;

             Console.WriteLine(b.GetType());
             Console.WriteLine(b);
             Console.ReadLine();*/

            double x = 5.95;

            int b = Convert.ToInt32(x);

            Console.WriteLine(b);
            Console.ReadLine();








        }
    }
}
