using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 10, 20, 15, 15, 37, 20, 15, 50, 40, 40, 50, 60, 37, 40, 50, 55 };
            int dene = 0;
            int eded;



            Console.Write("Ededi daxil et : ");
            eded = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                if (eded == nums[i])
                {
                    dene++;
                }

            }

            if (eded == 0)
            {
                Console.WriteLine("Daxil edilen eded siyahida yoxdur...");
            }
            else
            {
                Console.WriteLine("Daxil edilen eded siyahida var...");
                Console.Write("Dene : " + dene);
            }

            Console.ReadLine();

        }
    }
}
