import java.util.Scanner;

public class Linear_search {
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);
        
        System.out.print("Enter Size of array: ");
        int size_of_arr = user_input.nextInt();
        int[] arr = new int[size_of_arr];

        for(int i = 0; i < arr.length; i++)
        {
            System.out.print("Enter: ");
            arr[i] = user_input.nextInt();
        }

        System.out.print("Search: ");
        int search = user_input.nextInt();
        boolean found = false;
        int position = 0;
        for(int i = 0; i < size_of_arr; i++)
        {
            if(arr[i] == search)
            {
                position = i + 1;
                found = true;
                break;
            }
            else
            {
                continue;
            }
        }

        if(found)
        {
            System.out.println("FOUND at position, " + position);
        }
        else
        {
            System.out.println("NOT FOUND");
        }

    }
}
