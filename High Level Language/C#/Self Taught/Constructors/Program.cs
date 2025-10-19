using System;
namespace  Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            Book book2 = new Book("Lord Of the Rings", "Tolkien", 700);

            Console.WriteLine(book2.title);
        }
    }
}