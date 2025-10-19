using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;
namespace School_management_system
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)//This is known as the constructor.
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person Constructor Called");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"The name is {Name} and the age is {Age}");
        }
    }

    public class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
            Console.WriteLine("Teacher Constructor is called");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Subject: {Subject}");
        }
    }

    public class Student : Person
    {
        public int Grade { get; set; }

        public Student(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            Console.WriteLine("Student Constructor is called");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person("Raka", 21);
            Teacher t1 = new Teacher("Shapla", 45, "English");
            Student s1 = new Student("Deb", 20, 4);

            p1.DisplayInfo();
            t1.DisplayInfo();
            s1.DisplayInfo();
        }
    }
}