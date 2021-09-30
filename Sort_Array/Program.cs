using System;

namespace Sort_Array
{
    class Program
    {
        public static void Main()
        {
            
            int[] arr1 = new int[10];
            int n, i, j, tmp;

            //Program to sort numeric array
            Console.Write("\n\nSort [Numeric] elements of array in ascending order :\n");
            Console.Write("----------------------------------------------\n");

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nElements of array in sorted ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");

            //Program to sort string array
            string[] arr;
            string temp1;
            int m, s, k, l;

            Console.Write("\n\nSorts the strings of an array using bubble sort :\n");
            Console.Write("-----------------------------------------------------\n");
            Console.Write("Input number of strings :");
            m = Convert.ToInt32(Console.ReadLine());
            arr = new string[m];
            Console.Write("Input {0} strings below :\n", m);
            for (s = 0; s < m; s++)
            {
                arr[s] = Console.ReadLine();
            }
            l = arr.Length;

            for (s= 0; s < l; s++)
            {
                for (k = 0; k < l - 1; k++)
                {
                    if (arr[k].CompareTo(arr[k + 1]) > 0)
                    {
                        temp1 = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = temp1;
                    }
                }
            }
            Console.Write("\nAfter sorting the array appears like : \n");
            for (s = 0; s < l; s++)
            {
                Console.WriteLine(arr[s] + " ");
            }
        }
    }
}

