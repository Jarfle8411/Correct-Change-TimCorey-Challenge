using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Correct_Change
{
    class CorrectChange
    {
        // Here's a program to output the correct change.


        static void Main(string[] args)
        {
            // declare and intialize variables
            double bal = 978.83;
            double due = 114.64;

            // output's that tells the balance of the account 
            // and the ammount that is due
            Console.WriteLine("Amount owed: {0:C}", bal);
            Console.WriteLine("Amount Due: {0:C}", due);

            // asking user to input how much they'll like to pay
            // I had to convert the console to double due to the console readline being a string
            Console.WriteLine("How much would you like to pay?");
            double pay = Convert.ToDouble(Console.ReadLine());

            //basic math subtraction
            double total = due - pay;
            double overall = bal - pay;
     

            // if statement comparing total to 0
            if(total == 0)
            {
                
                Console.WriteLine("\n==========================================================" + 
                    "\nThanks for making your payment. \nHere is you new balance: {0:C}, \nand here's the amount due next month {1:C}.", overall, due);
            }
                // if else statement stating if total isn't equal to 0
            else if (total != 0)
            {
                Console.WriteLine("\n==========================================================" +
                "\nAmount Due: {0:C} \nAmount Paid: {1:C} \nAmount Left: {2:C}" +
                "\nWhen will you be able to pay the remaining total of {2:C}.", due, pay, total);
            }
        }
    }
}
