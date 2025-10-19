import java.util.Arrays;
import java.util.Scanner;

public class Binary_search {
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);
        
        System.out.print("Size of Array: ");
        int size_arr = user_input.nextInt();
        int[] arr = new int[size_arr];

        for(int i = 0; i < size_arr; i++)
        {
            System.out.print("Enter: ");
            arr[i] = user_input.nextInt();
        }
        Arrays.sort(arr);
        System.out.print("Search: ");
        int search = user_input.nextInt();

        int left, right, mid;

        left = 0;
        right = size_arr - 1;
        boolean found = false;
        while(left <= right)
        {
            mid = (left + right) / 2;
            if(arr[mid] == search)
            {
                found = true;
                break;
            }
            else if(search < arr[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        if(found)
        {
            System.out.println("FOUND!!");
        }
        else
        {
            System.out.println("NOT FOUND!!!");
        }
    }
}
