using System;
namespace Exponent_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter base: ");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter power: ");
            int power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetPow(bas, power));

        }
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for(int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }
    }
}
