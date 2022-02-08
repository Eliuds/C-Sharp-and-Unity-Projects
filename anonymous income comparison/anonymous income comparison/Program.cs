using System;

namespace anonymous_income_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate");
            int rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week");
            int Weekly = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("Hourly Rate");
            int rate2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week");
            int Weekly2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            int product = rate * Weekly * 52;
            Console.WriteLine(product);

            Console.WriteLine("Annual salary of Person 2:");
            int product2 = rate2 * Weekly2 * 52;
            Console.WriteLine(product2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool TrueOrFalse = product > product2;
            Console.WriteLine(TrueOrFalse.ToString());



        }
    }
}
