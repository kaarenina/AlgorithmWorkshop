using System.Collections.Generic;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static List<int> Sort(List<int> array)
        {
            bool itemMoved;
            do{
                itemMoved = false;
                for (int i = 0; i < array.Count - 1; i++)
                {
                    if(array[i] > array[i+1])
                    {
                        var lowerValue = array[i+1];
                        array[i+1] = array[i];
                        array[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while(itemMoved);

            return array;
        }
    }
}