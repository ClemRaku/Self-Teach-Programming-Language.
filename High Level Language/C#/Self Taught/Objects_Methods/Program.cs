using System;
namespace Objects_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }
    }
}