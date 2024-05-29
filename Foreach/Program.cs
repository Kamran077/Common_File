namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

            /* for (int i = 0; i < nums.Length; i++)
             {
                 Console.WriteLine(nums[i]);
             }*/

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }





            Console.ReadLine();
        }
    }
}
