using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1__Abstraction
{
    class Rectangle
    {

    }
    class Program
    {
        public static void PrintRow(int s, int i)
        {
            for (int j = 1; j <= (s - i); j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Sizes: ");
            int s = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= s; i++)
            {
                PrintRow(s, i);
            }
            for (int i = s - 1; i >= 1; i--)
            {
                PrintRow(s, i);
            }
            Console.ReadKey();
        }
    }
}
