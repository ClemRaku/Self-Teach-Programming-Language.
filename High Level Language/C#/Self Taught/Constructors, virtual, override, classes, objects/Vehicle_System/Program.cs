using System;
using System.ComponentModel;
namespace Vehicle_System
{
    //Scenario: Create a `Vehicle` class and extend it into `Car` and `Bike`. Add fuel capacity methods.
    public class Vehicle
    {
        public string brand{get; set;}
        public double fuel_capacity{get; set;}

        public double current_fuel{get; set;}
        public Vehicle(string BRAND, double FUEL_CAPACITY, double current_fuel)
        {
            brand = BRAND;
            fuel_capacity = FUEL_CAPACITY;
            this.current_fuel = current_fuel;
        }

        public virtual void Refuel()
        {
            Console.WriteLine($"The {brand} can max contain {fuel_capacity}");
        }
    }

    public class Car : Vehicle
    {
        
        public Car(string Brand, double current_fuel, double capacity_fuel) : base(Brand, capacity_fuel, current_fuel)
        {}
        public override void Refuel()
        {
            base.Refuel();
            if(current_fuel < fuel_capacity)
            {
                double x = fuel_capacity - current_fuel;
                Console.WriteLine($"{x} litres of fuel as been added. REFUELED!!");
            }
            else
            {
                Console.WriteLine($"{brand} already has max amount of Fuel");
            }
        }
    }

    public class Bike : Vehicle
    {
        public Bike(string Brand, double current_fuel, double capacity_fuel) : base(Brand, capacity_fuel, current_fuel)
        {}
        public override void Refuel()
        {
            base.Refuel();
            if(current_fuel < fuel_capacity)
            {
                double x = fuel_capacity - current_fuel;
                Console.WriteLine($"{x} litres of fuel as been added. REFUELED!!");
            }
            else
            {
                Console.WriteLine($"{brand} already has max amount of Fuel");
            }
        }
    }
    
    
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Car Audi = new Car("Audi", 110, 200);

            Bike b2 = new Bike("Honda", 200, 200);

            Audi.Refuel();
            b2.Refuel();
        }
    }
}