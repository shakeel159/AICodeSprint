using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SortingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            string FilePath = @"C:\Workspace\src\GitHub\AICodePractice\AICodeSprint\Data.txt";
            int[] numbers = { 32, 2, 29, 1, 8, 14 };

            BubbleSort(numbers);
            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine("========================");
            InsertionSort(numbers);
            Console.WriteLine((string.Join(",", numbers)));
            Console.WriteLine("========================");
            SelectionSort(numbers);
            Console.WriteLine((string.Join(",", numbers)));
            Console.WriteLine("========================");
            HeapSort(numbers, numbers.Length);
            Console.WriteLine((string.Join(",", numbers)));
            Console.WriteLine("========================");
            QuickSort(numbers,0,numbers.Length);
            Console.WriteLine((string.Join(",", numbers)));
            Console.WriteLine("========================");
            Console.ReadLine();
        }

        public static void BubbleSort(int[] line)
        {
            //string[] numbers = new string[line.Length];
            for (int i = 0; i < line.Length - 1; i++)
            {
                for (int j = 0; j < line.Length - (i + 1); j++)
                {
                    if (line[j] > line[j + 1])
                    {
                        int temp;
                        temp = line[j + 1];
                        line[j + 1] = line[j];
                        line[j] = temp;
                    }
                }

            }
        }

        public static void InsertionSort(int[] values)
        {
            int sawp = 0;
            int i = 1;
            int j = i;

            while (i < values.Length)
            {
                j = i;
                while (j > 0 && values[j - 1] > values[j])
                {
                    sawp = values[j];
                    values[j] = values[j - 1];
                    values[j - 1] = sawp;
                    j--;
                }
                i++;
            }
        }

        public static void SelectionSort(int[] values)
        {
            int min = 0;
            int mininum = 0;
            for (int i = 0; i < values.Length - 1; i++)
            {
                min = i;
                //find the item that belongs in position i
                for (int j = i + 1; j <= i; j++)
                {
                    if (values[j] > values[i])
                    {
                        min = values[j];
                    }

                    min = values[i];
                    values[i] = values[j];
                    values[j] = mininum;
                }
            }
        }
        //https://www.tutorialspoint.com/heap-sort-in-chash
        public static void heapify(int[] values, int n, int i)
        {
            int largest = i;
            int ChildOne = 2 * i + 1;
            int ChildTwo = 2 * i + 2;
            if (ChildOne < n && values[ChildOne] > values[largest])
                largest = ChildOne;
            if (ChildTwo < n && values[ChildTwo] > values[largest])
                largest = ChildTwo;
            if (largest != i)
            {
                int swap = values[i];
                values[i] = values[largest];
                values[largest] = swap;
                heapify(values, n, largest);
            }
        }
        public static void HeapSort(int[] values, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(values, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = values[0];
                values[0] = values[i];
                values[i] = temp;
                heapify(values, i, 0);
            }
        }

        public static void QuickSort(int[] arry, int start, int end)
        {
            if(start < end)
            {
                int pivoitLoc = Partition(arry, start, end);
                QuickSort(arry, start, pivoitLoc);
                QuickSort(arry, pivoitLoc + 1, end);
            }
        }
        public static int Partition(int[] arry, int start, int end)
        {
            int pivot = arry[start];
            int leftSide = start;

            for (int i = start+1; i < end; i++)
            {
                if (arry[i] < pivot)
                {
                    arry[i] = arry[leftSide];
                    arry[leftSide] = leftSide+1;
                }
                int temp = pivot;
                pivot = arry[leftSide];
            }
            return leftSide;
        }
    }
}