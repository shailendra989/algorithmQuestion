using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Problems
{
    internal class PermutationsOfString
    {
        public static void Permute(String enteredString, int leftIndex, int rightIndex)
        {
            //If leftIndex and rightIndex are pointing to the same index of the enteredString, simply print the enteredString
            if (leftIndex == rightIndex)
            {
                Console.WriteLine(enteredString);
            }
            //otherwise
            else
            {
                //start from the leftIndex here 1st index and go till the rightIndex here end of the enteredStringing to compute
                for (int i = leftIndex; i <= rightIndex; i++)
                {
                    //Swapping the leftIndex char with the i'th index char i.e. current and the next
                    //to compute for the next string
                    enteredString = Swap(enteredString, leftIndex, i);

                    //Recursive call
                    //passing enteredString for permutataion operation
                    Permute(enteredString, leftIndex + 1, rightIndex);

                    //Swap the array again to make it as it was before
                    //this operation is known as backtracking
                    enteredString = Swap(enteredString, leftIndex, i);
                }
            }
        }
        //Method for swaping characters in the string and it is returning String
        public static String Swap(String enteredString, int leftIndex, int rightIndex)
        {
            //Creating a character array named tempString to perform swapping operation
            char[] tempString = enteredString.ToCharArray();

            //creating a temporary variable temp for swapping operation
            //swap logic to swap leftIndex with the rightIndex
            char temp = tempString[leftIndex];
            tempString[leftIndex] = tempString[rightIndex];
            tempString[rightIndex] = temp;

            //Converting tempString array back to string
            string toReturn = new string(tempString);

            //Finally return the string which we have converted from the array
            return toReturn;
        }
        public void Driver()
        {
            Console.Write("Enter the string to find all of it's permutations : ");
            string enteredString = Console.ReadLine();
            Console.WriteLine("Permutations of the string " + enteredString + " are :");
            Permute(enteredString, 0, enteredString.Length - 1);
        }
    }
}

