using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int total = 5 + 10;
            //    int otherTotal = 12 + 22;
            //    int combined = total + otherTotal;
            //    Console.WriteLine(combined);
            //    Console.ReadLine();

            //int diff = 10 - 5;
            //Console.WriteLine("Ten minus five = " + diff.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrfalse = 12 > 5;
            //Console.WriteLine(trueOrfalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 70;

            ////bool isWarm = currentTemp >= roomTemp;
            //bool isWarm = currentTemp != roomTemp; // does currentTemp not equal to roomTemp ! = not
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            Console.WriteLine("Pick a number");
            string Number = Console.ReadLine();
            int Num = Convert.ToInt32(Number);
            int total = Num * 50;
            Console.WriteLine("Your chosen number times 50 is: " + total);
            Console.ReadLine();

            Console.WriteLine("Pick a number");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            int total2 = num2 + 25;
            Console.WriteLine("your chosen number plus 25 is: " + total2);
            Console.ReadLine();
        }
    }
}
