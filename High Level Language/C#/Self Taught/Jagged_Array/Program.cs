using System;

class Program
{
    static void Main()
    {
        // Declare and initialize the jagged array
        int[][] jaggedArray = new int[3][]; // Array with 3 inner arrays
        
        // Initialize the inner arrays with different lengths
        jaggedArray[0] = new int[2];  // First row has 2 elements
        jaggedArray[1] = new int[3];  // Second row has 3 elements
        jaggedArray[2] = new int[1];  // Third row has 1 element

        // Assign values to the elements
        jaggedArray[0][0] = 1;
        jaggedArray[0][1] = 2;

        jaggedArray[1][0] = 3;
        jaggedArray[1][1] = 4;
        jaggedArray[1][2] = 5;

        jaggedArray[2][0] = 6;

        // Display the values in the jagged array
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row {0}: ", i);
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
