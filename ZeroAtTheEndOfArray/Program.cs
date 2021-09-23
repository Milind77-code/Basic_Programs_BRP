using System;

namespace ZeroAtTheEndOfArray
{

    class PushZero
    {
        // Function which pushes all zeros to end of an array.
        static void pushZerosToEnd(int[] arr, int n)
        {
            // Count of non-zero elements
            int count = 0;

            // Traverse the array. If element encountered is non-zero 
            for (int i = 0; i < n; i++)
                if (arr[i] != 0)

                    // here count is incremented
                    arr[count++] = arr[i];

            // Now all non-zero elements have been shifted to front.
            // Make all elements 0 from count to end.
            while (count < n)
                arr[count++] = 0;
        }

        // Driver function
        public static void Main()
        {
            int[] arr = { 0,0,1,0,3,0,5,0,6};
            int n = arr.Length;
            pushZerosToEnd(arr, n);
            Console.WriteLine("Array after pushing all zeros to the back: ");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
