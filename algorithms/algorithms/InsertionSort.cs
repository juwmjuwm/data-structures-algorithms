using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    class InsertionSort : ISortingAlgorithm
    {

        public void Sort(int[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i-1; j >= 0; j--)
                {
                    if (data[j] > data[j+1])
                    {
                        this.Swap(data, j, j + 1);
                    } else
                    {
                        break;
                    }
                }
            }
        }

        private void Swap(int[] array, int idx1, int idx2)
        {
            int temp = array[idx1];
            array[idx1] = array[idx2];
            array[idx2] = temp;
        }
    }
}
