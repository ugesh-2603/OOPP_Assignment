using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Elements
{
    internal class Sum_of_row
    {
        public static void Sum_row()
        {
            // Define a 2D matrix
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int rows = matrix.GetLength(0); // Get the number of rows in the matrix

            for (int i = 0; i < rows; i++)
            {
                int sum = 0; // Variable to store the sum of each row

                // Iterate through each element of the current row
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j]; // Add the element to the sum
                }

                Console.WriteLine("Sum of row {0}: {1}", i + 1, sum); // Output the sum of the current row
            }
        }
    }
}
