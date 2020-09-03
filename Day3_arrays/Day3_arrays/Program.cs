using System;

namespace Day3_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int [] arr= arrLength(10);
            //  PrintArr(arr);
            //  ClearArr(arr);
            //  PrintArr(arr);
            string[] kkk = { "kk", "iiii", "kkk","asjfbbweugb" };
            Console.Write("Summ of characters in kkk[] = " + charSumm(kkk));
            Console.WriteLine();
            int[] arr = arrLength(4);
            PrintArr(arr);
            arrSort(arr);
            PrintArr(arr);
        }
        // task 1 starts here
        static int [] arrLength(int number)
        {
            int[] arr = new int[number];
            Random rand = new Random();
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(101);
            }
            return arr;
        }
        static void PrintArr (int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
        static void ClearArr (int [] arr)
        {
            for (int i =0; i<arr.Length; i++)
            {
                if (arr[i]>50)
                {
                    arr[i] = 0;
                }
            }
        }
        // task 2 starts here
        static int  charSumm (string [] arr)
        {
            int sum = 0;
            for (int i =0;i<arr.Length;i++)
            {
                sum = Convert.ToInt32(arr[i].Length)+sum;
            }
            return sum;
        }
        // task 2 extra starts here
        static void arrSort (int [] numbers)
        { int temp = 0;
            for (int i =0; i<numbers.Length; i++)
            {
                for (int j =1; j<numbers.Length; j++)
                {
                    if (numbers[j-1]>numbers[j])
                    {
                        temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }
    }
}
