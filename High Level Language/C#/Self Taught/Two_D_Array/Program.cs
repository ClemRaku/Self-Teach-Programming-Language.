using System;
namespace Two_D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //putting a comma inside the square brackets tells C# that its a 2d array
            //The more commas there are, the more dimensions there are.
            int[,] numberGrid = {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            Console.WriteLine(numberGrid[1, 1]);

            //To DECLARE AN ARRAY one must
            int[,] myArray = new int[2, 3];
            //the parameters in the "new int" , are the storage spaces.
        }

    }
}