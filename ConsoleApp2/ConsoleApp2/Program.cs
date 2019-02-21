using System;
using System.Collections;

namespace ConsoleApp2
{
    class Person : IComparable<Person>
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void Print() => Console.WriteLine($"Имя: {Name} Возраст: {Age}");
        public int CompareTo(Person Other) => Age.CompareTo(Other.Age);
    }
    class Program
    {
        static void Main(string[] args)
        {
            var A = new Person[5];
            A[0] = new Person("Иванов1", 12);
            A[1] = new Person("Иванов2", 42);
            A[2] = new Person("Иванов3", 5);
            A[3] = new Person("Иванов4", 19);
            A[4] = new Person("Иванов5", 32);
            foreach (var i in A)
                i.Print();
            Console.WriteLine();
            Array.Sort(A);
            foreach (var i in A)
                i.Print();
            Console.ReadKey();
        }
    }
}
