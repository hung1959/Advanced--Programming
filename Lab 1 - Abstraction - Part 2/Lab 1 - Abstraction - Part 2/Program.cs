using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Abstraction___Part_2
{
    class Student
    {
        List<Student> students;
        string studentName;
        int studentAge;
        double studentGrade;
        public Student(string name, int age, double grade)
        {
            studentName = name;
            studentAge = age;
            studentGrade = grade;
        }
        public void Create(string name, int age, double grade)
        {
            Student student = new Student(name, age, grade);
            students.Add(student);
        }
        public string StudentComment()
        {
            if (studentGrade > 0)
            {
                if (studentGrade >= 5)
                {
                    return "Excellent student.";
                }
                else if (studentGrade >= 3.5)
                {
                    return "Average student.";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "Invalid grade";
            }
        }
        public void Show(string name)
        {
            if (students.Contains(name))
            {

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Create: ");
            string studentName = Console.ReadLine();
            int studentAge = Convert.ToInt32(Console.ReadLine());
            decimal studentGrade = Convert.ToInt32(Console.ReadLine());

        }
    }
}
