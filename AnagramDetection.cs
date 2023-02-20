using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Problems
{
    internal class AnagramDetection
    {
        public void Anagram()
        {
            Console.Write("Enter first string : ");
            string firstString = Console.ReadLine();
            Console.Write("Enter second string : ");
            string secondString = Console.ReadLine();

            //If size of firstString does not match with secondString
            if (firstString.Length != secondString.Length)
            {
                Console.WriteLine("The two strings are not anagram of each other");
            }

            //Created tempString array for converting entered strings to character arrays
            char[] firstStringArray = firstString.ToCharArray();
            char[] secondStringArray = secondString.ToCharArray();

            //Array.Sort will sort the array by ASCII values
            //to check for anagram test we will sort both the string arrays
            Array.Sort(firstStringArray);
            Array.Sort(secondStringArray);

            //After sorting the string arrays we will convert them again into strings for anagram checking
            //Join method will first join the array without any spaces between two characters of the string
            //then String class will convert the joined characters to string
            //if first string matches with second string
            if (String.Join("", firstStringArray) == String.Join("", secondStringArray))
            {
                Console.WriteLine("The two strings \"" + firstString + "\" and \"" + secondString + "\" are anagrams of each other");
            }
        }
    }
}

