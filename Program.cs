/*
Programmer: Alaeldeen Alkenani
Date Created: 9/15/2020
Description: This C# Console application code demonstrates the use of
              iterative statements after getting input from users.
*/

using System;

namespace Iteration_Statements_Tech_Proj_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use try-catch to prevent the program from crashing.
            try
            {
                // This will allow the user to enter a value
                Console.Write("Enter an integer value between 1 and 25. ");

                // Use string to represent the value.
                string input;

                // Using integer for entering the value
                int n;

                // Allow the console to read and display the text.
                input = Console.ReadLine();

                // Use parse to input the value.
                n = int.Parse(input);

                // Use if and else statement to determine if the number entered is valid or invalid
                if (n > 0 && n < 26)
                {
                    // For loop to execute values entered from 1 to 25 in order.
                    for (int i = 1; i < n + 1; i++)
                    {
                        // Use write line to allow the user to display entered values.
                        Console.WriteLine("You have entered " + n + ". This is the current integer value in the loop: " + i + ".");
                    }
                    // Allow the console to read the text that has been inputed.
                    Console.ReadKey();
                }
                else
                {
                    // Display error if number is invalid.
                    Console.Write("Invalid number entered. Your penchant for noncompliance is noted, human.");
                    Console.ReadKey();
                }
            } // end of try
            catch
            {
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // end of catch
        } // end of main
      } // end of class
    } // end of program
