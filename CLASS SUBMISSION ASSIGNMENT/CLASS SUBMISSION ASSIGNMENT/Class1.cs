using System;
using System.Collections.Generic;
using System.Text;

namespace CLASS_SUBMISSION_ASSIGNMENT
{
    class Class1
    {
        public void Divide(int x)// this is the method
        {
            x = x / 2;
            Console.WriteLine(x);

        }

        public void Outint(out int x)
        {
            int temp = 2;
            x = temp;
        }

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static string PlusMethod(string x, string y)
        {
            return x + y;
        }

    }
}
