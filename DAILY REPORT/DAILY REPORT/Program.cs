using System;

namespace DAILY_REPORT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report");
            // This part of the code is for the name
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine(" So your " + yourName);
            Console.ReadLine();
            //This part is which course your on
            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            Console.WriteLine("So " + yourName + " your on the " + Course + " course.");
            Console.ReadLine();
            // For pg #
            Console.WriteLine("What page number?");
            string pagenumber = Console.ReadLine();
            int PG = Convert.ToInt32(pagenumber);
            Console.WriteLine(" Really page " + PG + " Thats impressive.");

            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string Help =Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("Thank you for the feedback.");
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string Study = Console.ReadLine();
            int hours = Convert.ToInt32(Study);
            Console.WriteLine("Good job putting in " + hours + " hours of study!");
            Console.ReadLine();

            Console.WriteLine("Thank you for your answers, ill make sure to get them to an instructor and he'll respond shortly. Have a great a day!");
            Console.ReadLine();












        }
    }
}
