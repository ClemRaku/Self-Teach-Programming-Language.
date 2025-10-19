using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.InteropServices.Marshalling;

namespace Animal_onomatopoeia
{
    //Scenario: Create an `Animal` class. `Dog` and `Cat` inherit from `Animal`. Each class should override a `Speak` method.

    public class Animal
    {
        string Species{get; set;}

        public Animal(string animal_name)
        {
            Species = animal_name;
        }

        public virtual void Speak()
        {
            Console.WriteLine($"The animal is a {Species}");
        }
    }

    public class Dog : Animal
    {
        string name_of_dog{get; set;}
        public Dog(string name, string type_of_dog) : base(type_of_dog)
        {
            name_of_dog = name;
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine($"They make BARK BARK sounds");
        }
    }

    public class Cat : Animal
    {
        string name_of_cat{get; set;}
        public Cat(string name, string type_of_cat) : base(type_of_cat)
        {
            name_of_cat = name;
        }

        public override void Speak()
        {
            base.Speak();
            Console.WriteLine($"They make MEOW MEOW sounds");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Dog Roxy = new Dog("Roxy", "Shiba Dog");
            Cat Clementine = new Cat("Clementine", "Orange Cat");

            Roxy.Speak();
            Clementine.Speak();
        }
    }
}