using System;
using System.Collections.Generic;

namespace Methods_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = new List<string>() { "Anto", "Nuny", "Yilmar" };
            employee.LastName = new List<string>() { "Escobar", "Roman", "Valle" };
            employee.FullName();
            Console.ReadLine();
        }
    }
}
