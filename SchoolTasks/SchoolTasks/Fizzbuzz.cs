using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SchoolTasks
{
    class Fizzbuzz
    {
       
       
        
        public static string[] makebuzz(int[] number)
        {
            string[] modifier = new string[number.Length];
            for (int i = 0; i < modifier.Length; i++)
            {
                
                 if (number[i] % 3 == 0 && number[i] % 5 == 0)
                {
                    modifier[i] = "fizzBUZZ";
                }
                else if (number[i] % 5 == 0)
                {
                    modifier[i] = "BUZZ";
                }
                else if (number[i]% 3 ==0)
                {
                    modifier[i] = "fizz";
                }
                 else
                {
                    modifier[i] = Convert.ToString(number[i]);
                }
            }
            return modifier;
        }
    }
     
     
}
