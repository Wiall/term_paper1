using System;

namespace term_paper_1
{
    public class QuickSortingMedianPivot : Sorting
    {
        private int MedianOfThree(int p, int r)
        {
            var mid = Convert.ToInt32((p+r) / 2);
            if(Array[p] > Array[mid])
                Swap(ref Array[p], ref Array[mid]);
            if(Array[mid] > Array[r])
                Swap(ref Array[mid], ref Array[r]);
            if(Array[p] > Array[mid])
                Swap(ref Array[p], ref Array[mid]);
            return mid;
        }

        private int PartitionMedian(int p, int r)
        {
            int q = MedianOfThree(p, r);
            Swap(ref Array[q], ref Array[r]);
            var pivot = Array[r];
            var i = p - 1;
            for (int j = p; j < r; j++)
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

        public void QuickSort(int p, int r)
        {
            QuickSortHelper(p, r, 0);
        }

        private void QuickSortHelper(int p, int r, int depth)
        {
            if (p < r)
            {
                if (depth > MaxRecursionDepth)
                {
                    MaxRecursionDepth = depth;
                }

                if (r - p > 2)
                {
                    var q = PartitionMedian(p, r);
                    QuickSortHelper(p, q - 1, depth + 1);
                    QuickSortHelper(q + 1, r, depth + 1);
                }
                else
                {
                    for (int i = p; i < r; ++i)
                    {
                        for (int j = i + 1; j < r + 1; ++j)
                        {
                            if (Array[i] > Array[j])
                            {
                                Swap(ref Array[i], ref Array[j]);
                                SwapsCount++;
                            }
                        }
                    }
                }
            }
        }
    }
}