using System;

namespace _01_Fibonacci
{
    class Program
    {
        static void IterativeFib(int n)
        {
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                a += b;
                b = a - b;
            }
            Console.WriteLine(a);
        }
        
        static int RecursiveFib(int n)
        {
            if (n <= 1)
                return n;
            return RecursiveFib(n - 1) + RecursiveFib(n - 2);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            // Итеративная версия
            IterativeFib(n);

            // Рекурсивная версия
            Console.WriteLine(RecursiveFib(n));
            
        }
    }
}
