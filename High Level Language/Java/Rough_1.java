import java.util.Arrays;
import java.util.Scanner;

public class Rough_1 {
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);
        int length_of_string = user_input.nextInt();
        String word = user_input.next(); //reads only one word, whereas nextLine reads the whole line including whitespaces.
        
        String unique_word = Removing_double_letters(word, length_of_string).toUpperCase();

        int ASCII_total = 0;
        for(int i = 0; i < unique_word.length(); i++)
        {
            ASCII_total += (int)unique_word.charAt(i);
        }


        System.out.println(ASCII_total + " " + unique_word);


        if(ASCII_total == 2015)
        {
            System.out.println("YES");
        }
        else
        {
            System.out.println("NO");
        }
    }


    public static String Removing_double_letters(String x, int L)
    {
        char[] arranged_letters = x.toCharArray();
        Arrays.sort(arranged_letters);

        char[] unique_letters = new char[L];
        int c = 1;
        unique_letters[0] = arranged_letters[0];
        for(int i = 1 ; i < L; i++)
        {
            if(arranged_letters[i] != arranged_letters[i-1])
            {
                unique_letters[c] = arranged_letters[i];
                c++;
            }
        }

        String done = new String(unique_letters, 0, c);//note this

        return done;



        
    }
}
