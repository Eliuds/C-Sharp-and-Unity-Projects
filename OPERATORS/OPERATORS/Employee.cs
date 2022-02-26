using System;
using System.Collections.Generic;
using System.Text;

namespace OPERATORS
{
   public class Employee//<g>
    {
        // public List<g> things { get; set; }


        public int ID { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)// When comparing two things to see if its equal bool is used, need the two object that are being compared .
        {
            return emp1.ID == emp2.ID;// comparing emp1 and emp2 by ID to see if they are equal.

        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.ID != emp2.ID;// comparing emp1 and emp2 by ID to see if they are not equal.
        }
    }
}
