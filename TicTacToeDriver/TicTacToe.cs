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
            // check rows
            string winner = "-";
            int xCount = 0;
            int oCount = 0;
            for (int i = 0; i < 3; i++)
            {
                xCount = 0;
                oCount = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (t3arr[i,j] == "X")
                    {
                        xCount++;
                    }
                    if (t3arr[i,j] == "O")
                    {
                        oCount++;
                    }
                }
                if (xCount == 3)
                {
                    winner = "X";
                    gameOver = true;
                    return winner;
                }
                if (oCount == 3)
                {
                    winner = "O";
                    gameOver = true;
                    return winner;
                }
            }
            // check columns
            for (int i = 0; i < 3; i++)
            {
                xCount = 0;
                oCount = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (t3arr[j, i] == "X")
                    {
                        xCount++;
                    }
                    if (t3arr[j, i] == "O")
                    {
                        oCount++;
                    }
                }
                if (xCount == 3)
                {
                    winner = "X";
                    gameOver = true;
                    return winner;
                }
                if (oCount == 3)
                {
                    winner = "O";
                    gameOver = true;
                    return winner;
                }
            }
            // check diagonals
            xCount = 0;
            oCount = 0;
            for (int i = 0; i < 3; i++)
            {
                if (t3arr[i, i] == "X")
                {
                    xCount++;
                }
                if (t3arr[i, i] == "O")
                {
                    oCount++;
                }

            }
            if (xCount == 3)
            {
                winner = "X";
                gameOver = true;
                return winner;
            }
            if (oCount == 3)
            {
                winner = "O";
                gameOver = true;
                return winner;
            }

            xCount = 0;
            oCount = 0;
            for (int i = 0; i < 3; i++)
            {
                if (t3arr[i, 2 - i] == "X")
                {
                    xCount++;
                }
                if (t3arr[i, 2 - 1] == "O")
                {
                    oCount++;
                }
            }
            if (xCount == 3)
            {
                winner = "X";
                gameOver = true;
                return winner;
            }
            if (oCount == 3)
            {
                winner = "O";
                gameOver = true;
                return winner;
            }
            return winner;
        }
    }
}

        
