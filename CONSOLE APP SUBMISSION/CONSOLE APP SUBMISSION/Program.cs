using System;

namespace CONSOLE_APP_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my age.");
            int number = Convert.ToInt32(Console.ReadLine());
            bool age = number == 19;
            do
            {
                switch (number)
                {
                    case 18:
                        Console.WriteLine("Oh so close, but nope");
                        Console.WriteLine("Guess my age.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 30:
                         Console.WriteLine("Im not there yet");
                        Console.WriteLine("Guess my age.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 20:
                        Console.WriteLine("Oh so close, but nope");
                        Console.WriteLine("Guess my age.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 19:
                        Console.WriteLine("Thats Correct!");
                       
                        number = Convert.ToInt32(Console.ReadLine());
                        age = true;
                        break;

                    default:

                        Console.WriteLine("No thats not my age");
                        Console.WriteLine("Guess my age.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;


                }
            }
            while (!age);


            Console.Read();
        }
    }
}
