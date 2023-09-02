using System;
namespace constructor
{
    public class Myclass
    {
        private int age;

        //default Constructor
        public Myclass()
        {
            age = 2;
        }
        //parameterized Constructor
        public Myclass(int Age)
        {
            age = Age;
        }
        //Copy Constructor
        public Myclass Copy()
        {
            Myclass copy = new Myclass(this.age);
            return copy;
        }
        public void ShowAge()
        {
            Console.WriteLine("Age = " + age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            myclass.ShowAge();

            Myclass myclass2 = new Myclass(9);
            myclass2.ShowAge();
            Myclass myclass3 = myclass2.Copy();
            myclass3.ShowAge();
            Console.ReadLine();
        }
    }
}