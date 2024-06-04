using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace term_paper_1
{
    public class Sorting
    {
        private static double[] _array;
        public static double[] Array
        {
            get => _array;
            set
            {
                _array = value;
                SaveArrayState();
            }
        }

        private static double[] _arrCopy;
        public static List<int[]> ArrayStates { get; set; }
        public static int SwapsCount { get; protected set; }
        public static long MaxRecursionDepth { get; protected set; }
        public static SortingVariant ChosenVariant;
        private SortingMethod _chosenSortingMethod;
        public static SortingMethod ChosenSortingMethod { get; set; }
        

        public Sorting()
        {
            ArrayStates = new List<int[]>();
            SwapsCount = 0;
            MaxRecursionDepth = 0;
        }

        public static void SaveArrayState()
        {
            if (_array.Length == 100)
            {
                int[] stateCopy = new int[Array.Length];
                Array.CopyTo(stateCopy, 0);
                ArrayStates.Add(stateCopy);
            }
        }
        
        public static List<int[]> FilterConsecutiveStates(List<int[]> states)
        {
            List<int[]> filteredStates = new List<int[]>();

            if (states.Count == 0)
                return filteredStates;

            filteredStates.Add(states[0]);

            for (int i = 1; i < states.Count; i++)
            {
                bool isDifferent = !Enumerable.SequenceEqual(states[i], states[i - 1]);

                if (isDifferent)
                {
                    filteredStates.Add(states[i]);
                }
            }

            return filteredStates;
        }
        protected void Swap(ref double a, ref double b)
        {
            (a, b) = (b, a);
            SaveArrayState();
        }

        public void SetSortingMethod(SortingMethod method) => _chosenSortingMethod = method;
        public void FillArray(int length, SortingVariant variant, int minValue, int maxValue)
        {
            Array = new double[length];

            switch (variant)
            {
                case SortingVariant.Random:
                    Random random = new Random();
                    HashSet<int> uniqueNumbers = new HashSet<int>();
                    for (int i = 0; i < length; i++)
                    {
                        int randomNumber;
                        do
                        {
                            randomNumber = random.Next(minValue, maxValue + 1);
                        } while (!uniqueNumbers.Add(randomNumber));
                
                        Array[i] = randomNumber;
                    }
                    break;
                case SortingVariant.Order:
                    for (int i = 0; i < length; i++)
                    {
                        Array[i] = minValue + i;
                    }
                    break;
                case SortingVariant.Invert:
                    for (int i = 0; i < length; i++)
                    {
                        Array[i] = maxValue - i;
                    }
                    break;
                default:
                    throw new ArgumentException("Невідомий варіант заповнення");
            }

            _arrCopy = new double[Array.Length];
            System.Array.Copy(Array, _arrCopy, Array.Length);

        }
        
        public void SaveResults()
        {
            string fileName = "save_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
            long practicalComplexity;

            switch (_chosenSortingMethod)
            {
                case SortingMethod.QuickSortOnePivot:
                case SortingMethod.QuickSortMedianPivot:
                    practicalComplexity = MaxRecursionDepth * Array.Length;
                    break;
                default:
                    practicalComplexity = SwapsCount;
                    break;
            }

            Console.WriteLine(practicalComplexity);
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine($"Sorting: {_chosenSortingMethod}\nVariant: {ChosenVariant}\nPractical complexity: {practicalComplexity}");
                sw.WriteLine("Array before sorting:");
                WriteArrayToFile(sw, _arrCopy);
                sw.WriteLine("\nArray after sorting:");
                WriteArrayToFile(sw, Array);
            }
            
        }
        private void WriteArrayToFile(StreamWriter sw, double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sw.Write(array[i]);
                if (i < array.Length - 1)
                    sw.Write(", ");
                if ((i + 1) % 15 == 0)
                    sw.WriteLine();
            }
        }
        
        public enum SortingMethod
        {
            QuickSortOnePivot,
            QuickSortMedianPivot,
            HeapSort,
            SmoothSort
        }

        public enum SortingVariant
        {
            Random,
            Order,
            Invert
        }
    }
}