using System;

class Program
{
    static void Main()
    {
        // Create an instance of the Random class
        Random random = new Random();

        // Generate a random integer
        int randomInt = random.Next();
        Console.WriteLine($"Random integer: {randomInt}");

        // Generate a random integer between 0 and 100
        int randomIntInRange = random.Next(0, 101);
        Console.WriteLine($"Random integer between 0 and 100: {randomIntInRange}");

        // Generate a random double between 0.0 and 1.0
        double randomDouble = random.NextDouble();
        Console.WriteLine($"Random double between 0.0 and 1.0: {randomDouble}");

        // Generate a random array of bytes
        byte[] randomBytes = new byte[10];
        random.NextBytes(randomBytes);
        Console.WriteLine("Random bytes: " + BitConverter.ToString(randomBytes));
    }
}
