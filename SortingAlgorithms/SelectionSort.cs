using System.Collections.Generic;

namespace SortingAlgorithms
{
    public static class SelectionSort
    {
        public static List<int> Sort(List<int> array)
        {
            for (var i = 0; i < array.Count; i++)
            {
                var min = i;
                for(var j = i + 1; j < array.Count; j++) { 
                    if(array[min] > array[j])
                    {
                        min = j;
                    }
                }

                if(min != i)
                {
                    var lowerValue = array[min];
                    array[min] = array[i];
                    array[i] = lowerValue;
                }
            }
            return array;
        }
    }
}