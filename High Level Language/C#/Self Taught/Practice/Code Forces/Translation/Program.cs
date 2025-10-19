using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
namespace Translation
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] Berland  = Console.ReadLine().ToCharArray();
            string Birland = Console.ReadLine();

            char[] reversed_BERLAND = new char[Berland.Length];
            int lastINDEX = Berland.Length - 1;

            int a = 0;
            for(int i = lastINDEX; i = 0; i--)
            {
                reversed_BERLAND[a] = Berland[i];
                a++;
            }

            string REVERSED = new string(reversed_BERLAND);

            if(REVERSED == Birland)
            {
                Console.WriteLine(YES);
            }
            else
            {
                Console.WriteLine(NO);
            }
        }
    }
}