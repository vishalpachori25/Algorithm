using System;

namespace AlgoPracticce
{
    class Program
    {
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("Now, Array is ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {

            InsertionSort t = new InsertionSort();
        }
    }
}
