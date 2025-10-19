using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
namespace George_and_Accommodation
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number_of_rooms = Convert.ToInt32(Console.ReadLine());

            int[] num_of_people = new int[number_of_rooms];
            int[] capacity = new int[number_of_rooms]; 
            int subtract;
            int avalable_rooms = 0;
            for(int i = 0 ; i < number_of_rooms; i++)
            {
                string[] p_q = Console.ReadLine().Split(' ');
                num_of_people[i] = Convert.ToInt32(p_q[0]);
                capacity[i] = Convert.ToInt32(p_q[1]);
                subtract = capacity[i] - num_of_people[i];
                if(subtract >= 2)
                {
                    avalable_rooms++;
                }
            }
            Console.WriteLine(avalable_rooms);
        }
    }
}