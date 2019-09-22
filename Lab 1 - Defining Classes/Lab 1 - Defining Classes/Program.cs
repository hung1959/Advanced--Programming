using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1___Defining_Classes
{
    class BankAccount
    {
        private int id;
        private decimal balance;
        public int Id;
        public decimal Balance;
        public void setBalance()
        {
            Balance = 0;
        }
        public decimal GetBalance()
        {
            return Balance;
        }
        public BankAccount(int id, decimal balance)
        {
            Id = id;
            Balance = balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount < 0 || amount == 0)
            {
                Console.WriteLine("Invalid amount!");
            }
            else
            {
                Balance = Balance + amount;
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Your account does not have enough money!");
            }
            else
            {
                Balance = Balance - amount;
            }
        }
        public void Print()
        {
            
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    class Person
    {
        string name;
        int age;
        List<BankAccount> accounts;
        public Person(string n, int a, List<BankAccount> acc)
        {
            name = n;
            age = a;
            accounts = acc;
        }
        public decimal GetBalance()
        {
            return accounts.Sum(x => x.Balance);
        }
    }
    class Program
    {
        //public bool IsIdExists(int id)
        //{
        //    return accounts.Exists(x => x.Id == id);
        //}
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount(1, 15);
            //acc.Deposit(15);
            //acc.Withdraw(10);
            //Console.WriteLine($"Account {acc.Id}, Balance {acc.Balance}");
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount(1, 15));
            Console.WriteLine("- Bank Menu -");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Print");
            Console.WriteLine("5. Exit");
            Console.Write("Please enter your command: ");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input != 5)
            {
                if (input > 5 || input < 0)
                {
                    Console.WriteLine("Invalid Command!");
                    Console.Write("Please enter your command: ");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    switch (input)
                    {
                        case 1:
                            Console.Write("Input your ID: ");
                            int inputID = Convert.ToInt32(Console.ReadLine());
                            if (accounts.Exists(x => x.Id == inputID) == true)
                            {
                                Console.WriteLine("ID already exist!");
                                Console.Write("Please enter your command: ");
                                input = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                accounts.Add(new BankAccount(inputID, 0));
                                Console.WriteLine("Account adding successful!");
                                Console.Write("Please enter your command: ");
                                input = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                        case 2:
                            Console.WriteLine("Enter your account ID: ");
                            int depositID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter amount: ");
                            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                            if (accounts.Exists(x => x.Id == depositID) == false)
                            {
                                Console.WriteLine("ID does not exist!");
                                Console.Write("Please enter your command: ");
                                input = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                for (int i = 0; i <= accounts.Count; i++)
                                {
                                    if (i == depositID)
                                    {
                                        accounts.Find(x => x.Id == depositID).Deposit(depositAmount);
                                        Console.WriteLine("Your current balance: {0}", accounts.Find(x => x.Id == depositID).Balance);
                                        Console.Write("Please enter your command: ");
                                        input = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter your account ID: ");
                            int withdrawID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter amount: ");
                            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                            if (accounts.Exists(x => x.Id == withdrawID) == false)
                            {
                                Console.WriteLine("ID does not exist!");
                                Console.Write("Please enter your command: ");
                                input = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                for (int i = 0; i <= accounts.Count; i++)
                                {
                                    if (i == withdrawID)
                                    {
                                        accounts.Find(x => x.Id == withdrawID).Withdraw(withdrawAmount);
                                        Console.WriteLine("Your current balance: {0}", accounts.Find(x => x.Id == withdrawID).Balance);
                                        Console.Write("Please enter your command: ");
                                        input = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter your account ID: ");
                            int printID = Convert.ToInt32(Console.ReadLine());
                            if (accounts.Exists(x => x.Id == printID) == false)
                            {
                                Console.WriteLine("ID does not exist!");
                                Console.Write("Please enter your command: ");
                                input = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                for (int i = 0; i <= accounts.Count; i++)
                                {
                                    if (i == printID)
                                    {
                                        accounts.Find(x => x.Id == printID).Print();
                                        Console.WriteLine("Your current balance: {0}", accounts.Find(x => x.Id == printID).Balance);
                                        Console.Write("Please enter your command: ");
                                        input = Convert.ToInt32(Console.ReadLine());
                                    }
                                }
                            }
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
