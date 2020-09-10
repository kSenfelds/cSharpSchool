using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe
{
    class Board
    {
      public static  List<int> playerMoves = new List<int>();
      public static  List<int> cpuMoves = new List<int>();
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
        public static void startGame ()
        {
            int playerCounter = 0;
            int cpuCounter = 0;
            string symbol = "X";
            while (true)
            {
            
                    Console.WriteLine("Player move - (1-9)");
                playerCounter = Convert.ToInt32(Console.ReadLine());
                playerMoves.Add(playerCounter);
                switch (playerCounter)
                {
                    case 1:
                        board[0, 0] = symbol;
                        break;

                }
                Console.WriteLine("CPU move - (1-9)");
                cpuMoves.Add(Convert.ToInt32(Console.ReadLine()));


            }
        }

    }
}
