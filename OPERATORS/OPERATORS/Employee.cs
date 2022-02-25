using System;
using System.Collections.Generic;
using System.Text;

namespace OPERATORS
{
    class Employee
    {

        public int ID { get; set; }

        public static Employee operator ==(Employee employee)
        {
            return employee;

        }

        public static Employee operator !=(Employee employee)
        {
            return employee;
        }
    }
}
