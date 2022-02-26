using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACT_CLASS
{
    public abstract class Person
    {
        public List FirstName { get; set; }
        public string LastName { get; set; }
        public abstract void SayName();
        
           
        
    }
}
