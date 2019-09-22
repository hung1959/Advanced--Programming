using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Inheritance___Part2
{
    class RandomList
    {
        List<string> list;
        public RandomList()
        {
            list = new List<string>();
        }
        public void Add(string n)
        {
            list.Add(n);
        }
        public int RandomIndex()
        {
            Random rd = new Random();
            int index = rd.Next(list.Count);
            return index;
        }
        public void Remove()
        {
            list.RemoveAt(RandomIndex());
        }
        public int ListCount()
        {
            return list.Count();
        }
        public void Print()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            RandomList testlist = new RandomList();
            testlist.Add("one");
            testlist.Add("two");
            testlist.Add("three");
            testlist.Add("four");
            testlist.Add("five");
            testlist.Print();
            Console.Write("Enter 1 to remove random element: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n == 1)
            {
                testlist.Remove();
                Console.WriteLine();
                testlist.Print();
                Console.Write("Enter 1 to remove random element: ");
                n = Convert.ToInt32(Console.ReadLine());
                while (n != 1)
                {
                    Console.Write("Enter 1 to remove random element: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (n != 1)
            {
                Console.Write("Enter 1 to remove random element: ");
                n = Convert.ToInt32(Console.ReadLine());
                while (n == 1)
                {
                    testlist.Remove();
                    Console.WriteLine();
                    testlist.Print();
                    Console.Write("Enter 1 to remove random element: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadKey();
        }
    }
}
