using System;
using System.Collections;

namespace ConsoleApp6
{
    class CourseBook : IEnumerable
    {
        private string _courseName; //Название курса длиной не более 20 символов
        private Student[] Students;
        public CourseBook(string CourseName) => (Students, this.CourseName) = (new Student[0], CourseName);
        public double MediumBall
        {
            get
            {
                double Sum = 0;
                foreach (var i in Students)
                    Sum += i.Ball;
                return Sum / Students.Length;
            }
        }
        public string CourseName
        {
            get => _courseName;
            set => _courseName = value.Length <= 20 ? value : value.Substring(0, 20);
        }
        public Student this[int Index]
        {
            get => Students[Index];
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var i in Students)
                yield return i;
        }
        public void Add(Student Value)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = Value;
        }
        public void Add(string FirstName, string LastName, SelfDate BornDate, int Ball)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = new Student(FirstName, LastName, BornDate, Ball);
        }
        /// <summary>
        /// Reverse: false - сортировать по возрастатию, true - по убыванию 
        /// </summary>
        /// <param name="Reverse"></param>
        public void Sort(bool Reverse = false)
        {
            if (Reverse)
                Array.Sort(Students, (Student a, Student b) => Comparer.Default.Compare(b.Ball, a.Ball));
            else
                Array.Sort(Students);
        }
        public void Show()
        {
            Console.WriteLine($"Название: {CourseName}\nСредний балл учащихся: {MediumBall}");
            foreach (var i in Students)
                i.Show();
        }
    }
}
