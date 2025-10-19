import java.util.Scanner;

public class Odd_or_Even {
    public static void main(String[] args)
    {
        /*Write a java program that takes a number from the keyboard and
    checks whether it is odd or even. Do this using the ternary
    operator */

    int a;
    Scanner user_input = new Scanner(System.in);
    
    a = user_input.nextInt();

    String answer;

    answer = (a % 2 == 0) ? "EVEN" : "ODD";

    System.out.println(answer);

    user_input.close();

    }
}
