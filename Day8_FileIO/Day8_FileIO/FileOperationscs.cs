using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day8_FileIO
{
    class FileOperationscs
    {
      public static void ReadFile()
        {
            try 
            {
                StreamReader sr = new StreamReader();
                string line = sr.ReadLine();
                Console.WriteLine(line);
                sr.Close();
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
            
        }

    }
}
