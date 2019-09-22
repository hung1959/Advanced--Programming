using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Encapsulation
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public decimal Salary;
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }
        public decimal IncreaseSalary(decimal percentage)
        {
            if (Age < 30)
            {
                Salary = Salary + Salary * (percentage / 2) / 100;
                return Salary;
            }
            else
            {
                Salary = Salary + Salary * percentage / 100;
                return Salary;
            }
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " gets " + Salary + " leva";
        }
    }
    class Team
    {
        string name;
        List<Person> firstTeam;
        List<Person> reserveTeam;
        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }
        public List<Person> FirstTeam
        {
            get
            {
                return firstTeam;
            }
        }
        public List<Person> ReserveTeam
        {
            get
            {
                return reserveTeam;
            }
        }
        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 3
            //var lines = int.Parse(Console.ReadLine());
            //var persons = new List<Person>();
            //for (int i = 0; i < lines; i++)
            //{
            //    var cmdArgs = Console.ReadLine().Split();
            //    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
            // Problem 4
            var lines = int.Parse(Console.ReadLine());
            var team = new Team("SoftUni");
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));

                team.AddPlayer(person);

                Console.WriteLine("First team has " + team.FirstTeam.Count() + " players");
                Console.WriteLine("Reserve team has " + team.ReserveTeam.Count() + " players");
            }
            Console.ReadKey();
        }
        //Problem 3
        //    if (cmdArgs[0].Length < 3 || cmdArgs[1].Length < 3 || int.Parse(cmdArgs[2]) <= 0 || decimal.Parse(cmdArgs[3]) < 460)
        //    {
        //        if (cmdArgs[0].Length < 3)
        //        {
        //            Console.WriteLine("First name cannot contain fewer than 3 symbols!");
        //        }
        //        if (cmdArgs[1].Length < 3)
        //        {
        //            Console.WriteLine("Last name cannot contain fewer than 3 symbols!");
        //        }
        //        if (int.Parse(cmdArgs[2]) <= 0)
        //        {
        //            Console.WriteLine("Age cannot be zero or a negative integer!");
        //        }
        //        if (decimal.Parse(cmdArgs[3]) < 460)
        //        {
        //            Console.WriteLine("Salary cannot be less than 460 leva!");
        //        }
        //    }
        //    else
        //    {
        //        persons.Add(person);
        //        persons.ForEach(p => Console.WriteLine(p.ToString()));
        //    }
        //}
        //    Console.ReadKey();
    }

    //Problem 1
    //var lines = int.Parse(Console.ReadLine());
    //var persons = new List<Person>();
    //for (int i = 0; i < lines; i++)
    //{
    //    var cmdArgs = Console.ReadLine().Split();
    //    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
    //    persons.Add(person);
    //}

    //persons.OrderBy(p => p.FirstName)
    //           .ThenBy(p => p.Age)
    //           .ToList()
    //           .ForEach(p => Console.WriteLine(p.ToString()));

    // Problem 1, 3
    //var bonus = decimal.Parse(Console.ReadLine());

    // Problem 2
    //persons.ForEach(p => p.IncreaseSalary(bonus));
    //persons.ForEach(p => Console.WriteLine(p.ToString()));
}
