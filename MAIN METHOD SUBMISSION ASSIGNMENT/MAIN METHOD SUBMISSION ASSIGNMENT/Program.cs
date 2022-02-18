using System;

namespace MAIN_METHOD_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Methods obj1 = new Methods();


            int result = obj1.Method(10);
            Console.WriteLine("The result of the method is: " + result);

            

            int result2 = obj1.Method2(2.209m);// decimals need to have the m at the end
            Console.WriteLine("The result of the 2nd method is: " + result2);

            int result3 = obj1.Method3("132");// need to write the number in "" cause it starts as a string.
            Console.WriteLine("The result of the 3rd method is: " + result3);


        }
    }
}
