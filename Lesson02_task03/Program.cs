using System;

namespace Lesson02_task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter ticket number: ");
            string ticket = Console.ReadLine();
            MyClass cl = new MyClass();
            if (cl.IsLuckyTicket(ticket))
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("Try another one!");
            }
        }
    }
    class MyClass
    {
        public bool IsLuckyTicket(string ticket)
        {
            int input;
            bool Correct = int.TryParse(ticket, out input);
            if (Correct == false || ticket.Length != 6)
            {
                return false;
            }
            int a = 0;
            int b = 0;
            for (int i = 0; i < 6; i++)
            {
                if (i < 3)
                {
                    a += input % 10;
                }
                else
                {
                    b += input % 10;
                }
                input /= 10;
            }
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
