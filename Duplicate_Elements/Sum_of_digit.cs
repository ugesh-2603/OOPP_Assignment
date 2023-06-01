using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Elements
{
    internal class Sum_of_digit
    {
        public static void Sum()
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Call the SumOfDigits method to get the sum of digits
            int sum = SumOfDigits(number);

            // Display the result
            Console.WriteLine("Sum of digits: " + sum);
        }

        // Method to calculate the sum of digits
        static int SumOfDigits(int number)
        {
            int sum = 0;

            // Loop through each digit of the number
            while (number != 0)
            {
                // Extract the last digit using the modulo operator (%)
                int digit = number % 10;

                // Add the digit to the sum
                sum += digit;

                // Remove the last digit from the number
                number /= 10;
            }

            // Return the sum of digits
            return sum;
        }
    }
}
