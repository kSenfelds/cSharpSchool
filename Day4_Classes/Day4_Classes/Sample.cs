using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Classes
{
    class Sample
    {
        //private un public
       
        public static void TestPrint()
        {
            Console.WriteLine("Hello world");
            PrivatePrint();
        }
        private static void PrivatePrint()
        {
            Console.WriteLine("Šo visi neredz");
        }
    }
}
