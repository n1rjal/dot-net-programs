using System;
namespace Lab_7
{
	public class DynamicOverriding_Program
	{
        internal class Program
        {
            class Parent
            {
                public virtual void print()
                {
                    Console.WriteLine("This is parent class");
                }
            }
            class Child : Parent
            {
                public override void print()
                {
                    base.print();
                    {
                        Console.WriteLine("This is a child class");
                    }
                }
            }
            static void Main(string[] args)
            {
                Parent p = new Child();
                p.print();
                Console.WriteLine("CopyRight: Nirjal Paudel");
                Console.ReadLine();
            }
        }
    }
}

