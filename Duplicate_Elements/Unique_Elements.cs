using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Elements
{
    internal class Unique_Elements
    {
        public static void Unique()
        {
            // Initialize an array with some integer values
            int[] inputArray = { 1, 2, 2, 3, 4, 4, 5, 6, 6, 6 };

            // Create a boolean array to track whether an element is unique or not
            bool[] isUnique = new bool[inputArray.Length];

            // Iterate over each element in the inputArray
            for (int i = 0; i < inputArray.Length; i++)
            {
                // Check if the current element is already marked as not unique
                if (!isUnique[i])
                {
                    bool foundDuplicate = false; // Flag to track if a duplicate is found

                    // Iterate over the remaining elements in the inputArray
                    for (int j = i + 1; j < inputArray.Length; j++)
                    {
                        // Compare the current element with the remaining elements
                        if (inputArray[i] == inputArray[j])
                        {
                            // If a duplicate is found, mark the duplicate element as not unique
                            isUnique[j] = true;
                            foundDuplicate = true;
                        }
                    }

                    // If no duplicate is found, print the unique element
                    if (!foundDuplicate)
                    {
                        Console.WriteLine(inputArray[i]);
                    }
                }
            }
        }
    }
}
