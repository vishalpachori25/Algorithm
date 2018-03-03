using System;
namespace AlgoPracticce
{
    public class RecursiveMergeSort
    {
        RecursiveMergeSort()
        {
            int[] array = { 4, 2, 34, 12, 456, 32, 25, 4, 54, 5, 7 };
            Console.Write("! RecursiveMergeSort !  Given Array is :");
            var obj = new RecursiveMergeSort();
            Program.PrintArray(array);

            try
            {
                obj.SortMerge(array);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }


            Program.PrintArray(array);
        }

        void SortMerge(int[] array)
        {
            if (array == null)
            {
                return;
            }

            if (array.Length > 1)
            {
                int mid = array.Length / 2;
                int i = 0, j = 0, k = 0;

                int[] leftArr = new int[mid];
                int[] rightArr = new int[array.Length - mid];

                for (i = 0; i < mid; i++)
                {
                    leftArr[i] = array[i];
                    rightArr[i] = array[i + mid];
                }
                // for last element in case of odd no.
                rightArr[array.Length - mid - 1] = array[array.Length - 1];

                SortMerge(leftArr);
                SortMerge(rightArr);

                i = 0;

                while (i < mid && j < (array.Length - mid))
                {
                    if (leftArr[i] < rightArr[j])
                    {
                        array[k] = leftArr[i];
                        i++;
                    }
                    else
                    {
                        array[k] = rightArr[j];
                        j++;
                    }
                    k++;
                }
                // Collect remaining elements
                while (i < leftArr.Length)
                {
                    array[k] = leftArr[i];
                    i++;
                    k++;
                }
                while (j < rightArr.Length)
                {
                    array[k] = rightArr[j];
                    j++;
                    k++;
                }

            }
        }
    }
}
