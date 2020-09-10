using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    class Taisnstūris
    {
       
        public int Garums {get; set;}
        public int Platums { get; set; }
        private int Laukums { get; set; }
        public Taisnstūris (int garums, int platums )
        {
            Garums = garums;
            Platums = platums;
            Laukums = garums * platums;
        }
        public void printLaukums()
        {
            Console.WriteLine(" "+Laukums);
        }
        
    }
}
