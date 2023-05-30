using System;

namespace Duplicate_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Choose any one program from below option");
            Console.WriteLine("1.Duplicate_Element");
            int option = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("1.Duplicate_Element\n2.Unique_Elements");
           
            switch (option)
            {
                case 1:
                    Duplicate_Elements1.Duplicate();
                    break;

                case 2:
                    Unique_Elements.Unique();
                    break;
            }

        }
    }
}