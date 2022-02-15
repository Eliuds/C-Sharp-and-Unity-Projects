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
            string user = Console.ReadLine();// this is getting a string input from the users
            for (int j = 0; j < stringarray.Length; j++)
            {
                stringarray[j] += user;
                Console.WriteLine(stringarray[j]);
            }


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            // int count = 0;

            // while (true)
            // {
            //     Console.WriteLine("Count = {0}.", count);
            //     count++;



            //     if (count > 15)
            //     {
            //         break;
            //     }

            // }





            //int stuff = 0;

            // while (true)
            // {
            //     Console.WriteLine("Count = {0}.", stuff);
            //     stuff++;


            //     if (stuff < 30)
            //     {
            //         break;
            //     }

            //     if(stuff <= 25)
            //     {
            //         break;
            //     }

            // }


            List<string> numbers = new List<string>()
            {
                "one", "two", "three", "four"
            };
            Console.WriteLine("Give me a number spelled out.");
            string user1 = Console.ReadLine();
            if (numbers.Contains(user1))
            {


                for (int i = 0; i < numbers.Count; i++)
                {
                    if (user1 == numbers[i])
                    {
                        Console.WriteLine("Users choice is at index " + i);
                        break;
                    }
                }
            }

            else
            {
                Console.WriteLine("Your choice is not in the list.");
            }

            List<string> words = new List<string>()
            {
                "Sloths", "Pokemon", "Spider-Man", "Sloths"
            };
            Console.WriteLine("Can you guess the words i put in here?");
            string user2 = Console.ReadLine();
            if (words.Contains(user2))
            {


                for (int i = 0; i < words.Count; i++)
                {
                    if (user2 == words[i])
                    {
                        Console.WriteLine("Users choice is at index " + i);

                    }
                }
            }

            else
            {
                Console.WriteLine(user2 + " is not in the list.");
            }


            List<string> animals = new List<string>()
            { 
                "Sloths", "Dogs", "Spiders", "Sloths"
            };

            List<string> track = new List<string>()// empty list to add what we have seen to
            {

            };
            
            foreach (string animal in animals)// running this for all animals in the original list
            {
                bool check = false;// setting check to false
                foreach (string item in track)//refering to the things in the 2nd list this would be skipped first time the code is ran cause there is nothing on this list once something is added it starts running it to see if what is being looked at is equal to a item on the 2nd list if its not it runs the else statement if it is it runs the if statements.
                {
                    if(item == animal)
                    {
                        check = true;
                    }

                }; 
                if(check == true)
                {
                    Console.WriteLine(animal + " has already been seen on the list.");
                }

                else
                {
                    Console.WriteLine(animal);
                    track.Add(animal);
                }
            } 



            


            Console.ReadLine();


        }
    }
}
