using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSortAlgorithmUsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberToSort = new int[20];

            var numbers = GenerateRandomNumbers(numberToSort);


            //print the array before sorting.
            Print(numberToSort);


            //sorted array 
            int[] sortedArray = Sort(numbers, 0);
            Console.WriteLine("");
            Console.WriteLine("Sorted Array\n");
            Print(sortedArray);
            Console.ReadLine();

        }

        private static int[] Sort(int[] numbersToSort, int location)
        {
            int n = location + 1;

            if (location == numbersToSort.Length)
            {
                return numbersToSort;
            }
            while (n < numbersToSort.Length)
            {
                int compareNumber = numbersToSort[n];
                int originalNumber = numbersToSort[location];
                if (compareNumber < originalNumber)
                {
                    numbersToSort[location] = compareNumber;
                    numbersToSort[n] = originalNumber;
                }
                n++;
            }
            location++;
            Sort(numbersToSort, location);
            return numbersToSort;
        }

        private static void Print(int[] numberToSort)
        {
            foreach (var num in numberToSort)
            {
                Console.WriteLine(num);
            }
        }

        private static int[] GenerateRandomNumbers(int[] numToSort)
        {
            int min = 0;
            int max = 10000000;

            var randNumber = new Random();

            for (int i = 0; i < numToSort.Length; i++)
            {
                numToSort[i] = randNumber.Next(min, max);
            }

            return numToSort;
        }
    }
}
