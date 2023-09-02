using System;
namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            Console.WriteLine("To find a divided by b");
            Console.WriteLine("a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            b = int.Parse(Console.ReadLine());
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Cannot divide by 0");
                }
                else
                {
                    float c = a / b;
                    Console.WriteLine("c = " + c);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}