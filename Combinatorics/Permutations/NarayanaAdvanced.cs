namespace Permutations
{
    class NarayanaAdvanced
    {
        public delegate bool Predicate2<T>(T value_0, T value_1);
        public static bool NextPermutation<T>(T[] sequence, Predicate2<T> compare)
        {
            // Этап 1
            var i = sequence.Length;
            do
            {
                if(i<2)
                    return false;
                i--;
            } while (!compare(sequence[i-1], sequence[i]));

            // Этап 2
            var j = sequence.Length;
            while(i < j && !compare(sequence[i-1], sequence[--j]));
            _SwapItems(sequence, i-1, j);

            // Этап 3
            j = sequence.Length;
            while(i < --j)  
                _SwapItems(sequence, i++, j);
            return true;
        }

	    private static void _SwapItems<T>(T[] sequence, int index_0, int index_1)
	    {
		    var item = sequence[index_0];
		    sequence[index_0] = sequence[index_1];
		    sequence[index_1] = item;
	    }
    }
}