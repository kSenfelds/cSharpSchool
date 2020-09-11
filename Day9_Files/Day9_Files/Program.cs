using System;
using System.Collections.Generic;

namespace Day9_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> lst = FileOperations.Read2("Test.txt");
            FileOperations.Write2("Test.txt", lst);
            FileOperations.Read("newTest.txt");
        }
    }
}
