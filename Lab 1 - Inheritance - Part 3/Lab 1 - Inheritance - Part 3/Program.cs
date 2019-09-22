using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Inheritance___Part_3
{
    class StackOfStrings
    {
        Stack<string> data;
        public StackOfStrings()
        {
            data = new Stack<string>();
        }
        public void Push(string item)
        {
            data.Push(item);
        }
        public string Pop()
        {
            return data.Pop();
        }
        public string Peek()
        {
            return data.Peek();
        }
        public bool IsEmpty()
        {
            if (data.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Print()
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StackOfStrings testStack = new StackOfStrings();
            testStack.Push("1");
            testStack.Push("2");
            testStack.Push("3");
            testStack.Push("4");
            testStack.Push("5");
            testStack.Print();
            testStack.Pop();
            Console.WriteLine();
            testStack.Peek();
            testStack.Print();
            Console.WriteLine();
            if (testStack.IsEmpty() == true)
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                Console.WriteLine(" Stack is not empty!");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
