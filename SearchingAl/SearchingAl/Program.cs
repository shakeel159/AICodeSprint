using SortingAlgorithms;
using System;

namespace SearchingAl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = Path.GetFullPath(@"C:\Workspace\src\GitHub\AICodePractice\AICodeSprint\Data.txt");
            string[] FilePath = File.ReadAllLines(textFilePath);
            int[] scores = Array.ConvertAll(FilePath, int.Parse);

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(0, scores.Length - 1);

            Linear(numbers, randomNumber);

            SortingAlgorithms.Program.SelectionSort(numbers);
            Binary(numbers, randomNumber);

            Interpolation(numbers, randomNumber);

            Console.ReadLine();
        }
        public static void Linear(int[] arr, int value)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

        }

        public static int Binary(int[] arr, int targetValue)
        {
            int leftSide = 0;
            int rightSide = arr.Length - 1;


            while (leftSide <= rightSide)
            {
                int m = (leftSide + rightSide) / 2;
                if (arr[m] < targetValue)
                {
                    leftSide = m + 1;
                }
                else if (arr[m] > targetValue)
                {
                    rightSide = m - 1;
                }
                else
                {
                    return m;
                }

            }
            return -1;
        }
        public static int Interpolation(int[] arr, int value)
        {
            int leftSide = 0;
            int rightSide = arr.Length - 1;
            int target;

            while (leftSide <= rightSide && value >= arr[leftSide] && value <= arr[rightSide])
            {
                target = leftSide + (((rightSide - leftSide) / (arr[rightSide] - arr[leftSide])) * (value - arr[leftSide]));
                if (arr[target] == value)
                {
                    return target;
                }

                if (arr[target] < value)
                {
                    leftSide = target + 1;
                }

                if (arr[target] > value)
                {
                    rightSide = target - 1;
                }
            }
            return -1;
        }
    }
   

}