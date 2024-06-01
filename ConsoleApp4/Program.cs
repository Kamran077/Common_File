namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-ci ededi daxil et : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("2-ci ededi daxil et : ");   
            int num2 = int.Parse(Console.ReadLine());

            ededler(num1, num2);


            Console.ReadLine();
        }

        static void ededler(int num1, int num2)
        {
            if(num1 > num2)
            {
                Console.WriteLine("1-ci eded 2ci ededden boyukdur...");
            }
            else
            {
                Console.WriteLine("1-ci eded 2-ci ededden kicikdir...");
            }

        }






    }






}
