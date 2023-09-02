using System;
using System.Threading;
namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();
        }

        

        public static void Task1()
        {
            Console.WriteLine("Task1 starting");
            Thread.Sleep(4000);
            Console.WriteLine("Task1 completd");
        }
        public static void Task2()
        {
            Console.WriteLine("Task2 starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task2 completd");
        }
        public static void Task3()
        {
            Console.WriteLine("Task3 starting");
            Thread.Sleep(5000);
            Console.WriteLine("Task3 completd");
        }
        public static void Task4()
        {
            Console.WriteLine("Task4 starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task4 completd");
        }
    }
}
