﻿using System;

namespace Duplicate_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.Duplicate_Element\n2.Unique_Elements\n3.Count_the_frequency");
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
            }

        }
    }
}