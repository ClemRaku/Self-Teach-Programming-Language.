package com.example;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner user_input = new Scanner(System.in);

        System.out.print("Enter the size of the array: ");
        int sizeARRAY = user_input.nextInt();

        int[] arr = new int[sizeARRAY];

        for(int i = 0; i < sizeARRAY; i++)
        {
            System.out.print("Enter: ");
            arr[i] = user_input.nextInt();
        }

        
        System.out.print("Search: ");
        int search = user_input.nextInt();
        boolean found = false;

        for(int i = 0; i < sizeARRAY; i++)
        {
            if(search == arr[i])
            {
                System.out.println("FOUND the ELEMENT at position : " + i);
                found = true;
                break;
            }
        }
        if(!found)
        {
            System.out.println("VALUE isn't found");
        }

        user_input.close();
    }
}