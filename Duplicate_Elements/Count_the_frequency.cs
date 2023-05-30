using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Elements
{
    internal class Count_the_frequency
    {
        public static void Count_frequency()
        {
            int[] array = { 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

            // Create a dictionary to store the frequency of each element in the array
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            // Iterate over each element in the array
            foreach (int num in array)
            {
                // Check if the element already exists as a key in the dictionary
                if (frequency.ContainsKey(num))
                {
                    // If it exists, increment its frequency value by 1
                    frequency[num]++;
                }
                else
                {
                    // If it doesn't exist, add it as a new key to the dictionary with a frequency of 1
                    frequency[num] = 1;
                }
            }

            // Iterate over each key-value pair in the dictionary
            foreach (KeyValuePair<int, int> item in frequency)
            {
                // Print the element and its frequency
                Console.WriteLine($"Element {item.Key} occurs {item.Value} times");
            }
        }
    }
}
