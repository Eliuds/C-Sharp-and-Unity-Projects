﻿using System;

namespace MAIN_METHOD_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Methods obj1 = new Methods();


            int result = obj1.Method(10);
            Console.WriteLine("The result of the method is: " + result);

            

            decimal result2 = obj1.Method2(2.209m);
            Console.WriteLine("The result of the 2nd method is: " + result2);

            string result3 = obj1.Method3("132");
            Console.WriteLine("The result of the 3rd method is: " + result3);


        }
    }
}