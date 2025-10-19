using System;
namespace Chat_room
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the word: ");
            string s = Console.ReadLine();

            bool h_absent = true;
            bool e_absent = true;
            bool l1_absent = true;
            bool l2_absent = true;
            bool ll_absent = true;
            bool o_absent = true;
            bool all_present = false;

            int length_of_string =  s.Length;

            for(int i = 0 ; i < length_of_string; i++)
            {
                if(h_absent && e_absent && ll_absent && o_absent)
                {
                    if(s[i] == 'h')
                    {
                        h_absent = false;
                    }
                }
                else if(!h_absent && e_absent && ll_absent && o_absent)
                {
                    if(s[i] == 'e')
                    {
                        e_absent = false;
                    }
                }
                else if(!h_absent && !e_absent && ll_absent && o_absent)
                {
                    if(l1_absent && l2_absent)
                    {
                        if(s[i] == 'l')
                        {
                            l1_absent = false;
                        }
                    }
                    else if(!l1_absent && l2_absent)
                    {
                        if(s[i] == 'l')
                        {
                            l2_absent = false;
                            ll_absent = false;
                        }
                    }
                }
                else if(!h_absent && !e_absent && !ll_absent && o_absent)
                {
                    if(s[i] == 'o')
                    {
                        o_absent = false;
                        all_present = true;
                    }
                }
            }
            if(all_present)
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