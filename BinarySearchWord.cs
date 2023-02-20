using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Problems
{
    internal class BinarySearchWord<T> where T : IComparable
    {
        static int BinarySearch(List<T> wordArray, int leftIndex, int rightIndex, String findIndexOfWord)
        {
            //while the leftIndex is at left and the rightIndex is at right
            while (leftIndex <= rightIndex)
            {
                //Find the middle index of the array
                int middelIndex = leftIndex + (rightIndex - leftIndex) / 2;

                //Declaring variable IsPresent to check that the entered word is present at the middle index or not
                int IsPresent = findIndexOfWord.CompareTo(wordArray[middelIndex]);
                //Here we used CompareTo method for comparing string1.CompareTo(string2)
                //CompareTo method will return 0 if string1 is matched with string2 by ASCII standards
                //will return 1 if string1 is larger than sstring2 by ASCII standards
                //will return -1 if string1 is smaller than string2 by ASCII standards

                //If word is found i.e. matched with entered word
                if (IsPresent == 0)
                {
                    //return it's position
                    return middelIndex;
                }
                //If entered word is larger by ASCII standards than the word at middle index
                if (IsPresent > 0)
                {
                    //set leftIndex to the next index of the middle i.e. search the word in the rightSubArray
                    leftIndex = middelIndex + 1;
                }
                //otherwise
                //entered word is smaller by ASCII standards than the word at middle index
                else
                {
                    //set rightIndex to the middle index of array i.e. search the word in the leftSubArray
                    rightIndex = middelIndex;
                }
            }
            //If word we are looking for is not present in the array
            return -1;
        }

        public void DriverMethod(List<T> wordArray)
        {
            //Creating an ASCII sorted array of words
            //If we Create an unsorted array and then try to search, the search results might give incorrect results
            //If we still want to give unsorted array for searching, we first have to sort it then search in it

            Console.Write("Words present in the list are : ");
            foreach (T word in wordArray)
            {
                Console.Write(" " + word);
            }
            Console.Write("\nEnter the word you want to find : ");
            String findIndexOfWord = Console.ReadLine();

            //Passing (The array of entered words, index of 1st word in array, index of last word in array, word we want to find)
            //to the BinarySearch method
            //foundAtPosition is used to store the position returned by BinarySearch method
            int foundAtPosition = BinarySearch(wordArray, 0, wordArray.Count - 1, findIndexOfWord);

            //BinarySearch method returns -1 when the entered word is not present in the list
            if (foundAtPosition == -1)
            {
                Console.WriteLine("Word is not present in the array");
            }
            //The entered word is present in the list
            else
            {
                Console.WriteLine("Starting from 0'th index the word " + findIndexOfWord + " is found at position/index " + foundAtPosition + " in the list");
            }
        }
    }
}

