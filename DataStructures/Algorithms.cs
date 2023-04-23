using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class Algorithms
    {
        #region Binary Search
        /// <summary>
        /// Does a binary search to find the argument in the provided array
        /// </summary>
        /// <param name="numberToFind">the number to find</param>
        /// <param name="array">the array to search</param>
        public static void BinarySearch(int numberToFind, int[] array)
        {
            int min = 0;
            int max = array.Length - 1;
            int midPoint = (array.Length - 1) / 2;

            while (array[midPoint] != numberToFind)
            {
                if (array[midPoint] < numberToFind)
                {
                    min = midPoint + 1;
                }
                if (array[midPoint] > numberToFind)
                {
                    max = midPoint - 1;
                }
                midPoint = (max + min) / 2;
            }
            Console.WriteLine("Number found at location: " + midPoint);
        }
        #endregion

        #region Bubble Sort
        /// <summary>
        /// performs a bubble sort to sort the array from lowest to highest
        /// </summary>
        /// <param name="array">the array to sort</param>
        public static void BubbleSort(int[] array)
        {
            bool switchHappened = false;
            int temp = 0;
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        switchHappened= true;
                    }
                }
                if (switchHappened == false)
                {
                    break;
                }
                else
                {
                    switchHappened = false;
                }
            }
        }
        #endregion
    }
}
