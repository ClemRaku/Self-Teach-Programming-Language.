using System;

class Program
{
    static void Main()
    {
        // Read the entire input line
        string input = Console.ReadLine();
        
        // Split the input based on spaces
        string[] inputs = input.Split(' ');

        // Convert the string array to integers (or any other type)
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        int c = int.Parse(inputs[2]);

        // Output the values to verify
        Console.WriteLine($"a: {a}, b: {b}, c: {c}");
    }
}
