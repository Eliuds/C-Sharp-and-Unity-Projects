using System;

namespace approval_program_for_car_insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI, plz respond with true or false?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int speedtickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("qualified");

            bool qualified = (age > 15 && (DUI == false && (speedtickets <= 3)));
            Console.WriteLine(qualified);
        }
    }
}
