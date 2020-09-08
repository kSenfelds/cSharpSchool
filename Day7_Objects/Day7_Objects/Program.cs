using System;

namespace Day7_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter student surname");
            String surname = Console.ReadLine();
            Console.WriteLine("Enter course");
            int year = Convert.ToInt32(Console.ReadLine());
            Students stud1 = new Students(name,surname,year);
            stud1.printInfo();
        }
    }
}
