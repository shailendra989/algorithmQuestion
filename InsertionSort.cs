using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Problems
{
    internal class InsertionSort<T> where T : IComparable
    {
        //Insertion sort logic
        public void Insertion()
        {
            InsertionSort<T> insertionSort = new InsertionSort<T>();

            Console.Write("Enter integer values one by one separated by spaces : ");
            //Taking input from user and storing it to strings array of type string
            string[] strings = Console.ReadLine().Split();

            int[] sortArray = new int[strings.Length];
            //Converting each string value in strings array to integer type and storing it to sortArray for further calculation
            for (int i = 0; i < strings.Length; i++)
            {
                sortArray[i] = Convert.ToInt32(strings[i]);
            }
            Console.Write("Array before sorting is : ");
            insertionSort.PrintArray(sortArray);

            //Start from 2nd element in the array till the last element in the array
            //starting from 2nd because we are starting variable j from one index before i'th index
            for (int i = 1; i < sortArray.Length; i++)
            {
                //declaring variable key to store a reference element to compare each element in the array
                int key = sortArray[i];

                //Declaring variable j starting from one index before i
                int j = i - 1;

                //while j is greater than or equal to the 1st index of array and
                //the element at j'th index is greater than the "key"
                while (j >= 0 && sortArray[j] > key)
                {
                    //replace the next element in the array with the current one
                    sortArray[j + 1] = sortArray[j];

                    //then decrease the value of j for comparing the element behind the current with the key
                    j--;
                }
                //finally place the key at the next index of j
                sortArray[j + 1] = key;
            }
            Console.Write("Sorted Array using Insertion sort is : ");
            insertionSort.PrintArray(sortArray);
        }
        //Print array method
        public void PrintArray(int[] sortArray)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                Console.Write(" " + sortArray[i]);
            }
            Console.WriteLine();
        }
    }
}

