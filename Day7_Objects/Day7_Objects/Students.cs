using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_Objects
{
    class Students
    {
        public String name {get; set;}
        public String surname { get; set; }
        private int _year;
        public int year { get; set; }
       



        public void printInfo()
        {
            Console.WriteLine(name + " " + surname + " " + year);
        }
        public Students(String name, String surname, int year)
        {
            this.name = name;
            this.surname = surname;
            this.year = year;
        }

    }
}
