using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACT_CLASS
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        
        
    }
}
