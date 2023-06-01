using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Elements
{
    internal class Reverse_a_word
    {
        public static void Reverse()
        {
            // Prompt the user for input
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Split the input string into an array of words
            string[] words = input.Split(' ');

            // Iterate through each word and reverse it
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }

            // Join the reversed words into a new string
            string reversedString = string.Join(" ", words);

            // Display the reversed string
            Console.WriteLine("Reversed string:");
            Console.WriteLine(reversedString);
        }
    }
}

