using System;
namespace AlgoPracticce
{
    /// <summary>
    /// Devide and conquer method for Merge sort.
    /// </summary>
    class MergeSort
    {
        MergeSort()
        {
            int[] array = { 4, 2, 34, 12, 456, 32, 25, 4, 54, 5 };
            Console.Write("!Merge Sort !  Given Array is :");
            var obj = new MergeSort();
            Program.PrintArray(array);

            obj.SortMerge(array, 0, array.Length - 1);

            Program.PrintArray(array);
        }

        void SortMerge(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                SortMerge(arr, left, middle);
                SortMerge(arr, middle + 1, right);

                MergeArray(arr, left, middle, right);
            }
        }

        void MergeArray(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            /* Create temp arrays */
            int[] L = new int[n1];
            int[] R = new int[n2];

            /*Copy data to temp arrays*/
            for (int a = 0; a < n1; ++a)
                L[a] = arr[left + a];
            for (int b = 0; b < n2; ++b)
                R[b] = arr[middle + 1 + b];


            /* Merge the temp arrays */

            // Initial indexes of first and second subarrays
            int i = 0, j = 0;

            // Initial index of merged subarry array
            int k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            /* Copy remaining elements of L[] if any */
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            /* Copy remaining elements of R[] if any */
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
