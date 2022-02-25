using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORS
{
    class Program
    {
       public static void Main(string[] args)
        {
            //Employee emp1 = new Employee();//Made the first object and named it emp1 while giving it the ID the value of 1
            //emp1.ID = 1;

            //Employee emp2 = new Employee();// Made the 2nd object named it emp2 and gave it the id value 2.
            //emp2.ID = 2;
            //Console.WriteLine("Are the 2 employees the same?");
            //Console.WriteLine(emp1 == emp2);
            //Console.WriteLine("Are the 2 emplyees different?");
            //Console.WriteLine(emp2 != emp1);

            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>() { "Stuff", "Things", "more stuff" };

            Employee<int> employee1 = new Employee<int>();
            employee1.things = new List<int>() { 1, 2, 3 };

            foreach ( things thing in employee.things)
            {

            }

            Console.ReadLine();
        }
    }
}
