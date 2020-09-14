using System;
using System.Collections.Generic;

namespace Day5_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();  
        }
       
        static void Task2()
        {
            List<String> lst = FileOperations.Read2();

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
                FileOperations.Write(lst);
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
            FileOperations.Write(lst);

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
