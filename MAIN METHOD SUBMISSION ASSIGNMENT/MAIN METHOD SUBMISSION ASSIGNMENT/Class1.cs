using System;
using System.Collections.Generic;
using System.Text;

namespace MAIN_METHOD_SUBMISSION_ASSIGNMENT
{
    public class Methods
    {

        public int Method(int x)
        {
            return 10 + x;
        }

        public int Method2(decimal x)
        {
            return (int) (20 + x); // needed the int and parenthesis here to turn the decimal into a int.
        }

        public int Method3(string num)
        {
            int num2 = Convert.ToInt32(num);// num2 is num converted into a int
            return 12 * num2;
        }
    }
}
