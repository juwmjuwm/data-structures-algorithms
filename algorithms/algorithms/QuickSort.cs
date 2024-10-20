using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms.algorithms
{
    internal class QuickSort : ISortingAlgorithm
    {
        public void Sort(int[] data)
        {
            QS(data, 0, data.Length-1);
        }

        private static void QS(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Pivot(arr, left, right);
                QS(arr, left, pivotIndex - 1);
                QS(arr, pivotIndex + 1, right);
            }
        }

        private static int Pivot(int[] arr, int pivotIndex, int endIndex)
        {
            int swapIndex = pivotIndex;
            for (int i = pivotIndex+1; i <= endIndex; i++)
            {
                if (arr[i] < arr[pivotIndex])
                {
                    swapIndex++;
                    Swap(arr, swapIndex, i);
                }
            }
            Swap(arr, pivotIndex, swapIndex);
            return swapIndex;
        }

        //private static void QS(int[] arr, int low, int high)
        //{
        //    if (low < high)
        //    {
        //        int pivotIndex = Partition(arr, low, high-1);
        //        QS(arr, low, pivotIndex - 1);
        //        QS(arr, pivotIndex + 1, high);
        //    }
        //}

        //private static int Partition(int[] arr, int low, int high)
        //{
        //    int pivot = arr[high];
        //    int i = low - 1;

        //    for (int j = low; j < high; j++)
        //    {
        //        if (arr[j] <= pivot)
        //        {
        //            i++;
        //            Swap(arr, i, j);
        //        }
        //    }

        //    Swap(arr, i + 1, high);
        //    return i + 1;
        //}

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
