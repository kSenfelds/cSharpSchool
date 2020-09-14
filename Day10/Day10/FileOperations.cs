using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day10
{
    class FileOperations
    {
        
        public static void Write(List<int> lst)
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
       
        public static List<int> Read()
        {
            List<int> lst = new List<int>();
            try
            {
                StreamReader sr = new StreamReader("Test.txt");

                string line = sr.ReadLine();
                while (line != null)
                {
                    lst.Add(Convert.ToInt32(line));
                    line = sr.ReadLine();
                }
                sr.Close();

            }
            catch
            {
                Console.WriteLine("Error Read file");
            }
            return lst;
        }
        
    }
}
