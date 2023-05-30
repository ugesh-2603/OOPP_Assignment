using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Elements
{
    internal class Duplicate_Elements1
    {
        public static void Duplicate()
        {
            int[] numbers = { 1, 2, 3, 4, 1, 2, 4, 4, 5, 5 };
            int count = 0;

            // Loop through each element in the array
            for (int i = 0; i < numbers.Length; i++)
            {
                // Check if the current element is not already counted as a duplicate
                if (numbers[i] != -1)
                {
                    // Loop through the remaining elements
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        // If a duplicate is found
                        if (numbers[i] == numbers[j])
                        {
                            // Mark the duplicate element as -1
                            numbers[j] = -1;
                            // Increment the count of duplicates
                            count++;
                        }
                    }
                }
            }

            // Display the total number of duplicate elements
            Console.WriteLine("Total number of duplicate elements: " + count);
        }
    }
}
