using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SchoolTasks
{
    class Fizzbuzz
    {
        int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        string[] buzz = makebuzz(num); // kas par ?
        
        private static string[] makebuzz(int[] number)
        {
            string[] modifier = new string[number.Length];
            for (int i = 0; i < modifier.Length; i++)
            {
                if (number[i] % 3 != 0 || number[i] % 5 != 0)
                { modifier[i] = Convert.ToString(number[i]); }
                else if (number[i] % 3 == 0)
                {
                    modifier[i] = "fizz";
                }
                else if (number[i] % 5 == 0)
                {
                    modifier[i] = "BUZZ";
                }
                else if (number[i] % 3 == 0 && number[i] % 5 == 0)
                {
                    modifier[i] = "fizzBUZZ";
                }
            }
            return modifier;
        }
    }
     
     
}
