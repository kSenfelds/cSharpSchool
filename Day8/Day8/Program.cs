using System;
using System.Collections.Generic;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<Taisnstūris> lst = new List<Taisnstūris>();
            int garums = -1;
            int platums = -1;
            int temp = -1;

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Ievadiet figūras Nr." + i + " garumu");
                try
                {
                    garums = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Nepareiza ievade");
                    garums = temp;

                }
                Console.WriteLine("Ievadiet figūras Nr." + i + " platumu");
                try
                {
                    platums = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Nepareiza ievade");
                    platums = temp;

                }
                if (garums==-1||platums==-1)
                { Console.WriteLine("figūra Nr." + i + "netika pievienota!"); }
                else { lst.Add(new Taisnstūris(garums, platums)); }
               


            }
            for (int i =0; i<lst.Count; i++)
            {
                Console.Write("Figūras Nr." + (i + 1) + "laukums =");
                lst[i].printLaukums();
            }
        }
    }
}
