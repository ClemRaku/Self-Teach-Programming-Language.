using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Permissions;

namespace E_commerce
{
    //Scenario: Build `Product`, `Order`, and `Customer` classes to manage an e-commerce system.
    public class Product
    {
        public string Name { get; set; }
        public bool available { get; set; }
        public int Price { get; set; }

        public Product(string name_of_product, bool availability, int cost)
        {
            Name = name_of_product;
            available = availability;
            Price = cost;
        }


    }

    public class Customer
    {
        double moneybag { get; set; }
        string name { get; set; }
        public Customer(string naam, double balance)
        {
            moneybag = balance;
            name = naam;
        }


        public void BuyProduct(Product y, Customer name)
        {
            if (y.Price < moneybag)
            {
                moneybag -= y.Price;
                Console.WriteLine($"{y.Name} has been bought by {name.name}. Remaining funds are {moneybag}");
            }
            else { Console.WriteLine($"{name.name} has Insufficient Funds."); }
        }
    }
    public class Order
    {
        Product item { get; set; }
        Customer Cus { get; set; }
        public Order(Product x, Customer c)
        {
            item = x;
            Cus = c;
            if (x.available)
            {
                Cus.BuyProduct(x , Cus);
            }
            else{Console.WriteLine($"{item.Name} isn't available");}
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Product Milk = new Product("Dano Milk Powder", true, 155);
            Product ColdDrink = new Product("CocoCola", false, 30);
            
            Customer C1 = new Customer("Raka", 500);
            Customer C2 = new Customer("Debu", 20);

            Order order1 = new Order(Milk, C1);
            Order order2 = new Order(Milk, C2);
            Order order3 = new Order(ColdDrink, C1);


        }
    }
}