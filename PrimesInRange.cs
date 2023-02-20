using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Problems
{
    internal class PrimesInRange
    {
        public void Prime()
        {
            Console.WriteLine("Prime numbers in the range 1 to 1000 are :");

            //start from 2 till 1000
            //here loop is incrementin by 2 steps because every prime number is odd
            //we are calculating prime numbers in odd numbers only
            for (int i = 2; i < 1000; i += 2)
            {
                //Declaring nonPrime variable for non prime numbers
                int nonPrime = 0;

                //if i is 2, directly print it
                if (i == 2)
                {
                    Console.Write(2);
                    i++;
                }
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
                //if number is prime, print it
                if (nonPrime == 0)
                {
                    Console.Write(" " + i);
                }
            }
        }
    }
}

