using System;

namespace TestSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PersonFactory Factory = new PersonFactory();
            Person Abhi = Factory.Createperson();

            Factory.SavePerson(Abhi);

        }
    }
}
