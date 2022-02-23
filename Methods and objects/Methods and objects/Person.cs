using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_and_objects
{
    class Person
    {
        public List<string> FirstName { get; set; }
        public List<string> LastName { get; set; }

        public void FullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
