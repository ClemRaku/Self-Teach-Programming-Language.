using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.InteropServices.Marshalling;

namespace BOOK
{
    public class Book
    {
        public string Title{get; set;}
        public bool Available = true;

        public Book(string Title, bool available)
        {
            this.Title = Title;
            Available = available;
        }

        public void BorrowBook()
        {
            Available = false;
        }
        public void ReturnBook()
        {
            Available = true;
        }
    }
    
    public class Member
    {
        public string Name{get; set;}
        public Book member_recievesBOOK{get; set;}
        public Member(string name)
        {
            Name = name;
        }

        public void want_book(Book wantBOOK)
        {
            if(wantBOOK.Available)
            {
                member_recievesBOOK = wantBOOK;
                wantBOOK.BorrowBook();
                Console.WriteLine($"The book, {wantBOOK.Title} has been given to {Name}");
            }
            else
            {
                Console.WriteLine($"{wantBOOK.Title}, book not Available");
            }
        }

        public void return_book(Book wantBook)
        {
            if(!wantBook.Available)
            {
                wantBook.ReturnBook();
                Console.WriteLine("Book has been Returned");
            }
            else
            {
                Console.WriteLine("Book is already present.\n\nNOO NEED TO RETURN!!!");
            }
        }
        
        class Program
        {
            public static void Main(string[] args)
            {
                Book LOTR = new Book("Lord of the Rings", true);
                Book HP = new Book("Harry Potter", false);

                Member Raka = new Member("Raka");
                Member Debu = new Member("Debu");

                Raka.want_book(LOTR);
                Debu.want_book(LOTR);
                Raka.want_book(HP);
            }
        }
    }
}