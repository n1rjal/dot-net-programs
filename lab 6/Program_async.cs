using System;
using System.Threading;
using System.Threading.Tasks;
namespace lab6
{
    internal class Program
    {
        static void AsyncMain(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();
        }
        public static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task1 starting...");
                Thread.Sleep(4000);
                Console.WriteLine("Task1 Completed");
            });
        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task2 starting...");
                Thread.Sleep(3000);
                Console.WriteLine("Task2 Completed");
            });
        }
        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task3 starting...");
                Thread.Sleep(5000);
                Console.WriteLine("Task3 Completed");
            });
            Console.WriteLine("Hello world");
        }
        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task4 starting...");
                Thread.Sleep(1000);
                Console.WriteLine("Task4 Completed");
            });
        }
    }
}
