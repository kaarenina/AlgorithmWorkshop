using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Sorting Algorithms *****");
            List<int> array = new List<int>() {59, 10, 56, 26, 11, 87, 24, 88, 75, 37}; 
            DisplayArray(array, "default");
            
            // Bubble sort
            DisplayArray(BubbleSort.Sort(new List<int>(array)), "Bubble Sort");

            // Insertion Sort
            DisplayArray(InsertionSort.Sort(array), "Insertion Sort");

            // Selection Sort
            DisplayArray(SelectionSort.Sort(new List<int>(array)), "Selection Sort");

            // Merge Sort
            DisplayArray(MergeSort.Sort(new List<int>(array)), "Merge Sort");
        }

        static void DisplayArray(List<int> array, string name)
        {
            System.Console.WriteLine("----->" + name);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
