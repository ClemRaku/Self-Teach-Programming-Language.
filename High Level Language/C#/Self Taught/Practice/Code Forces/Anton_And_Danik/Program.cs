using System;
namespace Anton_and_Danik
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//number of games
            string AD = Console.ReadLine();
            int countANTON = 0, countDanik = 0;
            
            foreach (char i in AD)
            {
                if(i == 'A')
                {
                    countANTON++;
                }
                else
                {
                    countDanik++;
                }
            } 
            if(countANTON > countDanik)
            {
                Console.WriteLine("Anton");
            }
            else if(countDanik > countANTON)
            {
                Console.WriteLine("Danik");
            }
            else
            {
                Console.WriteLine("Friendship");
            }
        }
    }
}