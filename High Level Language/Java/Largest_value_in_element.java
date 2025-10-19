import java.util.Arrays;
import java.util.Scanner;

public class Largest_value_in_element {
    public static void main(String[] args)
    {
        Scanner user_input = new Scanner(System.in);

        System.out.print("Enter the size of the Array: ");
        int size_of_arr = user_input.nextInt();
        int[] arr = new int[size_of_arr];

        for(int i = 0; i < size_of_arr; i++)
        {
            System.out.print("Enter: ");
            arr[i] = user_input.nextInt();
        }

        Arrays.sort(arr);

        int largest_element_index = size_of_arr - 1;
        System.out.println("Largest element is " + arr[largest_element_index]);

    }
}
