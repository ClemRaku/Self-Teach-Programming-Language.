using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
namespace Young_Physicist
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[][] xyz = new string[n][];;//jagged array, note this.
            
            int[,] num_xyz = new int[n, 3];
            bool equilibrium = true;

            int[] x = new int[n];
            int[] y = new int[n];
            int[] z = new int[n];

            int sumX = 0;
            int sumY = 0;
            int sumZ = 0;
            for(int i = 0; i < n; i++)
            {
                xyz[i] = Console.ReadLine().Split(' ');//note this as well.
                x[i] = Convert.ToInt32(xyz[i][0]);
                y[i] = Convert.ToInt32(xyz[i][1]);
                z[i] = Convert.ToInt32(xyz[i][2]);

                sumX += x[i];
                sumY += y[i];
                sumZ += z[i];

                
                if(sumX != 0 || sumY !=0 || sumZ != 0)
                {
                    equilibrium = false;
                }
                else
                {
                    equilibrium = true;
                }
            }

            if(equilibrium)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}