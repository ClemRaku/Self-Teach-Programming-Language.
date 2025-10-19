using System;
using System.Data.Common;
namespace Vehicle_System
{
//Scenario: Create a `Vehicle` class and extend it into `Car` and `Bike`. Add fuel capacity methods.
    public class Vehicle
    {
        string Brand{get; set;}
        string name{get; set;}

        public Vehicle(string brand, string name)
        {
            this.name = name;
            Brand = brand;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("The Vehicle's Brand is " + Brand);
        }
    }

//Interface
    public interface IfuelCapacity
    {
        public void PrintFuelAmount();

    }

    public abstract class Money
    {
        public abstract void Money_Math();
    }//haven't used abstracter yet.

//Inheritance and Interface
    public class Car : Vehicle , IfuelCapacity
    {
        double fuelCapacity{get; set;}
        public Car(string Name, string Brand,  double FC) : base(Brand, Name)
        {
            fuelCapacity = FC;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"{100 - fuelCapacity} is being filled up.");
        }

        //interface
        public void PrintFuelAmount()
        {
            Console.WriteLine($"{100 - fuelCapacity}% Fuel has been Filled.");
        }




// MAIN CLASS BELOW
    public class Program
    {
        public static void Main(string[] args)
        {
            Car c1 = new Car("Rx7", "Mazda", 35);
            c1.DisplayInfo();
            c1.PrintFuelAmount();
        }
    }


    }
}