using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi skaitli Nr1:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ievadi skaitli Nr2:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Izvēlies darbību - Saskaitīt (+), Atņemt (-), Reizināt (*) vai dalīt (/)");
            string darb = Console.ReadLine();
            double result = 0;
            if (darb=="+")
            {
               result= Darbības.saskaitīšana(a, b);
            }
            else if (darb == "-")
            {
              result=  Darbības.atņemšana(a, b);
            }
            else if (darb == "*")
            {
              result =  Darbības.reizināšana(a, b);
            }
            else if (darb == "/")
            {
             result=   Darbības.dalīšana(a, b);
            }
            Console.WriteLine(result);
        }
    }
}
