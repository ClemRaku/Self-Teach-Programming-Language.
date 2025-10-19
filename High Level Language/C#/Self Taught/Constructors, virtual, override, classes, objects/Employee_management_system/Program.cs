using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.InteropServices.Marshalling;

namespace Employee_management_system
{
    //Scenario: Create `Employee` as the base class and `Manager` and `Developer` as derived classes. Override the `Work` method for each.

    class Employee
    {
        public string name{get; set;}
        public string Position{get; set;}
        public int Salary{get; set;}

        public Employee(string name, string job_title, int income)
        {
            this.name = name;
            Position = job_title;
            Salary = income;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{name}'s position is: {Position}\nSalary: {Salary}\n\n");
        }
    }

    class Manager : Employee
    {
        public Manager(string name, string job_position, int income) : base(name, job_position, income)
        {}

        public override void Work()
        {
            base.Work();
            Console.WriteLine($"{name} is managing the team.");
        }
    }

    class Developer : Employee
    {
        public Developer(string nam, string job_titl, int sal) : base(nam, job_titl, sal)
        {}

        public override void Work()
        {
            base.Work();
            Console.WriteLine($"{name} is working as a developer, under the manager");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Manager Raka = new Manager("Raka", "Manager", 100000);
            Developer Debu = new Developer("Debottom Chakma", "Developer", 15000);

            Raka.Work();
            Debu.Work();
        }
    }
}