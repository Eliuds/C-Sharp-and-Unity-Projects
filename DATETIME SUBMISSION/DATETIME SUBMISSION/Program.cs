using System;
using System.IO;

namespace DATETIME_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter file = new StreamWriter(@"C:\Users\13218\log.txt", true))// Choosing a path where the txt file will go
            {

                file.WriteLine(DateTime.Now);
                Console.WriteLine("Pick a number");
                int Number = Convert.ToInt32(Console.ReadLine());
                var Date1 = DateTime.Now;// creating a var that holds DateTime.Now
                var future = Date1.AddHours(Number);
                Console.WriteLine(future);
            }
        }
    }
}

