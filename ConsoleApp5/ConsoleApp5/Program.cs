using System;
using System.Collections;

namespace ConsoleApp5
{
    class ClassBook : IComparable<ClassBook>
    {
        private double _mark;
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value.Length <= 15 ? value : value.Substring(0, 15);
        }
        public double Mark
        {
            get => _mark;
            set => _mark = value >= 0 && value <= 5 ? value : 0; 
        }
        public ClassBook(string Name, double Mark)
        {
            this.Mark = Mark;
            this.Name = Name;
        }
        public void Show() => Console.WriteLine($"{Name} {Mark}");
        public int CompareTo(ClassBook Other) => Mark.CompareTo(Other.Mark);
    }
    class Program
    {
        static void Main(string[] args)
        {
            var A = new ClassBook("История", 3);
            var B = new ClassBook("Математика", 4.2);
            var C = new ClassBook("Литература", 2.3);
            ClassBook[] Arr = { A, B, C };
            int[] T = { 9, 4, 2, 4, 1, 0, 7, 3 };
            //Array.Sort(Arr, (ClassBook a, ClassBook b) => (new CaseInsensitiveComparer()).Compare(b.Mark, a.Mark));
            //Array.Sort(Arr, (ClassBook a, ClassBook b) => new CaseInsensitiveComparer().Compare(b.Mark, a.Mark));
            Array.Sort(Arr, (ClassBook a, ClassBook b) => Comparer.Default.Compare(b.Mark, a.Mark));
            foreach (var i in Arr)
                i.Show();
            Console.ReadKey();
        }
    }
}
