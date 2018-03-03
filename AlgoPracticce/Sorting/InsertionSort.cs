using System;
namespace AlgoPracticce
{
    public class InsertionSort
    {
        public InsertionSort()
        {
            int[] array = { 445, 2, 34, 12 };
            Console.Write("! Insertion  Sort !  Given Array is :");

            Program.PrintArray(array);

            SortInsertion(array);

            Program.PrintArray(array);
        }

        void SortInsertion(int[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                int k = array[i];
                int j = i - 1;

                while (j >= 0 && k < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                Program.PrintArray(array);
                array[j + 1] = k;
                Program.PrintArray(array);
            }

        }
    }
}
