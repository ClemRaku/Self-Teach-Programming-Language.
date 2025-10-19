using System;

class Program
{
    static void Main()
    {
        string numberStr = "123";
        int number = int.Parse(numberStr);
        Console.WriteLine(number);  // Output: 123

        string floatStr = "123.45";
        double floatNumber = double.Parse(floatStr);
        Console.WriteLine(floatNumber);  // Output: 123.45

        string boolStr = "true";
        bool flag = bool.Parse(boolStr);
        Console.WriteLine(flag);  // Output: True

        string dateStr = "2023-09-05";
        DateTime date = DateTime.Parse(dateStr);
        Console.WriteLine(date);  // Output: 9/5/2023 12:00:00 AM

    }
}
