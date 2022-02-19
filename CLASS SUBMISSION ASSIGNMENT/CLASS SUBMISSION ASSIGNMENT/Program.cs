using System;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number to divide by 2.");
            int user = Convert.ToInt32(Console.ReadLine());
            Class1 obj1 = new Class1();
            obj1.Divide(user);
        }
    }
}
