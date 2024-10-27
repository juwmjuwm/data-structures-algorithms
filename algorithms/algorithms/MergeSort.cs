namespace dsa.algorithms
{
    class MergeSort : ISortingAlgorithm
    {

        public void Sort(int[] data)
        {
            int[] workingCopy = new int[data.Length];
            ArrayCopy(data, workingCopy);
            Split(data, 0, data.Length, workingCopy);
        }

        private void Split(int[] data, int start, int end, int[] cpy)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                Split(data, start, mid, cpy);
                Split(data, mid + 1, end, cpy);
                Merge(data, start, mid, end, cpy);
            }
        }

        private void Merge(int[] data, int start, int mid, int end, int[] cpy)
        {
            ArrayCopy(data, cpy);

            int i = start, j = mid, k = start;
            while (i < mid && j < end)
            {
                if (cpy[i] <= cpy[j])
                {
                    data[k++] = cpy[i++];
                }
                else
                {
                    data[k++] = cpy[j++];
                }
            }
            while (i < mid)
            {
                data[k++] = cpy[i++];
            }
            while (j < end)
            {
                data[k++] = cpy[j++];
            }
        }

        private void ArrayCopy(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        private int[] ArrayCopyNew(int[] source)
        {
            int[] copy = new int[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                copy[i] = source[i];
            }
            return copy;
        }
    }
}
