using System;

namespace Day1_io
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Task1();
            //   Task2();
            //  Sample2(1, 2);
            // int rez = Sample3();
            // Console.WriteLine(rez);
            //  Console.WriteLine(Sample3());
            // Task3003(3);
           Task3001(1);
           Console.WriteLine("Task3002 result = " + Task3002(2));
           Console.WriteLine("Task3004 result = " + Task3004(7,5));
           Task3003(3);
        }

        static void Task1()
        {
            Console.WriteLine("Enter number :");
            String input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            if (number > 5)
            {
                Console.WriteLine("**");
            }
            else
            {
                Console.WriteLine("*");
            }
        }
        static void Task2()
        {
            int summ = 0;
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Enter number Nr" + (i + 1) + ":");
                String input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                summ = number + summ;
            }
            Console.WriteLine("Summa = " + summ);

        }
        static void Sample()
        {
            Console.WriteLine("Hello World!");
            // int, string, double, float, boolean, char <- java tipi
            //bool <- atšķirība no java tipiem
            int a = 5;
            Console.WriteLine("Skaitlis ir " + a);

            String input = Console.ReadLine(); // <- ievade tikai String

            int number = Convert.ToInt32(input); // <-- jākonvertē, lai dabūtu int
        }
        static void Sample2(int number1, int number2)
        {
            Console.WriteLine("Summa ir :" + (number1 + number2));
        }
        static int Sample3()
        {
            return 5 + 4;
        }
        // Šeit sākas homework (task3)
        static void Task3001(int number)
        {
            if (number >= 0)
            {
                Console.WriteLine("Skaitlis ir pozitīvs !");
            }
            else
            {
                Console.WriteLine("Skaitlis ir negatīvs !");
            }
        }
        static bool Task3002(int number)
        {
            bool rez = false;
            if (number >= 0)
            {
                 rez = true;
            }

            return rez;
        }
        static void Task3003(int number)
        {
            int rezult = 0;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter number Nr." + (i + 1) + ":");
                String input = Console.ReadLine();
                int numberfromuser = Convert.ToInt32(input);
                rezult = rezult + numberfromuser;
            }
            Console.WriteLine("Summa ir " + rezult);
            
        }

        static int Task3004(int skaitlis, int pakāpe) 
            {
            int rezult = skaitlis;
            if (skaitlis<=0||pakāpe<=0) 
            {
                Console.WriteLine("Error nav pozitīvi skaitļi");
            }
            for (int i =1; i<pakāpe;i++)
            {
                rezult *= skaitlis;
            }
            return (rezult);
            }
    }
}
