using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgoritms
{
    public class Sorting
    {
        public static void BubbleSort(int[] array)
        {
            //O(N^2)
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            //O(N ^ 2)
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                int largest = 0;

                for (int i = 1; i <= partIndex; i++)
                {
                    if (array[i] > array[largest])
                    {
                        largest = i;
                    }
                }

                Swap(array, partIndex, largest);
            }
        }

        public static void InsertionSort(int[] array)
        {
            //O(N ^ 2)
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int j = partIndex;
                while (j > 0 && array[j - 1] > array[partIndex])
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }
        }

        public static void ShellSort(int[] array)
        {
            //generalized version of insertion sort based on gap
            int gap = 1;
            while (gap < array.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Swap(array, j, j - gap);
                    }
                }

                gap /= 3;
            }
        }

        public static void MergeSort(int[] array)
        {
            int[] aux = new int[array.Length];
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                    return;

                var mid = (low + high) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if (array[mid] <= array[mid + 1])
                    return;

                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, aux, low, high - low - 1);

                for (int k = low; k <= high; k++)
                {
                    if (i > mid) array[k] = aux[j++];
                    else if (j > high) array[k] = aux[i++];
                    else if (aux[j] < aux[i]) array[k] = aux[j++];
                    else array[k] = aux[i++];
                }
            }
        }



        private static void Swap(int[] array, int i, int j)
        {
            if (i == j) return;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
