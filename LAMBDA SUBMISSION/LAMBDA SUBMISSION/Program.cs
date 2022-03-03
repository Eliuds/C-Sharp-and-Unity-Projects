using System;
using System.Collections.Generic;

namespace LAMBDA_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            employee emps = new employee();
            emps.FirstName = new List<string>() { "Joe", "chris", "joseph", "yilmar","olenis", "Joe", "David", "Pablo", "Robert", "Anto"};
            emps.LastName = new List<string>() { "Mama", "pablo", "evans", "Valle", "roman" , "Brown", "Santiago", "Hernandaz", "wlal", "Esco"};
            emps.ID = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (employee name in emps.FirstName)
            {
                
            }

            {

            }
        }
    }
}
