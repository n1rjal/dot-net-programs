using System;
namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            int product = num1 * num2;
            Console.WriteLine("Addition result is {0}", sum);
            Console.WriteLine("Product result is {0}", product);
            Console.ReadLine();
        }
    }
}
