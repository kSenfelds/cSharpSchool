using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        public static char[,] board = 
        {
            {' ','|', ' ', '|', ' ' },
            {'-','+', '-', '+', '-' },
            {' ','|', ' ', '|', ' ' },
            {'-','+', '-', '+', '-' },
            {' ','|', ' ', '|', ' ' },

        };
        public static void printBoard()
        {

               for (int i= 0; i<board.GetLength(0); i++)
               {
                   for (int j =0; j<board.GetLength(1);i++)
                   {
                     Console.Write(board[i, j]); // Index out of bounds
                 }
                 Console.WriteLine();
               }
            
           
        }

    }
}
