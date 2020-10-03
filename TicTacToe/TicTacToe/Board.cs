using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
            
            string player = "player";
            while (true)
            { player = "player";
                gameProcess(player);
                player = "cpu";
                gameProcess(player);

            }
        }
        private static void gameProcess (string player)
        {
            int move = -1;
            string symbol = "X";
            if (player == "player")
            {
                symbol = "X";
                Console.WriteLine("Player move - (1-9)");
                try
                {
                    move = Convert.ToInt32(Console.ReadLine());
                    checkMove(move, player);
                    playerMoves.Add(move);
                    switch (move)
                    {
                        case 1:
                            board[0, 0] = symbol;
                            break;
                        case 2:
                            board[0, 2] = symbol;
                            break;
                        case 3:
                            board[0, 4] = symbol;
                            break;
                        case 4:
                            board[2, 0] = symbol;
                            break;
                        case 5:
                            board[2, 2] = symbol;
                            break;
                        case 6:
                            board[2, 4] = symbol;
                            break;
                        case 7:
                            board[4, 0] = symbol;
                            break;
                        case 8:
                            board[4, 2] = symbol;
                            break;
                        case 9:
                            board[4, 4] = symbol;
                            break;
                        default:
                            Console.WriteLine("Wrong input - move goes to opponent!");
                            break;
                    }
                    printBoard();
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Wrong input - move goes to opponent!");

                }
            }
            else if (player == "cpu")
            {
                symbol = "O";
                Random rand = new Random();
                move = rand.Next(10);
                checkMove(move, player);
                cpuMoves.Add(move);
                switch (move)
                {
                    case 1:
                        board[0, 0] = symbol;
                        break;
                    case 2:
                        board[0, 2] = symbol;
                        break;
                    case 3:
                        board[0, 4] = symbol;
                        break;
                    case 4:
                        board[2, 0] = symbol;
                        break;
                    case 5:
                        board[2, 2] = symbol;
                        break;
                    case 6:
                        board[2, 4] = symbol;
                        break;
                    case 7:
                        board[4, 0] = symbol;
                        break;
                    case 8:
                        board[4, 2] = symbol;
                        break;
                    case 9:
                        board[4, 4] = symbol;
                        break;

                }
                printBoard();
                Console.WriteLine("CPU MOVE!"+move);
                Console.WriteLine();
            }

        }
        private static void checkMove (int move, string player)
        {
            switch (player)
            {
                case "cpu": if (cpuMoves.Contains(move)||playerMoves.Contains(move))
                    {
                        gameProcess("cpu");
                    };
                    break;
                case "player" : if (cpuMoves.Contains(move) || playerMoves.Contains(move))
                    {
                        Console.WriteLine("Move unavailable ! Try again!");
                        gameProcess("player");
                    }
                    break;
            }   
        }

    }
}
