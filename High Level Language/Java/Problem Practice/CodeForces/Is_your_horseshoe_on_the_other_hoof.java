import java.util.Arrays;
import java.util.Scanner;

public class Is_your_horseshoe_on_the_other_hoof
{
    public static void main(String[] args)
    {

    Scanner user_input = new Scanner(System.in);
    int[] s = new int[4];
    s[0] = user_input.nextInt();
    s[1] = user_input.nextInt();
    s[2] = user_input.nextInt();
    s[3] = user_input.nextInt();
    int min_num_of_horseshoes_need_buy = 0;

    Arrays.sort(s);
    for(int i = 0; i < 3; i++)
    {
        if(s[i] == s[i+1])
        {
            min_num_of_horseshoes_need_buy++;
        }
        else
        {
            continue;
        }
    }
    System.out.println(min_num_of_horseshoes_need_buy);
    user_input.close();


}
}