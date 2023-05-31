using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Elements
{
    internal class Min_Max_Element
    {
        public static void Min_Max()
        {
            Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements:");

            // Reading the elements from the user
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            // Initializing variables for maximum and minimum elements
            int max = arr[0];
            int min = arr[0];

            // Finding the maximum and minimum elements
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            // Printing the maximum and minimum elements
            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Minimum element: {min}");
        }
    }

}
    

