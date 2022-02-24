using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACT_CLASS
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        
        public void Quit()
        {
            Console.WriteLine("You wanna quit?");
        }
    }
}
