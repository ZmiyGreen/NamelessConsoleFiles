using System;

namespace ConsoleApp7
{
    static class SelfMath
    {
       /// <summary>
       /// Возвращает факториал числа
       /// </summary>
       /// <param name="n">Число, для которого вычисляется  факториал</param>
        public static long Factorial(int n) => (n == 1 || n == 0) ? 1 : n * Factorial(n - 1);
        /// <summary>
        /// Вычислить количество возможных сочетаний
        /// </summary>
        /// <param name="n">Из скольких выбираем</param>
        /// <param name="m">Сколько выбираем</param>
        public static long C(int n, int m) => Factorial(n) / (Factorial(n - m) * Factorial(m));
        /// <summary>
        /// Вычислить количество возможных сочетаний
        /// </summary>
        /// <param name="n">Из скольких выбираем</param>
        /// <param name="m">Сколько выбираем</param>
        public static long OtherC(in int n, in int m) => A(n, m) / Factorial(m);
        /*{
            int current = (n - m) + 1;
            long sum = current;
            while (++current <= n)
                sum *= current;
            return sum / Factorial(m);
        }*/
        public static long A(in int n, in int m)
        {
            int current = (n - m) + 1;
            long sum = current;
            while (++current <= n)
                sum *= current;
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"5! = {SelfMath.Factorial(5)}");
            Console.WriteLine($"4.7 {SelfMath.C(10, 3)}");
            Console.WriteLine($"4.7 {SelfMath.OtherC(100, 3  )}");
            //Console.WriteLine(SelfMath.A(10, 4));
            //Console.WriteLine(SelfMath.Factorial(5));
            Console.ReadKey();
        }
    }
}
