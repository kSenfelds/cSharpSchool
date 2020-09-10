using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Task1();
            List<int> lst1 = new List<int>();
            List<int> lst2 = new List<int>();

            lst1.Add(1);
            lst2.Add(2);
            lst1.Add(3);
            lst2.Add(4);
            lst2.Add(1);
           List<int> final = atgriez(lst1, lst2);
            for (int i=0;i<final.Count;i++)
            {
                Console.WriteLine(final[i]);
            }

        }
        static List<int> atgriez(List<int> lst1, List<int> lst2)
        {
            List<int> lst3 = new List<int>();
            for (int i = 0; i < lst1.Count; i++)
            {
                for (int j = 0; j < lst2.Count; j++)
                {
                    if (lst1[i] == lst2[j])
                    {
                        lst3.Add(lst1[i]);
                    }
                }
            }
            return lst3;
        }
        static void Task1()
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
                if (garums == -1 || platums == -1)
                { Console.WriteLine("figūra Nr." + i + "netika pievienota!"); }
                else { lst.Add(new Taisnstūris(garums, platums)); }



            }
            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write("Figūras Nr." + (i + 1) + "laukums =");
                lst[i].printLaukums();
            }
        }
    }
}
