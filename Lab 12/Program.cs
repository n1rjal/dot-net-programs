using System;

namespace StructsandEnum
{
    struct Person
    {
        public int Id;
        public string Name;
    }
    enum Gender
    {
        Male,
        Female,
        Other
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Gender gender = Gender.Male;
            person.Id = 7;
            person.Name = "Nirjal";
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Id);
            Console.WriteLine(gender);
            Console.ReadLine();
        }
    }
}