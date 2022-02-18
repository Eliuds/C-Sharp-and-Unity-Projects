using System;
using System.Collections.Generic;
using System.Text;

namespace METHOD_SUBMISSION_ASSIGNMENT
{
    public class Methods
    {

        public int Method(int x, int y = 1)// to make it optional you have to give it a fallback number. If y is not given a number it will use that fallback number in this case 1.
        {
            return x + y;
        }

    }
}
