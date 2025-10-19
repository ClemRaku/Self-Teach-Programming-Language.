import java.util.Scanner;

public class Type_Casting_ASCII {
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);
        for(int i = 65; i <= 90 ; i++ )
        {
            char x = ' ';
            x = (char) i;
            System.out.print(" " + x);
        }
        System.out.print("\n");

        for(int i =97 ; i <= 122; i++ )
        {
            char x = ' ';
            x =(char) i;
            System.out.print(" " + x);
        }
        
    }
}
