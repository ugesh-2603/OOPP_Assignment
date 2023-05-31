using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Elements
{
    internal class Square_Star_Pattern
    {
        public static void SquareStar()
        {
            int size = 10; // Define the size of the square

            for (int i = 0; i < size; i++) // Iterate through each row
            {
                for (int j = 0; j < size; j++) // Iterate through each column
                {
                    // Check if the current position is on the border of the square
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        // Print a star for the border
                        Console.Write("*");
                    }
                    else
                    {
                        // Print an empty space for the inside of the square
                        Console.Write(" ");
                    }
                }

                Console.WriteLine(); // Move to the next line after printing each row
            }

            //Console.ReadLine(); // Wait for the user to press Enter before closing the console window
        }
    }
}
