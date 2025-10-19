import java.util.Scanner;
public class Ultra_Fast_Mathematician {
    
    public static void main(String[] args)
    {
        Scanner input = new Scanner(System.in);

        String first_num = input.nextLine();
        String second_num = input.nextLine();

        int loop_time = first_num.length();
        
        String answer = "";
        for(int i = 0 ; i < loop_time; i++)
        {
            if(first_num.charAt(i) == second_num.charAt(i))//note how to call the string index.
            {
                answer += '0';
            }
            else
            {
                answer += '1';
            }
        }

        System.out.println(answer);
        input.close();
    }
}