using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Problems
{
    internal class ExtendedPrime
    {
        public void Prime()
        {
            //Declaring a list to store prime numbers
            List<string> primeNumbersList = new List<string>();

            //Declaring a list to store sorted prime numbers
            List<string> checkForAnagram = new List<string>();

            Console.WriteLine("Prime numbers in the range 1 to 1000 are :");

            //start from 2 till 1000
            //here loop is incrementin by 2 steps because every prime number is odd
            //we are calculating prime numbers in odd numbers only
            for (int i = 2; i < 1000; i++)
            {
                //Declaring nonPrime variable for non prime numbers
                int nonPrime = 0;

                //Find prime number
                for (int j = 2; j <= i / 2; j++)
                {
                    //if number in range is divided by some number and remainder is 0
                    if (i % j == 0)
                    {
                        //the number is not prime
                        nonPrime = 1;

                        //break current loop, caculate for next number
                        break;
                    }
                }
                //If nonPrime is not set to 1
                //if number is prime, add it to the primeNumbersList
                if (nonPrime == 0)
                {
                    primeNumbersList.Add(i.ToString());

                    //temp array to store each prime number in type string for easy calculation
                    char[] temp = i.ToString().ToCharArray();

                    //sorting temp array
                    //For example, the number 71 will be sorted as 17
                    //i.e. in ascending order
                    Array.Sort(temp);

                    //converting temp back to string
                    checkForAnagram.Add(String.Join("", temp));
                }
            }
            //Printing each prime number
            for (int i = 0; i < primeNumbersList.Count; i++)
            {
                Console.Write(primeNumbersList[i] + " ");
            }
            Console.WriteLine("\n");

            //for calculatin of prime numbers that are anagrams in range of 1 to 1000
            Anagram(primeNumbersList, checkForAnagram);
        }
        public static void Anagram(List<string> primeNumbersList, List<string> checkForAnagram)
        {
            //Declaring a List anagramPrimes for storing prime numbers which are anagram in range 1 to 1000
            List<string> anagramPrimes = new List<string>();

            Console.WriteLine("Prime numbers that are anagrams in the range 1 to 1000 are : ");
            List<string> primeNumbersListTemp = new List<string>(primeNumbersList);
            for (int i = 0; i < primeNumbersList.Count; i++)
            {
                //declaring List checkForAnagramTemp every time because we are deleting current number every time
                //if we don't declare it every time, because of dynamic nature of Lists the current number will not be
                //present in the List for the next iteration, resulting in incorrect output
                List<string> checkForAnagramTemp = new List<string>(checkForAnagram);

                //character temp array will store each number in primeNumbersList to character array converted by ToCharArray method
                char[] temp = primeNumbersList[i].ToCharArray();

                //sortingg temp array in ascending order
                Array.Sort(temp);

                //converting temp array to string again for further calculation
                string temp2 = new string(temp);

                //removing current prime number from checkForAnagramTemp List
                //if we dont remove current number, the result will be true every time and each number will print again
                checkForAnagramTemp.RemoveAt(i);

                //sortedTemp List for storing sorted primeNumbersList, stores each prime number in sorted manner
                List<string> sortedTemp = new List<string>();

                //loop will sort each number in primeNumbersListTemp and store it to sortedTemp List
                for (int k = 0; k < primeNumbersListTemp.Count; k++)
                {
                    char[] temp3 = primeNumbersListTemp[k].ToCharArray();
                    Array.Sort(temp3);
                    string temp4 = String.Join("", temp3);
                    sortedTemp.Add(temp4);
                }

                //if checkForAnagramTemp List contain the current element
                if (checkForAnagramTemp.Contains(sortedTemp[i]))
                {
                    //add it to anagramPrimes List for further calculation
                    anagramPrimes.Add(primeNumbersList[i]);

                    //Print it
                    Console.Write(primeNumbersList[i] + " ");
                }
            }
            Console.WriteLine("\n");

            //checking for palindrome
            Palindrome(anagramPrimes);
        }
        public static void Palindrome(List<string> anagramPrimes)
        {
            Console.WriteLine("Prime numbers that are anagrams as well as palindrome in the range 1 to 1000 are :");

            //Declaring a List reversePrimeNumbers for reversed prime numbers
            List<string> reversePrimeNumbers = new List<string>();


            for (int i = 0; i < anagramPrimes.Count; i++)
            {
                //temp character array will store each number in anagramPrimes List
                char[] temp = anagramPrimes[i].ToCharArray();

                //reverse the temp array
                Array.Reverse(temp);

                //convert the array temp back to string
                string check = new string(temp);

                //store it to reversePrimeNumbers List for further calculation
                reversePrimeNumbers.Add(check);
            }
            for (int j = 0; j < anagramPrimes.Count; j++)
            {
                //declaring List reversePrimeTemp every time because we are deleting current number every time
                //if we don't declare it every time, because of dynamic nature of Lists the current number will not be
                //present in the List for the next iteration, resulting in incorrect output
                List<string> reversePrimeTemp = new List<string>(reversePrimeNumbers);

                //remove current item which we are checking from the List reversePrimeTemp
                reversePrimeTemp.RemoveAt(j);

                //if reverse/palindrome of the number is present in reversePrimeTemp List
                if (reversePrimeTemp.Contains(anagramPrimes[j]))
                {
                    //Print it
                    Console.Write(anagramPrimes[j] + " ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}


