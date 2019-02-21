using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void M(int x)
        {
            double Sum = 0;
            for (int i = 1; i <= x; i++)
                Sum += i * Math.Pow(0.33, i);
            Console.WriteLine(Sum);
        }
        static void Main(string[] args)
        {
            M(7);
            Console.ReadKey();
        }
    }
}
