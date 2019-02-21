using System;

namespace ConsoleApp6
{
    class SelfDate
    {
        private int _day;
        private int _month;
        private int _year;
        public SelfDate(int Day, int Month, int Year) => (this.Day, this.Month, this.Year) = (Day, Month, Year);
        public SelfDate(string SomeTextDate) //Конструктор принимающий дату в формате строки с разделителями, например День/Месяц/Год
        {
            var Str = SomeTextDate.Split('.', '/', '-');
            (Day, Month, Year) = (int.Parse(Str[0]), int.Parse(Str[1]), int.Parse(Str[2]));
        }
        public int Day
        {
            get => _day;
            set => _day = Validate(value, 1, 31);
        }
        public int Month
        {
            get => _month;
            set => _month = Validate(value, 1, 12);
        }
        public int Year
        {
            get => _year;
            set => _year = Validate(value, 0, 2100);
        }
        private int Validate(int Value, int MinValue, int MaxValue) => Value >= MinValue && Value <= MaxValue ? Value : MinValue; //Проверяет соответствие значения диапозону
        public void Show() => Console.WriteLine($"{Day, 2:d2}.{Month, 2:d2}.{Year, 2:d2}");
        public override string ToString() => $"{Day}.{Month}.{Year}";
    }
    class Person
    {
        private string _firstNane; //Имя
        private string _lastName; //Фамилия
        public SelfDate BornDate { get; set; }
        public Person(string FirstName, string LastName, SelfDate BornDate) => (this.FirstName, this.LastName, this.BornDate) = (FirstName, LastName, BornDate);
        public string FirstName
        {
            get => _firstNane;
            set => _firstNane = value.Length <= 15 ? value : value.Substring(0, 15);
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value.Length <= 15 ? value : value.Substring(0, 15);
        }
        public virtual void Show() => Console.WriteLine($"Имя: {FirstName} Фамилия: {LastName} Дата рождения: {BornDate.ToString()}");
    }
    class Student : Person, IComparable<Student>
    {
        private int _ball; //Балл в диапозоне 0-100
        public int Ball
        {
            get => _ball;
            set => _ball = value >= 0 && value <= 100 ? value : 0;
        }
        public Student(string FirstName, string LastName, SelfDate BornDate, int Ball) : base(FirstName, LastName, BornDate) => this.Ball = Ball;
        public int CompareTo(Student Other) => Ball.CompareTo(Other.Ball);
        public override void Show() => Console.WriteLine($"Имя: {FirstName} Фамилия: {LastName} Дата рождения: {BornDate} Балл: {Ball}");
    }
}
