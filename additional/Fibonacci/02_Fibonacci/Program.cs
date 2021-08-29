using System;

namespace _02_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // put your c# code here
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                a = a % 10 + b % 10;
                b = a - b;
            }
            Console.WriteLine(a % 10);
        }
    }
}
