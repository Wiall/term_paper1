using System;

namespace term_paper_1
{
    public class HeapSorting : Sorting
    {
        int Left(int i)
        {
            return 2 * i;
        }
        
        int Right(int i)
        {
            return 2 * i + 1;
        }
        
        void MaxHeapify(int i, int heapsize)
        {
            int l = Left(i);
            int r = Right(i);
            int largest = i;

            if (l <= heapsize)
            {
                if (Array[l] > Array[i])
                {
                    largest = l;
                }
            }
        
            if (r <= heapsize)
            {
                if (Array[r] > Array[largest])
                {
                    largest = r;
                }
            }
        
            if (largest != i)
            {
                (Array[i], Array[largest]) = (Array[largest], Array[i]);
                SwapsCount++;
                SaveArrayState();
                MaxHeapify(largest, heapsize);
            }
        }
        
        void BuildMaxHeap()
        {
            int heapsize = Array.Length - 1;
            for (int i = (Array.Length / 2) - 1; i >= 0; i--)
            {
                MaxHeapify(i, heapsize);
            }
        }
        
        public void HeapSort()
        {
            BuildMaxHeap();
            int heapsize = Array.Length - 1;
            for (int i = Array.Length - 1; i >= 1; i--)
            {
                (Array[0], Array[i]) = (Array[i], Array[0]);
                SwapsCount++;
                heapsize--;
                MaxHeapify(0, heapsize);
            }
        }
    }
}
