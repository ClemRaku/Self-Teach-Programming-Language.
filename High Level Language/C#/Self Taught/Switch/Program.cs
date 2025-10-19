using System;
using System.Globalization;
using System.Runtime.CompilerServices;
namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day number from 0 to 6: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetDay(num));
        }

        static string GetDay(int dayNum)
        {
            string dayName;
            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default://basically an 'else' statement
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }
    }
}