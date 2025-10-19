using System;
namespace JOIN
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] meh  = new string[]{"ab", "wao", "what"};
            string mehMEH = string.Join("", meh);
            Console.WriteLine(mehMEH);
        }
    }
}