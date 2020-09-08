using System;
using System.Collections.Generic;
using System.Text;

namespace Day7_Objects
{
    class Students
    {
        public String Name {get; set;}
        public String Surname { get; set; }
        
        private int _course;

        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                if (value >= 1 && value <= 3)
                {
                    _course = value;
                }
                else if (value > 3)
                {
                    _course = 3;
                }
                else
                {
                    _course = 1;
                }
            }
        }



                public void printInfo()
                {
                    Console.WriteLine(Name + " " + Surname + " " + Course);
                }
                public Students(String name, String surname, int course)
                {
                    Name = name;
                    Surname = surname;
                    Course = course;
                    
                }
            
        
    }
}
