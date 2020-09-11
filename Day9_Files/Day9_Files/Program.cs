using System;

namespace Day9_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileOperations.Write();
            FileOperations.Read(FileOperations.filename);
        }
    }
}
