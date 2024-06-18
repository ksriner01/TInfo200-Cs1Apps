// Kyle Riner
// Cs1 assignment, OddOrEven program
// TINFO-200A, Winter 2022

//////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date         Developer   Description of change
// 1-19-2022    kriner      Initial creation of file and initial testing
// 1-22-2022    kriner      Added startup and signoff, final testing
//
// This program prompts a user for an integer and will then tell the user whether the number inputted
// was an odd or even number by calculating the remainder of the inputted number when divided by 2. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the namespace for the OddOrEven program
namespace OddOrEven
{
    // begins declaration of the class that holds the OddOrEven program
    internal class Program
    {
        // the main method where the OddOrEven program will be executed
        static void Main(string[] args)
        {
            // text displayed to user upon initiation of program
            Console.WriteLine(@"
Welcome to the OddOrEven program! This program will ask you
to enter a whole number and will determine whether that number
is an odd or even number.
");

            // prompts the user for an integer to determine if it is even or odd
            Console.Write("Please enter a whole number (ex: 1, 10, 100, etc.): ");
            int num = int.Parse(Console.ReadLine());

            // begins if statement that determines whether the received integer is even or odd
            // if the remainder when dividing by 2 is 0 the number is even
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number.");
            }
            else // else the number is odd
            {
                Console.WriteLine($"{num} is an odd number.");
            }

            // signoff for when the program ends
            Console.WriteLine("\nThank you for using the OddOrEven program.");
        }
    }
}
