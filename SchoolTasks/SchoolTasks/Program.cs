using System;

namespace SchoolTasks
{
    class Program
    {
        static void Main(string[] args)
        {// int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
         //  string [] buzz = Fizzbuzz.makebuzz(num);
         //  PrintMassString(buzz);

            //   int[] sort0 = { 1, 2, 3, 4, 0, 2, 0, 5, 0, 3, 0, 2, 0 };
            //  int [] sorted= Sort0.sort0(sort0);
            //   PrintMassInt(sorted);
            string[] dubult = { "ABC", "CDE", "FGA", "CDE", "GAE", "ABC", "ABO" };
            string[] final = Sort0.Deletedouble(dubult);
            PrintMassString(final);

        }
        static void PrintMassString(string[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("[" + mas[i] + "]");
            }
        }
        static void PrintMassInt(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("[" + mas[i] + "]");
            }
        }
    }
}
