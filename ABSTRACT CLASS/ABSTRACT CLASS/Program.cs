using System;

namespace ABSTRACT_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {



            //IQuittable quittable = new Employee();
            //quittable.Quit();


            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            


            Console.ReadLine();
        }
    }
}
