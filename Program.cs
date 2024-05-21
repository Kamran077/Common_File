using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter the first number : ");
            int firstnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second number : ");         
            int secondnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the third number : ");
            int thirdnum = Convert.ToInt32(Console.ReadLine());

            int average = (firstnum + secondnum + thirdnum) / 3;

            Console.WriteLine("Average : " + average);

            if (average >= 80 && average <= 100)
            {
                Console.WriteLine("Your average is good.");
            }
            else if (average >= 60 && average < 80)
            {
                Console.WriteLine("Your average is normal.");
            }
            else
            {
                Console.WriteLine("Your average is bad.Please,study");
            }
            Console.ReadLine();
        }
    }
}
