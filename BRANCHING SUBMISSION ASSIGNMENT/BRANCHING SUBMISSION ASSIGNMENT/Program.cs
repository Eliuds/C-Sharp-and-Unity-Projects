using System;

namespace BRANCHING_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter package weight");
            int Weight = Convert.ToInt32(Console.ReadLine());
            if (Weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the width of your packag?");
                int Width = Convert.ToInt32(Console.ReadLine());

                if (Width > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    Console.WriteLine("What is the height of the package?");
                    int Height = Convert.ToInt32(Console.ReadLine());

                    if (Height > 50)
                    {
                        Console.WriteLine("Package too big to be shipped via Package Express.");
                    }

                    
                    


                        Console.WriteLine("What is the length of your package?");
                        int Length = Convert.ToInt32(Console.ReadLine());

                        if (Length > 50)
                        {
                            Console.WriteLine("Package too big to be shipped via Package Express.");
                        }
                    
                }
            }
            decimal quote = Height * Width * Length * Weight / 100;

            Console.WriteLine("$" + quote);
            Console.ReadLine();


             
        }
    }
}
