using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace SchoolTasks
{
    class Sort0
    {
        public static int [] sort0 (int [] numbers)
        { int temp = -1;
            for (int i =0;i<numbers.Length;i++)
            {
                for (int j =1; j<numbers.Length;j++)
                {
                    if (numbers[j-1]==0)
                    {
                         temp= numbers[j];
                         numbers[j]= numbers[j - 1];
                        numbers[j-1] = temp;
                    }
                }
               
            }
            return numbers;
        }
        public static string[] Deletedouble (string [] original)
        {
            string temp = "";
            int counter = original.Length;
           for (int i = 0; i<original.Length; i++)
            {
                for (int j=i+1;j<original.Length; j++)
                {
                    if (original[i]==original[j])
                    {
                        original[j] = temp;
                        counter -= 1;
                    }
                }
            }
           for (int i =0;i<original.Length;i++)
            {
                for (int j = 1; j < original.Length; j++)
                {
                    if (original[j - 1] == "")
                    {
                        temp = original[j];
                        original[j] = original[j - 1];
                        original[j - 1] = temp;
                    }
                }
            }
            string[] final = new string[counter];
            for (int i =0; i<final.Length; i++)
            {
                final[i] = original[i];
            }
            return final;
        }
        
    }
}
