using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    internal class MergeSort : ISortingAlgorithm
    {

        void Sort(int[] data)
        {

        }

        private void Split(int[] data, int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                Split(data, start, mid);
                Split(data, mid+1, end);
                Merge(data, start, end);
            }
        }

        private void Merge(int[] data, int start, int end)
        {

        }
    }
}
