using System;

namespace STRINGS
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Anto";
            //string quote = "The man said,\"Hello\", Anto. \n Hello on a new line. \n \t Hello on a tab."; // The \ is used here to put quotes, \n to start a new line and \t to tab it on a new line.

            //bool trueOrFalse = name.Contains("n");// seeing if the string name has a n in it
            //trueOrFalse = name.EndsWith("o");// seeing if the string name ends with a o

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
