using System;
using System.Collections.Generic;
using System.Text;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT1
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
