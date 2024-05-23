namespace term_paper_1
{
    public class QuickSortingOnePivot : Sorting
    {
        private int Partition(int p, int r)
        {
            int pivot = Array[r];
            var i = p - 1;

            for (var j = p; j < r; j++)
            {
                if (Array[j] <= pivot)
                {
                    i += 1;
                    Swap(ref Array[i], ref Array[j]);
                }
            }
            Swap(ref Array[i+1], ref Array[r]);
            
            return i + 1;
        }

        public void QuickSort(int p, int r, int depth = 0)
        {
            if (p < r)
            {
                if (depth > MaxRecursionDepth)
                {
                    MaxRecursionDepth = depth;
                }
                var q = Partition(p, r);
                QuickSort(p, q - 1, depth + 1);
                QuickSort(q + 1, r, depth + 1);
            }
        }
    }
}