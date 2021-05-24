using System;

namespace Permutations
{
    class OutputPanel
    {
        // Возвращает true, если value_0 меньше value_1, иначе — false
        private bool Less<T>(T value_0, T value_1) where T : IComparable<T> 
        { 
            return value_0.CompareTo(value_1) < 0;
        }

        // Возвращает true, если value_1, иначе - false
        private bool Greater<T>(T value_0, T value_1) where T : IComparable<T> 
        { 
            return value_0.CompareTo(value_1) > 0;
        }       

        // Инициализация последовательности 
        private void InitArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
                array[i] = i+1;
        }

        // Вывод содержимого последовательности
        private void OutputSequece<T>(T[] sequence)
        {
            Console.Write("[");
            if(!(sequence == null) && (sequence.Length > 0))
            {
                Console.Write(sequence[0]);
                for(int i = 1; i < sequence.Length; i++)
                {
                    Console.Write(", ");
                    Console.Write(sequence[i]);
                }
            }
            Console.WriteLine("]");
        }
    
        // Основная программа
        public void Start()
        {
            int count = int.Parse(Console.ReadLine());
            var sequence = new int[count];

            InitArray(sequence);
            
            Console.WriteLine("Неубывающая последовательность и её перестановки: ");
            do
            {
                OutputSequece(sequence);
            } while (NarayanaAdvanced.NextPermutation(sequence, Less));

            Console.WriteLine("Невозрастающая последовательность и её перестановки: ");
            do
            {
                OutputSequece(sequence);
            } while (NarayanaAdvanced.NextPermutation(sequence, Greater));

        }
    }
}