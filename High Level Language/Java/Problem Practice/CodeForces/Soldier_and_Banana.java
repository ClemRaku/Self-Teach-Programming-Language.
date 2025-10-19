import java.util.Scanner;
public class Soldier_and_Banana {
    
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);

        int k = user_input.nextInt();//Cost for banana.
        int n = user_input.nextInt();//He has n amount of money. 
        int w = user_input.nextInt();//Bananas he'll buy.

        int starting_dollar = 1;
        int banana_cost = 0;

        for(int i = 0; i < w; i++)
        {
            banana_cost = banana_cost + (starting_dollar*k);
            starting_dollar = starting_dollar + 1;
        }



        int borrowed_money = banana_cost - n;

        if(n >= banana_cost)
        {
            System.out.println(0);
        }
        else
        {
        System.out.println(borrowed_money);

        user_input.close();
        }
    }
}

/*A soldier wants to buy w bananas in the shop. He has to pay k dollars for the first banana, 2k dollars for 
the second one and so on (in other words, he has to pay i·k dollars for the i-th banana).

He has n dollars. How many dollars does he have to borrow from his friend soldier to buy w bananas? */