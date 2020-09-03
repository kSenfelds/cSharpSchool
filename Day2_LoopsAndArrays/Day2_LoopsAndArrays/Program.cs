using System;
using System.Data;

namespace Day2_LoopsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // getHighest();
            //  printstarsExtra();
            //  printstars();
            Task03();
        }
        static void getHighest()
        {
            int sk = Int32.MinValue;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ievadi Skaitli= ");
                int number = RandomGen();
                if (number > sk) { sk = number; }
            }
            Console.WriteLine("Lielākais skaitlis = " + sk);
        }
        static int RandomGen()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        static void printstarsExtra ()
        {
            String zvaigzne = "****";
            for (int i=0; i <4; i++ )
            {
                Console.WriteLine(zvaigzne.Substring(i));
                

            }
        }
        static void printstars() 
        {
            String starX = null;
            for (int i =0; i<4; i++)
            {
                String star = "*";
                starX =starX+star ;
                Console.WriteLine(starX);
            }
        }
        private static void ArraySample ()
        {
            int[] a = new int[5];
            a[0] = 4;
            //...
            a[4] = 3;

            for (int i=0; i<5; i++)
            {
                a[i] = 99;
            }
        }
        static void Task03 ()
        {
            int[] original = new int[5];
            for (int i = 0; i<original.Length; i++)
            {
                Console.WriteLine("Enter number!");
                original[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i =0; i<original.Length;i++)
            {
                Console.WriteLine("original Array Element Nr." + i + " =" + original[i]);
            }
            for (int i= original.Length-1; i>=0; i--)
            {
                Console.WriteLine("Element Nr." + i + " =" + original[i]);
            }
            int[] final = new int[original.Length+1];
            for (int i = 0; i < original.Length; i++)
            {
                final[i] = original[i];
            }
            Console.WriteLine("Enter number Nr. 6 :");
            final[5] = Convert.ToInt32(Console.ReadLine());
            for (int i =0; i<final.Length; i++)
            {
                Console.WriteLine("Final Array Elements Nr." + i + "=" + final[i]);
            }
            
        }

    }
}
