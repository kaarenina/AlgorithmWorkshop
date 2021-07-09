using System;

namespace Permutations
{
    public class NarayanaSimple
    {
        private int[] array = {1,2,3,4,5};
        private int n;

        public NarayanaSimple()
        {
            n = array.Length;
        }

        public bool NextPermutation()
        {
            for (int i = n-2; i >= 0; i--)
            {
                //Первый этап
                if(array[i+1] > array[i])
                {
                    int minValue = array[i+1], minIndex = i+1;
                    // Второй этап
                    for(int j = i+2; j<n; j++)
                    {
                        if(array[j] > array[i] && array[j] < minValue)
                        {
                            minValue = array[j];
                            minIndex = j;
                        }
                    }
                    //Третий этап
                    Swap(ref array, i, minIndex);
                    // Четвертый этап
                    Array.Sort(array, i+1, n-i-1);
                    DisplayPermutation();

                    return true;
                }
            }
            return false;
        }

        private void Swap(ref int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        private void DisplayPermutation()
        {
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}