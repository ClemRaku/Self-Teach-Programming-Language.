using System;
namespace classes_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord Of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            
            
            Console.WriteLine("There are two books present. Which book do you want to access? book 1 or book 2?");
            string choicebook = Console.ReadLine();
            
            string finalQuesAns;
            
        
            if(choicebook == "Book 1" || choicebook == "book 1")
            {
                Console.WriteLine("What do you want to know 'bout the Book? Author or number of pages or title?");
                finalQuesAns = Console.ReadLine();

                if(finalQuesAns == "Author" || finalQuesAns == "author")
                {
                    Console.WriteLine(book1.author);
                }
                else if(finalQuesAns == "Title" || finalQuesAns == "title")
                {
                    Console.WriteLine(book1.title);
                }
                else
                {
                    Console.WriteLine(book1.pages);
                }
            }
            else
            {
                Console.WriteLine("What do you want to know 'bout the Book? Author or number of pages or title?");
                finalQuesAns = Console.ReadLine();
                if(finalQuesAns == "Author" || finalQuesAns == "author")
                {
                    Console.WriteLine(book2.author);
                }
                else if(finalQuesAns == "Title" || finalQuesAns == "title")
                {
                    Console.WriteLine(book2.title);
                }
                else
                {
                    Console.WriteLine(book2.pages);
                }
            }
        }
    }
}