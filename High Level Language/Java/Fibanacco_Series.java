import java.util.Scanner;

public class Fibanacco_Series
{
    public static void main(String args[])
    {
        int a, b, c, num;
        c= 0;
        //0 + 1 + 1 + 2 + 3
        a = 0;
        b = 1;

        Scanner user_input = new Scanner(System.in);
        num = user_input.nextInt();

        if(num == 1)
        {
            System.out.println(a);
        }
        else if(num == 2)
        {
            System.out.println(b);
        }
        else
        {
            for(int i = 2 ; i < num; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            System.out.println(c);
        }

        

    }
}