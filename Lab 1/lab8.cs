using System;
namespace lambdaexp
{
    internal class Program
    {
        static void Lambda(string[] args)
        {
            //lambda expression
            Func<int, int> sqr = (int n) => n * n;
            Console.WriteLine("Lambda Expression : The square of 5 is"+sqr(5));
            //lambda statements
            Func<string, string, string> print = (string a, string b) =>
            {
                string c = a + b;
                return c;
            };
            Console.WriteLine("Lambda Statements: " + print("Nirjal","Paudel"));
            Console.ReadLine();
        }
    }
}