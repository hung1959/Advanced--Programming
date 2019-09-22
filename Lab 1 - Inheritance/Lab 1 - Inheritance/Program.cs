using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Inheritance
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }
    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("weeping...");
        }
    }
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("meowing...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
            Console.ReadKey();
        }
    }
}
