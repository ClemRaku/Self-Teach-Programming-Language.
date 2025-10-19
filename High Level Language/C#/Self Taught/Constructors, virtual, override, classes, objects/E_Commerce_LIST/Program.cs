using System;
using System.Security.Cryptography;
namespace Groceries
{
    //Scenario: Build `Product`, `Order`, and `Customer` classes to manage an e-commerce system.
    public class Customer
    {
        public string Name{get; set;}
        public Customer(string name)
        {
            Name = name;
        }
        public void DisplayNameOfCustomer()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    public class Product
    {
        public string Product_Name{get; set;}
        public double Price{get; set;}
        public Product(string P_NAM, double cost)
        {
            Product_Name = P_NAM;
            Price = cost;
        }
    }

    public class Order : Customer
    {
        List<Product> PP{get; set;} = new List<Product>();
        double sum = 0;
        public Order(string naam) : base(naam)
        {}

        public void AddProduct(Product P)
        {
            PP.Add(P);
            sum += P.Price;
        }

        public void DisplayTotalPrice()
        {
            Console.WriteLine($"Total price is {sum}");
        }
        
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Product ColdDrink = new Product("Cocola", 25);
            Product dryFood = new Product("Lexux", 10);

            Order order1 = new Order("Raka");
            
            Order order2 = new Order("Debo");

            order1.AddProduct(ColdDrink);
            order1.AddProduct(ColdDrink);
            order1.AddProduct(dryFood);
            order1.DisplayNameOfCustomer();
            order1.DisplayTotalPrice();

        }
    }
}