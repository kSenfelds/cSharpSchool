using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day9_Files
{
    class FileOperations
    {
        public static String filename;
        public static void Write(List<string> lst)
        {
            
            try
            {
                Console.WriteLine("Ievadiet faila nosaukumu :");
                filename = Console.ReadLine().Trim();
                StreamWriter sw = new StreamWriter(filename + ".txt",true);
                for (int i=0; i<lst.Count; i++)
                {
                    sw.WriteLine(lst[i]);
                    
                }
               

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
