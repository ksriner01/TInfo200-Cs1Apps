// Kyle Riner
// Cs1 assignment, DigitParser program
// TINFO-200A, Winter 2022

//////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date         Developer   Description of change
// 1-19-2022    kriner      Initial creation of file and initial testing
// 1-22-2022    kriner      Added startup and signoff, final testing
//
// This program prompts the user for a five digit number as the input and outputs the individual
// digits with three spaces between one another. When a number with more than 5 digits is entered
// the user will be told that the number has too many digits. When a number with less than five
// digits is entered the user will be told that the number has too few digits. This distinction
// will be evaluated through the use of an if/else statement.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the namespace for the DigitParser program
namespace DigitParser
{
    // begins declaration of the class the holds the DigitParser program
    internal class Program
    {
        // the main method where the DigitParser program will be executed
        static void Main(string[] args)
        {
            // text displayed to user upon initiation of the program
            Console.WriteLine(@"
Welcome to the DigitParser program! This program will ask you to enter
a five digit number and will seperate the given number into its individual
digits. When attempting to enter a number without five digits, the 
program will inform you as to whether the number you entered was too big
or too small.
");

            // prompts the user for a five digit integer
            Console.Write("Please enter a positive five digit whole number (ex: 10000 - 99999): ");
            int num = int.Parse(Console.ReadLine());

            if (num.ToString().Length > 5) // if the number is larger than 99999 it will always have six digits or more
            {
                Console.WriteLine("You have entered a number with too many digits.");
            }
            else if (num.ToString().Length < 5) // if the number is less than 10000 it will always have four digits or less
            {
                Console.WriteLine("You have entered a number with too few digits.");
            }
            else // if neither of the above are true, then the user successfully entered a five digit number
            {
                // the integer digit will be equal to the number the user inputted divided by the
                // integer divisor, an integer made to keep the digits in the correct order, and find
                // the remainder when dividing by 10. The resulting digit will be written down and the divisor
                // will then be divided by 10 to evaluate the next digit. This occurs for as long as the
                // counter i is less than 5, which results in the whole 5 digit number being printed out. 
                int divisor = 10000;
                for (int counter = 0; counter < 5; counter++)
                {
                    int digit = (num / divisor) % 10;
                    Console.Write($"{digit}   ");
                    divisor /= 10;
                }
            }

            // signoff for when the program ends
            Console.WriteLine("\nThank you for using the DigitParser program.");
        }
    }
}