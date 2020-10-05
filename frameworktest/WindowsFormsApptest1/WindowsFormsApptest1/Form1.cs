using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApptest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static List<int> player1Moves = new List<int> ();
        private static List<int> player2Moves = new List<int>();
        private static List<int> cpuMoves = new List<int>();
        string player = "player1";

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
           foreach (Control c in gameBoard.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.Enabled = true;

                }
            }
            ProgressLabel.Text = "Game in process!";
            player1Moves.Clear();
            cpuMoves.Clear();
        }


            private void btn1_1_Click(object sender, EventArgs e)
        {   
            if (player == "player1")
            {
                move(player, btn1_1, 1);
                checkWinner(player1Moves, cpuMoves);
                player = "cpu";
            }
            else if (player == "cpu")
            {
                move(player, btn1_1, 1);
                checkWinner(player1Moves, cpuMoves);
                player = "player1";
            }
           
        }
        private void btn1_2_Click(object sender, EventArgs e)
        {
            if (player == "player1")
            {
                move(player, btn1_2, 2);
                checkWinner(player1Moves, cpuMoves);
                player = "cpu";
            }
            else if (player == "cpu")
            {
                move(player, btn1_2, 2);
                checkWinner(player1Moves, cpuMoves);
                player = "player1";
            }
        }
        private void btn1_3_Click(object sender, EventArgs e)
        {
            if (player == "player1")
            {
                move(player, btn1_3, 3);
                checkWinner(player1Moves, cpuMoves);
                player = "cpu";
            }
            else if (player == "cpu")
            {
                move(player, btn1_3, 3);
                checkWinner(player1Moves, cpuMoves);
                player = "player1";
            }
        }
        private void btn2_1_Click(object sender, EventArgs e)
        {
            if (player == "player1")
            {
                move(player, btn2_1, 4);
                checkWinner(player1Moves, cpuMoves);
                player = "cpu";
            }
            else if (player == "cpu")
            {
                move(player, btn2_1, 4);
                checkWinner(player1Moves, cpuMoves);
                player = "player1";
            }
        }
        private void btn2_2_Click(object sender, EventArgs e)
        {
            if (player == "player1")
            {
                move(player, btn2_2, 5);
                checkWinner(player1Moves, cpuMoves);
                player = "cpu";
            }
            else if (player == "cpu")
            {
                move(player, btn2_2, 5);
                checkWinner(player1Moves, cpuMoves);
                player = "player1";
            }
        }
        private void btn2_3_Click(object sender, EventArgs e)
        {
            if (player == "player1")
            {
                move(player, btn2_3, 6);
                checkWinner(player1Moves, cpuMoves);
                player = "cpu";
            }
            else if (player == "cpu")
            {
                move(player, btn2_3, 6);
                checkWinner(player1Moves, cpuMoves);
                player = "player1";
            }
        }
        private void btn3_1_Click(object sender, EventArgs e)
        {
            if (player == "player1")
            {
                move(player, btn3_1, 7);
                checkWinner(player1Moves, cpuMoves);
                player = "cpu";
            }
            else if (player == "cpu")
            {
                move(player, btn3_1, 7);
                checkWinner(player1Moves, cpuMoves);
                player = "player1";
            }
        }
        private void btn3_2_Click(object sender, EventArgs e)
        {
            if (player == "player1")
            {
                move(player, btn3_2, 8);
                checkWinner(player1Moves, cpuMoves);
                player = "cpu";
            }
            else if (player == "cpu")
            {
                move(player, btn3_2, 8);
                checkWinner(player1Moves, cpuMoves);
                player = "player1";
            }
        }
        private void btn3_3_Click(object sender, EventArgs e)
        {
            if (player == "player1")
            {
                move(player, btn3_3, 9);
                checkWinner(player1Moves, cpuMoves);
                player = "cpu";
            }
            else if (player == "cpu")
            {
                move(player, btn3_3, 9);
                checkWinner(player1Moves, cpuMoves);
                player = "player1";
            }
        }
        private void move (string player, Button buttonName, int movePosition)
        { String symbol = "X";
            if (player == "player1")
            {
                symbol = "X";
                buttonName.Text = symbol;
                buttonName.Enabled = false;
                switch (movePosition)
                {
                    case 1: player1Moves.Add(1);
                        break;
                    case 2:
                        player1Moves.Add(2);
                        break;
                    case 3:
                        player1Moves.Add(3);
                        break;
                    case 4:
                        player1Moves.Add(4);
                        break;
                    case 5:
                        player1Moves.Add(5);
                        break;
                    case 6:
                        player1Moves.Add(6);
                        break;
                    case 7:
                        player1Moves.Add(7);
                        break;
                    case 8:
                        player1Moves.Add(8);
                        break;
                    case 9:
                        player1Moves.Add(9);
                        break;
                }
                symbol = "O";
                
               
            }
            else if (player == "cpu")
            {
                symbol = "O";
                buttonName.Text = symbol;
                buttonName.Enabled = false;
                switch (movePosition)
                {
                    case 1:
                        cpuMoves.Add(1);
                        break;
                    case 2:
                        cpuMoves.Add(2);
                        break;
                    case 3:
                        cpuMoves.Add(3);
                        break;
                    case 4:
                        cpuMoves.Add(4);
                        break;
                    case 5:
                        cpuMoves.Add(5);
                        break;
                    case 6:
                        cpuMoves.Add(6);
                        break;
                    case 7:
                        cpuMoves.Add(7);
                        break;
                    case 8:
                        cpuMoves.Add(8);
                        break;
                    case 9:
                        cpuMoves.Add(9);
                        break;
                }
                symbol = "X";
            }
        }
        private void checkWinner (List<int> player1Moves, List<int> cpuMoves)
        { 
            if (player1Moves.Contains(1) && player1Moves.Contains(2) && player1Moves.Contains(3) && btn1_1.Text == "X")
            {
                ProgressLabel.Text = "Player X wins";
            }
            else if (player1Moves.Contains(4) && player1Moves.Contains(5) && player1Moves.Contains(6) && btn2_1.Text == "X")
            {
                ProgressLabel.Text = "Player X wins";
            }
            else if (player1Moves.Contains(7) && player1Moves.Contains(8) && player1Moves.Contains(9) && btn3_1.Text == "X")
            {
                ProgressLabel.Text = "Player X wins";
            }
            else if (player1Moves.Contains(1) && player1Moves.Contains(4) && player1Moves.Contains(7) && btn1_1.Text == "X")
            {
                ProgressLabel.Text = "Player X wins";
            }
            else if (player1Moves.Contains(2) && player1Moves.Contains(5) && player1Moves.Contains(8) && btn1_2.Text == "X")
            {
                ProgressLabel.Text = "Player X wins";
            }
            else if (player1Moves.Contains(3) && player1Moves.Contains(6) && player1Moves.Contains(9) && btn1_3.Text == "X")
            {
                ProgressLabel.Text = "Player X wins";
            }
            else if (player1Moves.Contains(1) && player1Moves.Contains(5) && player1Moves.Contains(9) && btn1_1.Text == "X")
            {
                ProgressLabel.Text = "Player X wins";
            }
            else if (player1Moves.Contains(3) && player1Moves.Contains(5) && player1Moves.Contains(7) && btn1_3.Text == "X")
            {
                ProgressLabel.Text = "Player X wins";
            }
            else if (cpuMoves.Contains(1) && player1Moves.Contains(2) && player1Moves.Contains(3) && btn1_1.Text == "O")
            {
                ProgressLabel.Text = "Player O wins";
            }
            else if (cpuMoves.Contains(4) && player1Moves.Contains(5) && player1Moves.Contains(6) && btn2_1.Text == "O")
            {
                ProgressLabel.Text = "Player O wins";
            }
            else if (cpuMoves.Contains(7) && player1Moves.Contains(8) && player1Moves.Contains(9) && btn3_1.Text == "O")
            {
                ProgressLabel.Text = "Player O wins";
            }
            else if (cpuMoves.Contains(1) && player1Moves.Contains(4) && player1Moves.Contains(7) && btn1_1.Text == "O")
            {
                ProgressLabel.Text = "Player O wins";
            }
            else if (cpuMoves.Contains(2) && player1Moves.Contains(5) && player1Moves.Contains(8) && btn1_2.Text == "O")
            {
                ProgressLabel.Text = "Player O wins";
            }
            else if (cpuMoves.Contains(3) && player1Moves.Contains(6) && player1Moves.Contains(9) && btn1_3.Text == "O")
            {
                ProgressLabel.Text = "Player O wins";
            }
            else if (cpuMoves.Contains(1) && player1Moves.Contains(5) && player1Moves.Contains(9) && btn1_1.Text == "O")
            {
                ProgressLabel.Text = "Player O wins";
            }
            else if (cpuMoves.Contains(3) && player1Moves.Contains(5) && player1Moves.Contains(7) && btn1_3.Text == "O")
            {
                ProgressLabel.Text = "Player O wins";
            }
            else if (player1Moves.Count+cpuMoves.Count == 9)
            {
                ProgressLabel.Text = "TIE";
            }
            else
            {
                ProgressLabel.Text = "Game in process!";
            }

        }
        

        
    }
}
