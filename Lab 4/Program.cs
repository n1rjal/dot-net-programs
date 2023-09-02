using System;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value for a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value for b: ");
            int b = int.Parse(Console.ReadLine());
            bool c = a < b;
            Console.WriteLine("b is greater than a?");
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
