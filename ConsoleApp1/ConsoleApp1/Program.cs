using System;
using System.Collections;

namespace ConsoleApp1
{
    class Vector : IEnumerable
    {
        private double[] Data;
        public int Length { get => Data.Length; }
        public Vector(params double[] Values) => Data = Values;
        public Vector(int Size) => Data = new double[Size];
        public double this[int Index]
        {
            get => Data[Index];
            set => Data[Index] = value;
        }
        public void Print()
        {
            foreach (var i in Data)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var i in Data)
                yield return i;
        }
        public void Add(int Value)
        {
            Array.Resize(ref Data, Length + 1);
            Data[Length - 1] = Value;
        }
        private static Vector Mul(double value, Vector Self)
        {
            var Temp = new Vector(Self.Length);
            for (int i = 0; i < Self.Length; i++)
                Temp[i] = Self[i] * value;
            return Temp;
        }
        private static Vector Sum(double value, Vector Self)
        {
            var Temp = new Vector(Self.Length);
            for (int i = 0; i < Self.Length; i++)
                Temp[i] = Self[i] + value;
            return Temp;
        }
        public static Vector operator*(Vector Self, double Value) => Mul(Value, Self);
        public static Vector operator *(double Value, Vector Self) => Mul(Value, Self);
        public static Vector operator +(Vector Self, double Value) => Sum(Value, Self);
        public static Vector operator +(double Value, Vector Self) => Sum(Value, Self);
    }
    class Program
    {
        static void Main(string[] args)
        {
            double Value = 8;
            var A = new Vector { 0, 5, 8, 3, 5 };
            A.Print();
            A += Value;
            A.Print();
            Console.ReadKey();
        }
    }
}
