using System;
using System.Collections.Generic;

namespace CONSOLE_APP_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] stringarray = new string[] { "anto", "nuny", "jay", "yilmar" };
            //Console.WriteLine("Write something that will go to the end of every name.");
            //string user =Console.ReadLine();// this is getting a string input from the users
            //for (int j = 0; j < stringarray.Length; j++)
            //{
            //    stringarray[j] += user;
            //    Console.WriteLine(stringarray[j]);
            //}


            int count = 0;

            while (true)
            {
                Console.WriteLine("Count = {0}.", count);
                count++;

                

                if (count > 15)
                {
                    break;
                }

            }





           int stuff = 0;

            while (true)
            {
                Console.WriteLine("Count = {0}.", stuff);
                stuff++;


                if (stuff < 30)
                {
                    break;
                }

                if(stuff <= 25)
                {
                    break;
                }

            }


            Console.ReadLine();


        }
    }
}
