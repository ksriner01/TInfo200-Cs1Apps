// Kyle Riner
// Cs1 assignment, BodyMass program
// TINFO-200A, Winter 2022

//////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date         Developer   Description of change
// 1-20-2022    kriner      Initial creation of file and initial testing
// 1-21-2022    kriner      Added if statement for categorization of BMI
// 1-22-2022    kriner      Added startup and signoff, final testing
//
// This program first prompts the user for their weight in pounds and height in inches. The program
// then calculates and rounds the user's BMI. Afterwards, the BMI is put through an if statement to
// determine what BMI category the user falls under. This information is then outputted to the user.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the namespace of the BodyMass program
namespace BodyMass
{
    // begins declaration of the class the holds the BodyMass program
    internal class Program
    {
        // the main method where the BodyMass program will be executed
        static void Main(string[] args)
        {
            // startup text to introduce the user to the program
            Console.WriteLine(@"
Welcome to the BodyMass program! You will be prompted to enter your weight in 
pounds and height in inches. The program will then calculate your BMI based on
these inputs. You will then be shown your BMI and what category it falls 
under according to the national BMI values.
");

            // prompts the user for their weight in pounds
            Console.Write("Please enter your weight in pounds (ex: 170.0, etc.): ");
            double weightInPounds = double.Parse(Console.ReadLine());

            // prompts the user for their height in inches
            Console.Write("Please enter your height in inches (ex: 71.0, etc.): ");
            double heightInInches = double.Parse(Console.ReadLine());

            // performs the calculation for BMI of the user and rounds it
            double bodyMass = (weightInPounds / heightInInches / heightInInches) * 703;
            double roundedBodyMass = Math.Round(bodyMass, 1);

            // if statement that determines the user's BMI category based on their
            // BMI after the calculation.
            string bmiCategory;
            if (roundedBodyMass < 18.5) // if the BMI is less than 18.5 the bmiCategory is underweight
            {
                bmiCategory = "underweight";
            }
            else if (roundedBodyMass < 25) // if the BMI is between 18.5 and 24.9 the bmiCategory is normal
            {
                bmiCategory = "normal weight";
            }
            else if (roundedBodyMass < 30) // if the BMI is between 25 and 29.9 the bmiCategory is overweight
            {
                bmiCategory = "overweight";
            }
            else // if the BMI is 30 or above the bmiCategory is obese
            {
                bmiCategory = "obese";
            }

            // outputs the official BMI categories to the user
            Console.WriteLine(@"
BMI VALUES

Underweight: less than 18.5
Normal: between 18.5 and 24.9
Overweight: between 25 and 29.9
Obese: 30 or greater");

            // outputs the BMI of the user alongside the BMI category they fall under
            Console.WriteLine($"\nYour BMI is {roundedBodyMass}. According to the national BMI categories you are {bmiCategory}.");

            // signoff for when the program ends
            Console.WriteLine("\nThank you for using the BodyMass program.");
        }
    }
}
