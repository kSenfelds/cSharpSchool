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
            int linecounter = 0;
            List<int> lst = new List<int>();
            try
            {
                StreamReader sr = new StreamReader("Test.txt");
                
                string line = sr.ReadLine();
                while (line != null)
                {

                    try { lst.Add(Convert.ToInt32(line)); }
                    catch { Console.WriteLine("Tika izdzēsta rindiņa Nr. " + linecounter+1); }
                    linecounter++;
                    line = sr.ReadLine();
                    
                }
                sr.Close();

            }
            catch
            {
                
                Console.WriteLine("Nevar nolasīt failu ");
              
                
            }
            return lst;
        }
        
    }
}
