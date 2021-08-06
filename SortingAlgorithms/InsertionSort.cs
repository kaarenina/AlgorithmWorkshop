using System.Collections.Generic;

namespace SortingAlgorithms
{
    public static class InsertionSort
    {
        public static List<int> Sort(List<int> array)
        {
        var clonedList = new List<int>(array.Count);

        for (int i = 0; i < array.Count; i++)
        {
            var item = array[i];
            var currentIndex = i;

            while (currentIndex > 0 && clonedList[currentIndex - 1] > item)
            {
                currentIndex--;
            }

            clonedList.Insert(currentIndex, item);
        }

        return clonedList;        
        }
    }
}