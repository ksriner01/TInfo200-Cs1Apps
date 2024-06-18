// Kyle Riner
// Cs1 assignment, CarPool program
// TINFO-200A, Winter 2022

//////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date         Developer   Description of change
// 1-20-2022    kriner      Initial creation of file and initial testing
// 1-22-2022    kriner      Added carpooling information, startup and signoff messages, and final testing
//
// References
// Vanpool - https://kingcounty.gov/~/media/depts/metro/travel-options/rideshare/resources/accounting/2019-5-day-schedule.ashx?la=en
// CarpoolWorld - https://www.carpoolworld.com/free-carpool-listings.html
//
// The CarPool program prompts the user to enter details about their daily commute to their workplace
// such as miles driven, cost of gas, average miles per gallon, cost of parking, and cost of tolls.
// The total of all the costs is then outputted for the user to determine exactly how much they spend
// every day. The user is also given some information about carpooling services and recommended to
// Vanpool based on how expensive their current commute is.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the namespace for the CarPool program
namespace CarPool
{
    // begins declaration of the class where that holds the CarPool program
    internal class Program
    {
        // the main method where the CarPool program will be executed
        static void Main(string[] args)
        {
            // text displayed to user upon initiation of the program
            Console.WriteLine(@"
Welcome to the CarPool program! This program will prompt you for information
about your daily commute. You will be asked to input your daily miles driven, the
gas price per gallon in cents, the average miles per gallon of your commute, 
your daily parking fees in cents, and your daily toll fees in cents. This information
will then be calculated and outputted to you as the total cost of your daily commute. 
Additionally, this program will provide information about and recommend some carpooling 
options depending on the total cost of your daily commute.
");

            // prompts the user for the total miles driven per day
            Console.Write("Please enter the total miles driven per day (ex: 30, 20, etc.): ");
            int miles = int.Parse(Console.ReadLine());

            // prompts the user for the cost per gallon of gasoline
            Console.Write("Please enter the cost per gallon of gas in cents (ex: 275, etc.): ");
            double gasPrice = double.Parse(Console.ReadLine());

            // prompts the user for the total fuel used per day in gallons
            Console.Write("Please enter the average miles per gallon of your commute (ex: 20, etc.): ");
            double milesPerGallon = double.Parse(Console.ReadLine());

            // prompts the user for their daily parking fees
            Console.Write("Please enter the parking fees per day in cents (ex: 1000, etc.): ");
            double parkFee = double.Parse(Console.ReadLine());

            // prompts the user for the tolls they pay per day
            Console.Write("Please enter the tolls per day in cents (ex: 250, etc.): ");
            double tollFee = double.Parse(Console.ReadLine());

            // performs the calculations for the amount of gas used and the total cost per
            // day of driving to work.
            double gas = miles / milesPerGallon;
            double costPerDay = ((gasPrice * gas) + parkFee + tollFee) / 100;

            // outputs to the user how many miles they travled, how many gallons of fuel they used,
            // the average miles per gallon, and the total cost of their daily drive.
            Console.WriteLine($"\nBased on the information provided, the total cost per day of your\n" +
                $"commute is {costPerDay:C}. The monthly cost of your current commute is {costPerDay * 30:C}.");

            // text displayed at the beginning of the carpool information section of the program
            Console.WriteLine(@"
To both save money and help reduce your carbon footprint you may consider
looking into some carpool programs in your area. Here are a couple of 
common rideshare services that may help you save money:
");

            // the average monthly fare of Vanpool is compared to the user's current monthly cost and
            // if Vanpool is cheaper, outputs the savings to the user. If the commute of the user is 
            // cheaper than Vanpool services, informs the user that this is so and recommends them to 
            // still think about carpooling for the environmental benefits.
            // 
            // Information acquired from kingcounty.gov
            double vanPoolCost = (1461.03 / 30); // the average monthly fare of Vanpool 
            if (vanPoolCost < costPerDay * 30)
            {
                Console.WriteLine($"Comparing the average monthly cost of Vanpool for a 7 day work week to the estimated\n" +
                    $"monthly cost of your commute you would save {(costPerDay * 30) - vanPoolCost:C} per month.");
            }
            else
            {
                Console.WriteLine($"Your current commute currently saves you {vanPoolCost - (costPerDay * 30):C} per month over Vanpool's average\n" +
                    $"monthly fares for a 7 day work week. However, you still may want to think about\n" +
                    $"carpooling for the environmental benefits it may have within your community.");
            }

            // CarpoolWorld has no set fares and therefore lets the users of the site come to their
            // own pricing arrangements. Commonly people will split the cost between the passenger and 
            // driver if the arrangement is made between two people. 
            //
            // information acquired from www.carpoolworld.com
            Console.WriteLine($"\nAt CarpoolWorld, they let you make your own cost-sharing arrangements\n" +
                $"and doesn't take a fee from anyone involved. Typically, drivers like to split the cost\n" +
                $"of the original commute and therefore you can expect to save around half of your original\n" +
                $"cost per day when carpooling with one other person, or {costPerDay / 2:C} per day.\n");

            // signoff for the user upon reaching the end of the program
            Console.WriteLine("Thank you for using the CarPool program.");
        }
    }
}
