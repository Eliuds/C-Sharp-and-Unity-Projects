using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS_SUBMISSION_ASSIGNMENT
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to use in this program?");
            int number = Convert.ToInt32(Console.ReadLine());

            Methods obj1 = new Methods();


            int result = obj1.Method(number);
            Console.WriteLine("The result of the method is: " + result);

            int result1 = obj1.Method2(number);
            Console.WriteLine("The result of the method is: " + result1);

            int result2 = obj1.Method3(number);
            Console.WriteLine("The result of the method is: " + result2);



        }
    }
}
