using System;
using System.Collections.Generic;

namespace CONSOLE_APP_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringarray = new string[] { "anto", "nuny", "jay", "yilmar" };
            Console.WriteLine("Write something that will go to the end of every name.");
            string user =Console.ReadLine();// this is getting a string input from the users
            for (int j = 0; j < stringarray.Length; j++)
            {
                stringarray[j] += user;
                Console.WriteLine(stringarray[j]);
            }
           
           
         



            Console.ReadLine();


        }
    }
}
