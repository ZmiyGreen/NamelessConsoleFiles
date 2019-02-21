using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp6
{
    static class Input
    {
        public static Person ConsoleRead()
        {
            Console.Write("Введите имя, фамилию и возраст разделяю пробелы: ");
            var Str = Console.ReadLine().Split(' ');
            return new Person(Str[0], Str[1], new SelfDate(Str[2]));
        }
        public static Student ReadStudent()
        {
            Console.WriteLine("Введите данные о студенте разделяя пробелами: ");
            var Str = Console.ReadLine().Split(' ');
            return new Student(Str[0], Str[1], new SelfDate(Str[2]), int.Parse(Str[3]));
        }
        public static CourseBook UserInput(string Name)
        {
            var Students = new CourseBook(Name);
            while (true)
            {
                var Str = Console.ReadLine().Split(' ');
                if (Str[0] != "СТОП") //контрольное значение
                    Students.Add(Str[0], Str[1], new SelfDate(Str[2]), int.Parse(Str[3]));
                else
                    return Students;
            }
        }
    }
    class Cat
    {
        public string Name { get; set; }
        public double Tall { get; set; }
        public double Weigth { get; set; }
        public Cat(string Name, double Tall, double Weigth) => (this.Name, this.Tall, this.Weigth) = (Name, Tall, Weigth);
        public void Show() => Console.WriteLine($"Имя: {Name, 10} Рост: {Tall, 5} Вес {Weigth, 5}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*var Students = new CourseBook("Программирование")
            {
                {"Иван", "Иванов",  new SelfDate("20.10.2001"), 29 },
                {"Алексей", "Алексеев",  new SelfDate("2.3.1994"), 94 },
                {"Александр", "Александров",  new SelfDate("9.10.1990"), 72 },
                {"Игорь", "Жуков",  new SelfDate("20.10.1991"), 38 },
                {"Сергей", "Бабочкин",  new SelfDate("20.10.2008"), 83 }
            };
            Students.Sort(true);
            Students.Show();*/
            /*var S = Input.UserInput("История");
            S.Sort(true);
            S.Show();*/
            /*var A = new List<Cat>
            {
                new Cat("Барсик", 4.5, 8.5),
                new Cat("Мурзик", 2.4, 8.3),
                new Cat("Наст-шлю", 1.4, 15.8)
            };
            Cat[] B = {
                new Cat("Барсик", 4.5, 8.5),
                new Cat("Мурзик", 2.4, 8.3),
                new Cat("Наст-шлю", 1.4, 15.8)
            };
            A.Sort((Cat a, Cat b) => Comparer.Default.Compare(a.Weigth, b.Weigth));
            //Array.Sort(B, (Cat a, Cat b) => Comparer.Default.Compare(b.Weigth, a.Weigth));
            foreach (var i in A)
                i.Show();
            Console.ReadKey();*/
            var D = new SelfDate(1, 10, 2001);
            D.Show();
            Console.ReadKey();
        }
    }
}
