using System;
namespace Lab_7
{
	public class Dynamic_Method_Overriding_Program
	{
        class Parent
        {
            public void print()
            {
                Console.WriteLine("This is a parent Class.");
            }
        }
        class Child : Parent
        {
            public new void print()
            {
                Console.WriteLine("This is child class.");
            }
        }
        static void Main(string[] args)
        {
            Child c = new Child();
            c.print();
            Console.ReadLine();
        }
        

    }
}

