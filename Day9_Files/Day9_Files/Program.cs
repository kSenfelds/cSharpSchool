using System;
using System.Collections.Generic;

namespace Day9_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>() { "S", "T", "R", "I", "N", "G" };
            FileOperations.Write(lst);
            FileOperations.Read(FileOperations.filename);
        }
    }
}
