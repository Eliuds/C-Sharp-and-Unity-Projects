using System;

namespace CONSOLE_APP_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Guess my age.");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool age = number == 19;
            //do
            //{
            //    switch (number)
            //    {
            //        case 18:
            //            Console.WriteLine("Oh so close, but nope");
            //            Console.WriteLine("Guess my age.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 30:
            //            Console.WriteLine("Im not there yet");
            //            Console.WriteLine("Guess my age.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 20:
            //            Console.WriteLine("Oh so close, but nope");
            //            Console.WriteLine("Guess my age.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 19:
            //            Console.WriteLine("Thats Correct!");


            //            age = true;
            //            break;

            //        default:

            //            Console.WriteLine("No thats not my age");
            //            Console.WriteLine("Guess my age.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;


            //    }
            //}
            //while (!age);


            //Console.Read();


            Console.WriteLine("Whats your favorite number?");
            int number1 = Convert.ToInt32(Console.ReadLine());
            bool FavNum = number1 == 55;

            while (!FavNum) 
            {
               switch(number1)
               {
                    case 12:
                        Console.WriteLine("Really 12?");
                        Console.WriteLine("Whats your favorite number?");
                         number1 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine("Thats pretty close to what should be your favorite number");
                        Console.WriteLine("Whats your favorite number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 55:
                        Console.WriteLine("55 is the best number isnt it?");
                        FavNum = true;
                        break;

                    default:
                        Console.WriteLine("You should rethink that.");
                        Console.WriteLine("Whats your favorite number?");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            Console.Read();



        }
    }
}
