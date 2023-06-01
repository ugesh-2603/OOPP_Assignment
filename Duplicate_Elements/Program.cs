﻿using System;

namespace Duplicate_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.Duplicate_Element\n2.Unique_Elements\n3.Count_the_frequency\n4.Min_Max_Element\n5.Star_Pattern\n6.Square_Star_Pattern\n7.Reverse_a_word\n8.Sum_of_digit\n9.Sum_of_row");
            int option = Convert.ToInt32(Console.ReadLine());
           
            
           
            switch (option)
            {
                case 1:
                    Duplicate_Elements1.Duplicate();
                    break;

                case 2:
                    Unique_Elements.Unique();
                    break;

                case 3:
                    Count_the_frequency.Count_frequency();
                    break;

                case 4:
                    Min_Max_Element.Min_Max();
                    break;

                case 5:
                    Star_Pattern.Star();
                    break;

                case 6:
                    Square_Star_Pattern.SquareStar();
                    break;

                case 7:
                    Reverse_a_word.Reverse();
                    break;

                case 8:
                    Sum_of_digit.Sum();
                    break;

                case 9:
                    Sum_of_row.Sum_row();
                    break;


            }

        }
    }
}