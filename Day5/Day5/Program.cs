using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*   double a = getDouble(1);

               double b = getDouble(2);
               Console.WriteLine("Izvēlies darbību - Saskaitīt (+), Atņemt (-), Reizināt (*) vai dalīt (/)");
               string darb = Console.ReadLine();

               if (darb == "+")
               {
                   Console.WriteLine(Darbības.saskaitīšana(a, b));
               }
               else if (darb == "-")
               {
                   Console.WriteLine(Darbības.atņemšana(a, b));
               }
               else if (darb == "*")
               {
                   Console.WriteLine(Darbības.reizināšana(a, b));
               }
               else if (darb == "/")
               {
                   Console.WriteLine(Darbības.dalīšana(a, b));
               }
               else
               {
                   Console.WriteLine("Nepareiza ievade!");
               }*/

            // task 2 starts here
            List <String> lst = new List<String>();
            string choice = "";
            while (choice !="exit")
            {
                Console.WriteLine("Izvēlies darbību : add, print vai exit");
                 choice = Console.ReadLine();
                if (choice == "add")
                { Console.WriteLine("Pievieno stringu :");
                    lst.Add(Console.ReadLine());
                }
                else if (choice == "print")
                {
                    if (lst.Count == 0)
                    {
                        Console.WriteLine("Saraksts ir tukšs!");
                    }
                    else
                    {
                        for (int i = 0; i < lst.Count; i++)
                        {
                            Console.WriteLine(lst[i]);
                        }
                    }
                }
                else if (choice == "exit") { break; }
                else { Console.WriteLine("nepareiza ievade"); }
                    
                }
            


        }
 /*       static double  getDouble(int number)
        {
            double result = 0;
            try
            {
                Console.WriteLine("Ievadi skaitli Nr"+number+":");
              result=  Convert.ToDouble(Console.ReadLine());
                
            }
            catch
            { getDouble(number); }
            return result;
        }*/
       
    }
}
