using System;
namespace lab7
{
    internal class Program
    {
        public void Add()
        {
            int a = 2;
            int b = 3;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }
        public void Add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();
            p.Add(2, 5);
            p.Add("Nirjal", "Paudel");
            p.Add(23.5f, 98.10f);
            Console.ReadLine();
        }
    }
}
