﻿using System;
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
        public static List<double[]> ArrayStates { get; set; }
        public static int SwapsCount { get; protected set; }
        public static long MaxRecursionDepth { get; protected set; }
        public static SortingVariant ChosenVariant;
        private SortingMethod _chosenSortingMethod;
        public static SortingMethod ChosenSortingMethod { get; set; }
        

        public Sorting()
        {
            ArrayStates = new List<double[]>();
            SwapsCount = 0;
            MaxRecursionDepth = 0;
        }

        public static void SaveArrayState()
        {
            if (_array.Length == 100)
            {
                double[] stateCopy = new double[Array.Length];
                Array.CopyTo(stateCopy, 0);
                ArrayStates.Add(stateCopy);
            }
        }
        
        public static List<double[]> FilterConsecutiveStates(List<double[]> states)
        {
            List<double[]> filteredStates = new List<double[]>();

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
        public void FillArray(int length, SortingVariant variant, double minValue, double maxValue)
        {
            Array = new double[length];
            double step = (maxValue - minValue)/(length - 1);
            switch (variant)
            {
                case SortingVariant.Random:
                    Random random = new Random();
                    for (int i = 0; i < length; i++)
                    {
                        double randomNumber = minValue + (random.NextDouble() * (maxValue - minValue));
                        Array[i] = randomNumber;
                    }
                    break;
                case SortingVariant.Order:
                    for (int i = 0; i < length; i++)
                    {
                        Array[i] = minValue + i * step;
                    }
                    break;
                case SortingVariant.Invert:
                    
                    for (int i = 0; i < length; i++)
                    {
                        Array[i] = maxValue - i  * step;
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