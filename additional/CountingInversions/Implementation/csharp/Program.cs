using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    class Program
    {
        public static List<int> MergeSort(List<int> arr, int n, ref int splitInv)
        {
            if (n <= 1)
                return arr;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = n / 2;
            for(int i = 0; i < middle; i++)
            {
                left.Add(arr[i]);
            }
            for (int i = middle; i < n; i++)
            {
                right.Add(arr[i]);
            }

            left = MergeSort(left, left.Count, ref splitInv);
            right = MergeSort(right, right.Count, ref splitInv);
            return Merge(left, right, ref splitInv);
        }

        private static List<int> Merge(List<int> left, List<int> right, ref int splitInv)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                        splitInv += left.Count;
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            List<int> array = new List<int>{1, 20, 6, 4, 5};
            int splitInv = 0;
            var arr = MergeSort(array, array.Count, ref splitInv);
            Console.WriteLine("Number of inversions are " + splitInv );
            
            Console.WriteLine("Sorted massive: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }
    }
}
