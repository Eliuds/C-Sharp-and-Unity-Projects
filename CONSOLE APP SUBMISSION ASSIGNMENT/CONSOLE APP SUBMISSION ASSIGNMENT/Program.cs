using System;
using System.Collections.Generic;

namespace CONSOLE_APP_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = new List<int>
            {
                2, 4, 8, 16, 32
            };
                Console.WriteLine("Pick a number to divide each number in the list by.");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the list...");
                foreach (int number in numbers)
                {
                    int result = number / number1;
                    Console.WriteLine(result);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("please dont divide by zero");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("the program has emerged from the try/catch block.");
             }
            Console.ReadLine();



        }
    }
}
