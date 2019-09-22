using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Polymorphysm___Part_2
{
    class Animal
    {
        protected string name { get; set; }
        protected string favouriteFood { get; set; }
        public Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }
        public virtual string ExplainSelf()
        {
            return "";
        }
    }
    class Dog : Animal
    {
        public Dog (string n, string f) : base(n, f) { }
        public override string ExplainSelf()
        {
            return "I am " + name + "and my favourite food is " + favouriteFood + "\nDJAAF";
        }
    }
    class Cat : Animal
    {
        public Cat(string n, string f) : base(n, f) { }
        public override string ExplainSelf()
        {
            return "I am " + name + "and my favourite food is " + favouriteFood + "\nMEEOW";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Pesho", "Whiskas");
            Animal dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
            Console.ReadKey();
        }
    }
}
