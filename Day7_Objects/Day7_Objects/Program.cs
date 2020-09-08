using System;
using System.Collections.Generic;

namespace Day7_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> lstOfStudents = new List<Students>();
            string choice = "";
           while (choice!="0") 
            {
                Console.WriteLine("1- Add student");
                Console.WriteLine("2- Print list of students");
                Console.WriteLine("0- Exit");
                Console.WriteLine();
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter lastname");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Enter course");
                        int year = Convert.ToInt32(Console.ReadLine());
                        lstOfStudents.Add(new Students(name, lastname, year));
                        break;
                    case "2":
                        if (lstOfStudents.Count == 0) 
                        {
                            Console.WriteLine("List is empty");
                            
                        }
                        else
                        {
                            for (int i =0;i<lstOfStudents.Count;i++)
                            {
                                lstOfStudents[i].printInfo();
                                Console.WriteLine();
                            }
                        }
                        break;
                }

            }
        }
    }
}
