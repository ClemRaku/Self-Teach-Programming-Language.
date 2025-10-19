using System;
namespace Shape_System
{
    //Scenario: Create a base class `Shape`, and derive `Circle` and `Rectangle`. Override a method to calculate the area.
    public abstract class Shape
    {
        public abstract void Display_Area();
    }

    public class Circle : Shape
    {
        double Radius{get; set;}
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void Display_Area()
        {
            Console.WriteLine(Math.PI * Math.Pow(Radius, 2));
        }
    }

    public class Rectangle : Shape
    {
        double length{get; set;}
        double width{get; set;}

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public override void Display_Area()
        {
            Console.WriteLine(length * width);
        }
    }
    
    
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle football = new Circle(23);
            Rectangle keybaord = new Rectangle(2.3, 4.5);

            football.Display_Area();
            keybaord.Display_Area();
        }
    }
}