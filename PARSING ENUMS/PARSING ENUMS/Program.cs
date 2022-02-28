using System;

namespace PARSING_ENUMS
{
    class Program
    {
        public enum DaysOfTheWeek// enums limit the input from the user so you wont get errors
        {
            Monday,
            Tuesday,
            Wednsday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
           

            try
            {
        
        Console.WriteLine("Please enter the what day of the week it is.");
         string currentday = Console.ReadLine();
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), currentday);
            }               

            catch (Exception e)
            {
                Console.WriteLine("That is not a day of the week");
            }
        }
        
    }

}
