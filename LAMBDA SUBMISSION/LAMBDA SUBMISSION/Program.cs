using System;
using System.Collections.Generic;

namespace LAMBDA_SUBMISSION
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<employee> emp = new List<employee>();

            employee emp1 = new employee(); //instantiate the object and assign values to properties
            emp1.FirstName = "Joe";
            emp1.LastName = "Wheeler";
            emp1.ID = 1;

            emp.Add(emp1); //add employee object to the list

            employee emp2 = new employee();
            emp2.FirstName = "Max";
            emp2.LastName = "Min";
            emp2.ID = 2;
            emp.Add(emp2);

            employee emp3 = new employee();
            emp3.FirstName = "Jay";
            emp3.LastName = "Yaj";
            emp3.ID = 3;
            emp.Add(emp3);

            employee emp4 = new employee();
            emp4.FirstName = "Joe";
            emp4.LastName = "Eoj";
            emp4.ID = 4;
            emp.Add(emp4);

            employee emp5 = new employee();
            emp5.FirstName = "Nuny";
            emp5.LastName = "Ynun";
            emp5.ID = 5;
            emp.Add(emp5);


            employee emp6 = new employee();
            emp6.FirstName = "Chris";
            emp6.LastName = "Sirhc";
            emp6.ID = 6;
            emp.Add(emp6);

            employee emp7 = new employee();
            emp7.FirstName = "Yilmar";
            emp7.LastName = "Ramliy";
            emp7.ID = 7;
            emp.Add(emp7);

            employee emp8 = new employee();
            emp8.FirstName = "David";
            emp8.LastName = "Divad";
            emp8.ID = 8;
            emp.Add(emp8);

            employee emp9 = new employee();
            emp9.FirstName = "Joseph";
            emp9.LastName = "Hpesoj";
            emp9.ID = 9;
            emp.Add(emp9);

            employee emp10 = new employee();
            emp10.FirstName = "Jayden";
            emp10.LastName = "Nedyaj";
            emp10.ID = 10;
            emp.Add(emp10);


            List<employee> Joes = new List<employee>();

            foreach (employee Joe in emp)
            {
                if (emp.FirstName == "Joe")
                {

                }
            }

            










        }
    }
}
