using System;
using System.Collections.Generic;
using System.Text;

namespace Day6_Objects
{
    class Students
    {

        public String name;
        public String surname;
        private int _year;
        public int year { get; set; }
        
           
        
        public void printInfo()
        {
            Console.WriteLine(name + " " + surname + " " + year);
        }
    }
}
