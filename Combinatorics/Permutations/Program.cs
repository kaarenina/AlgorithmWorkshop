using System;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Permutations *****");
            
            var simplePermutation = new NarayanaSimple();
            while(simplePermutation.NextPermutation());

            var advancedPermutation = new OutputPanel();
            advancedPermutation.Start();
        }
    }
}
