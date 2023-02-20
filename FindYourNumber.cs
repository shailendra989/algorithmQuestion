using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Problems
{
    internal class FindYourNumber
    {
        //method will guess the integer by binary search logic
        public void Find()
        {
            Console.Write("Enter start of the range : ");
            int rangeStart = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter end of the range : ");
            int rangeEnd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            //setting index values for the range
            int lower = rangeStart, higher = rangeEnd;

            //setting middle element
            int middle = (lower + higher) / 2;

            //int choice;
            while (true)
            {
                //final condition / no range condition
                if (lower == higher)
                {
                    return;
                }
                Console.WriteLine("1. Your number is greater than " + middle);
                Console.WriteLine("2. Your number is less than " + middle);
                Console.WriteLine("3. Your number is : " + middle);
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Setting lower to middle value if our number is greater, to check in higher half of the range
                        lower = middle;
                        break;
                    case 2:
                        //Setting higher to middle value if our number is less, to check in lower half of the range
                        higher = middle;
                        break;
                    case 3:
                        //In case our number matches with the number printed
                        return;
                    default:
                        Console.WriteLine("Please enter correct choice");
                        break;
                }
                //depending on user's choice middle value is going to change every time
                //values are shifting by half
                middle = (lower + higher) / 2;
            }
        }
    }
}

