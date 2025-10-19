using System;
namespace Rough
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car Tesla = new Car();
            Tesla.brand = "Tesla";
            Tesla.rating = 10;
            Tesla.model = "V10";

            Car Audi = new Car();
            Audi.brand = "Audi";
            Audi.rating = 10;
            Audi.model = "SQ";

            Console.WriteLine("TWO CARS AVAILABLE");
            Console.WriteLine($"Brand of the first car is {Tesla.brand}, model is {Tesla.model} & rating is {Tesla.rating}\nBrand of the second car is {Audi.brand}, model is {Audi.model} & rating is {Audi.rating}");
        }
    }
    public class Car
    {
        public string brand;
        public string model;
        public int rating;
    }
}