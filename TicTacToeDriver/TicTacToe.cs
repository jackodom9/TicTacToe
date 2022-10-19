using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeDriver
{
    
    internal class TicTacToe
    {
        public bool player1;
        public bool gameOver;
        public string[,] t3arr;
        public TicTacToe()
        {
            player1 = true;
            gameOver = false;
            t3arr = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    t3arr[i, j] = "-";
                }
            }
        }
        public bool makeMove(int row, int col)
        {
            if (!gameOver && t3arr[row, col] == "-")
            {
                if (player1)
                {
                    t3arr[row, col] = "X";
                }
                else
                {
                    t3arr[row, col] = "O";
                }
                player1 = !player1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string winCheck()
        {
            // check rows for victory game state
            for (int row = 0; row < 3; row++)
            {
                if (t3arr[row, 0] == t3arr[row, 1] && t3arr[row, 1] == t3arr[row, 2])
                {
                    if (t3arr[row, 0] == "X")
                    {
                        return "X";
                    }
                    else if (t3arr[row, 0] == "O")
                    {
                        return "O";
                    }
                }
            }
            // check columns for victory game state
            for (int col = 0; col < 3; col++)
            {
                if (t3arr[0, col] == t3arr[1, col] && t3arr[1, col] == t3arr[2, col])
                {
                    if (t3arr[0, col] == "X")
                    {
                        return "X";
                    }
                    else if (t3arr[0, col] == "O")
                    {
                        return "O";
                    }
                }
            }
            // check diagonals for victory game state
            if (t3arr[0, 0] == t3arr[1, 1] && t3arr[1, 1] == t3arr[2, 2])
            {
                if (t3arr[0, 0] == "X")
                {
                    return "X";
                }
                else if (t3arr[0, 0] == "O")
                {
                    return "O";
                }
            }
            if (t3arr[0, 2] == t3arr[1, 1] && t3arr[1, 1] == t3arr[2, 0])
            {
                if (t3arr[1, 1] == "X")
                {
                    return "X";
                }
                else if (t3arr[1, 1] == "O")
                {
                    return "O";
                }
            }
            // check for remaining moves
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (t3arr[i, j] == "-")
                    {
                        return "-";
                    }
                }
            }
            // If draw;
            return "/";
        }
    }
}

        
