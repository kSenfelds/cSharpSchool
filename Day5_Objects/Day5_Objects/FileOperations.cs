using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day5_Objects
{
    class FileOperations
    {
        public static String filename;
        public static void Write(List<string> lst)
        {
            
            try
            {
                
                StreamWriter sw = new StreamWriter("Test.txt");
               
                for (int j = 0; j<lst.Count;j++)
                {
                    sw.WriteLine(lst[j]);
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
               
                StreamReader sr = new StreamReader(location);
                
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
        public static List<String> Read2()
        {
            List<String> lst = new List<String>();
            try
            {   
                StreamReader sr = new StreamReader("Test.txt" );
                
                String line = sr.ReadLine();
                while (line!=null)
                {
                    lst.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                
            }
            catch
            {
                Console.WriteLine("Error file not found!");
            }
            return lst;
        }
        public static void Write2 (string location, List<String> lst)
        {
            try
            {
                StreamWriter sw = new StreamWriter("new" + location , true);
                for (int i = lst.Count-1; i >-1; i--)
                {
                    sw.WriteLine(lst[i]);
                }
                sw.Close();
            }

            catch
            {
                Console.WriteLine("Error can't create file");
            }
        }
    }
}
