using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithm_Problems
{
        internal class CustomizeMessage
        {
            static string given = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx. Please,let us know in case of any clarification Thank you BridgeLabz 05/02/2023";

            public void Message()
            {
                //Regular expression or validating name
                string REGEX_NAME = "^[A-Z][A-Za-z]{2,}$";

                //Regular expression for checking mobile number, all mobile numbers starts with 6, 7, 8 or 9
                string REGEX_CELLNO = "^[6-9]{1}[0-9]{9}$";

                //declaring variable for replacing
                string replaceName = "<<name>>";
                string replaceFullName = "<<full name>>";
                string replaceCell = "{10}";
                string replaceDate = "05/02/2023";

                //declaring variable for storing user information
                string firstName, middleName, lastName, cellNumber;

                //Take input from user as first name untill it is valid
                do
                {
                    Console.Write("Enter first name : ");
                    firstName = Console.ReadLine();
                    if (!Regex.IsMatch(firstName, REGEX_NAME))
                    {
                        Console.WriteLine("Invalid First Name");
                    }
                    else
                    {
                        //replace <<name>> by the firstName in the given string
                        given = given.Replace(replaceName, firstName);
                    }
                } while (!Regex.IsMatch(firstName, REGEX_NAME));

                //Take input from user as middle name untill it is valid
                do
                {
                    Console.Write("Enter middle name : ");
                    middleName = Console.ReadLine();
                    if (!Regex.IsMatch(middleName, REGEX_NAME))
                    {
                        Console.WriteLine("Invalid Middle Name");
                    }
                } while (!Regex.IsMatch(middleName, REGEX_NAME));

                //Take input from user as last name untill it is valid
                do
                {
                    Console.Write("Enter last name : ");
                    lastName = Console.ReadLine();
                    if (!Regex.IsMatch(lastName, REGEX_NAME))
                    {
                        Console.WriteLine("Invalid Last Name");
                    }
                    else
                    {
                        //replace <<full name>> with firstName MiddleName LastName in the given string
                        given = given.Replace(replaceFullName, firstName + " " + middleName + " " + lastName);
                    }
                } while (!Regex.IsMatch(lastName, REGEX_NAME));

                //Take input from user as mobile number untill it is valid
                do
                {
                    Console.Write("Enter mobile number : ");
                    cellNumber = Console.ReadLine();
                    if (!Regex.IsMatch(cellNumber, REGEX_CELLNO))
                    {
                        Console.WriteLine("Invalid mobile number");
                    }
                    else
                    {
                        //replace xxxxxxxxxx with the cellNumber is the given string
                        given = given.Replace("xxxxxxxxxx", cellNumber);
                    }
                } while (!Regex.IsMatch(cellNumber, REGEX_CELLNO));

                //Finally replace the date by current date
                //Create date variable storing date in the formatt dd/MM/yyyy
                string curerntDate = DateTime.Now.ToString("dd/MM/yyyy");

                //replace 01/01/2016 with the current date in the given string
                given = given.Replace(replaceDate, curerntDate);

                //finally print the given string with replaced strings
                Console.WriteLine(given);
            }
        }
}

