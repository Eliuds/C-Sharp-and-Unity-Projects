using System;

namespace METHOD_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number.");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("optionally you can give me a 2nd number if not it will use the number 1.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Methods obj1 = new Methods();
            int result = obj1.Method(num, num2);
            Console.WriteLine("The result is " + result);
                

            
        }
    }
}
