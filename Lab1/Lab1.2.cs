using System;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide your first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Provide your Last Name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Your name is : " + fname + " " + lname);
            Console.WriteLine("Your name is {0} {1}", fname, lname);
            Console.ReadLine();
        }
    }
}
