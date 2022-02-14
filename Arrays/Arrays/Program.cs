using System.Collections.Generic;/// need to insert while having a list
using System;


namespace Arrays
{
    class Program
    {
        static void Main()
        {
            string[] stringarray = new string[] { "anto", "nuny", "jay", "yilmar" };// creating a array of strings.
            Console.WriteLine("pick a number between 0 and 3 to get a name.");// telling the user to pick between one of these numbers program wont work if they pick anything else.
            int index = Convert.ToInt32(Console.ReadLine()); // to get the user input
            for (int i = 0; i < stringarray.Length; i++)// this is saying as long as i is less then the length of the string array keep the program going in this case its 4 so you can only put up to 3, 0,1,2,3.
            {

                if (index == i)
                {
                    Console.WriteLine(stringarray[i]);
                }
                else
                {
                    Console.WriteLine("must be a number between 1 and 3");
                }


            }
            //foreach (var str in stringarray)
            //{
            //    Console.WriteLine(str);// another way to create the list
           //}


            int[] numArray = new int[] { 10, 32, 32, 45, 54, 65, 234 };// creating a array of numbers
            try// a try and catch method can be used like and if and else statment, if its not his then it would print out the error exception e.
            {
                Console.WriteLine("now pick a number between 0 and 6 to get a number");// asking user for number between 0 and 6 anything else and it wont work
                int index2 = Convert.ToInt32(Console.ReadLine());// to get user input
                Console.WriteLine(numArray[index2]);
               
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            List<string> stringList = new List<string>();// making a list of strings
            stringList.Add("Howdy");//adding the word howdy it now has the index value 0
            stringList.Add("Hello");//adding the word hello it now has the index value 1
            stringList.Add("Hi");//adding the word hi it now has the index value 2
            try
            {
                Console.WriteLine("Pick a number between 0 and 2 to get a greeting");// telling user to pick a number between 0 and 2, anthing else the program wont work
                int index3 = Convert.ToInt32(Console.ReadLine());// getting user input
                Console.WriteLine(stringList[index3]);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }



            //for (int y = 0; y < stringList.Count; y++)// the count pretty much means the same as length but its what is used for lists.
            //{

            //    if (index3 == y)
            //    {
            //        Console.WriteLine(stringList[y]);
            //    }


        }// can also use the try method used for the numarray for this it would be easier.
        
    }
}
            
         

