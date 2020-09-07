using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Day6_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task2();

            Students student1 = new Students();
            Console.WriteLine("Enter student name");
            student1.name = Console.ReadLine();
            Console.WriteLine("Enter student surname");
            student1.surname = Console.ReadLine();
            Console.WriteLine("Enter student year");
            try
            {
                student1.year = Convert.ToInt32(Console.ReadLine());
                if (student1.year>3)
                { student1.year = 3; }
                else if (student1.year<1)
                { student1.year = 1; }

            }
            catch
            {
                Console.WriteLine("Nepareiza ievade!");
                
            }
            student1.printInfo();




        }
        static void Task2()
        {
            List<String> lst = new List<String>();

            String choice = " ";

            while (choice != "0")
            {
                Console.WriteLine("1- Izvadit");
                Console.WriteLine("2- Pievienot");
                Console.WriteLine("0- Iziet");
                Console.WriteLine("3- izdzēst elementu");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PrintLst(lst);
                        break;
                    case "2":
                        AddElement(lst);
                        break;
                    case "0":
                        break;
                    case "3":
                        DeleteElement(lst);
                        break;

                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }


        private static void DeleteElement(List<string> lst)
        {
            Console.WriteLine("Ievadiet pozīciju, kuru gribat izdzēst!");

            try
            {
                int pos = Convert.ToInt32(Console.ReadLine());
                lst.RemoveAt(pos);
            }
            catch
            {
                Console.WriteLine("Nepareiza pozīcija!");
                DeleteElement(lst);
            }

        }

        private static void AddElement(List<string> lst)
        {
            Console.WriteLine();
            Console.WriteLine("Ievadiet elementu!");
            lst.Add(Console.ReadLine());
            Console.WriteLine();
        }

        private static void PrintLst(List<string> lst)
        {
            Console.WriteLine();

            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(i + ": " + lst[i]);
            }
            Console.WriteLine();
        }
    }
}
