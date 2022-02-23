using System;

namespace METHODS_AND_OBJECTS_SUBMISSION_ASSIGNMENT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = new List<string>() { "Anto", "Nuny", "Yilmar" };
            employee.LastName = new List<string>() { "Escobar", "Roman", "Valle" };
            employee.FullName();
        }
    }
}
