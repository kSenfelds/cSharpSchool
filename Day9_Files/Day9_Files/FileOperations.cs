using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day9_Files
{
    class FileOperations
    {
        public static String filename;
        public static void Write()
        {
            
            try
            {
                Console.WriteLine("Ievadiet faila nosaukumu :");
                filename = Console.ReadLine().Trim();
                StreamWriter sw = new StreamWriter(filename + ".txt");
                sw.WriteLine("Hello");
                sw.WriteLine("World!");

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
        public static void Read (string location)
        {
            try
            {
               
                StreamReader sr = new StreamReader(location+".txt");
                
                string line =sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasīt failu!");
            }
        }
    }
}
