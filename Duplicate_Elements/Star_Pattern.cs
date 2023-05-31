using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Elements
{
    internal class Star_Pattern
    {
        public static void Star()
        {
            int rows = 8; // The number of rows in the pattern

            // Loop through each row
            for (int i = rows; i >= 1; i--)
            {
                // Loop to print asterisks in each row
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Move to the next line
            }
        }
    }
}
