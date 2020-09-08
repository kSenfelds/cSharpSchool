using System;

namespace TicTacToe
{
    class Board
    {
        public static string[,] board =
        {
            {" ","|", " ", "|"," " },
            {"-","+","-", "+","-" },
            {" ","|", " ", "|"," " },
            {"-","+","-", "+","-" },
           {" ","|", " ", "|"," " },

        };
        public static void printBoard()
        {

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]); // Index out of bounds
                }
                Console.WriteLine();
            }

        }

    }
}
