using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static List<int> Sort(List<int> array)
        {
            if (array.Count <= 1)
                return array;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = array.Count / 2;
            for (int i = 0; i < middle;i++)  //Dividing the array list
            {
                left.Add(array[i]);
            }
            for (int i = middle; i < array.Count; i++)
            {
                right.Add(array[i]);
            }

            left = Sort(left);
            right = Sort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while(left.Count > 0 || right.Count>0)
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
                    }
                }
                else if(left.Count>0)
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
    }
}