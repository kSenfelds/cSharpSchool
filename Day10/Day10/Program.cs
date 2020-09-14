using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }
        static void Task1()
        {
            List<int> lst = FileOperations.Read();

            String choice = " ";

            while (choice != "0")
            {
                Console.WriteLine("1- Pievienot");
                Console.WriteLine("2- Dzēst");
                Console.WriteLine("0- Iziet");
                Console.WriteLine("3- Saskaitīt visus skaitļus");
                Console.WriteLine("4 - izrēķināt vidējo aritmētisko");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddElement(lst);
                        break;
                    case "2":
                        DeleteElement(lst);
                        break;
                    case "0":
                        FileOperations.Write(lst);
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine(sumElements(lst));
                        Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine();
                        Console.WriteLine(averageSum(lst));
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }

            }
        }

        private static void AddElement(List<int> lst)
        {
            Console.WriteLine();
            Console.WriteLine("Ievadiet elementu!");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                lst.Add(number);
                FileOperations.Write(lst);
            }
            catch
            {
                Console.WriteLine("Nepareiza ievade elements netika pievienots");
            }
            

        }
        private static void DeleteElement(List<int> lst)
        {   
            if (lst.Count==0)
            {
                Console.WriteLine("Saraksts ir tukšs!");
                
            }
            else
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

        }
        private static double sumElements (List <int> lst)
        {
            int sumOfElements = 0;
            for (int i = 0; i<lst.Count; i++)
            {
                sumOfElements = sumOfElements + lst[i];
            }
            return sumOfElements;
        }
        private static double averageSum (List<int> lst)
        { 
            double average = (sumElements(lst)/ lst.Count);
            return average;
        }
        
        

    }
}
