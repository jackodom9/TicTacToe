using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeDriver.Properties;

namespace TicTacToeDriver
{
    public partial class TicTacToeAI : Form
    {
        TicTacToe game = new TicTacToe();
        public bool selectedPlayer1;
        string player;
        string AI;
        Random rnd = new Random();
        int difficulty;
        public TicTacToeAI(string playerSide, int difficultyIn)
        {
            InitializeComponent();
            difficulty = difficultyIn;
            if (playerSide == "X")
            {
                selectedPlayer1 = true;
                player = "X";
                AI = "O";

            }
            else
            {
                selectedPlayer1 = false;
                player = "O";
                AI = "X";
            }
        }

        private void topLeftBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 0, 0);
            if (AI == "O" && game.player1 == false && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);
                
            }
            else if (AI == "X" && game.player1 == true && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);
            }
        }

        private void topMidBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 0, 1);
            if (AI == "O" && game.player1 == false && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);


            }
            else if (AI == "X" && game.player1 == true && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);
            }
        }

        private void topRightBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 0, 2);
            if (AI == "O" && game.player1 == false && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);


            }
            else if (AI == "X" && game.player1 == true && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);
            }
        }

        private void midLeftBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 1, 0);
            if (AI == "O" && game.player1 == false && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);


            }
            else if (AI == "X" && game.player1 == true && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);
            }
        }

        private void midBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 1, 1);
            if (AI == "O" && game.player1 == false && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);


            }
            else if (AI == "X" && game.player1 == true && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);
            }
        }

        private void midRightBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 1, 2);
            if (AI == "O" && game.player1 == false && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);


            }
            else if (AI == "X" && game.player1 == true && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);
            }
        }

        private void botLeftBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 2, 0);
            if (AI == "O" && game.player1 == false && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);


            }
            else if (AI == "X" && game.player1 == true && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);
            }
        }

        private void botMidBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 2, 1);
            if (AI == "O" && game.player1 == false && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);


            }
            else if (AI == "X" && game.player1 == true && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);
            }
        }

        private void botRightBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 2, 2);
            if (AI == "O" && game.player1 == false && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);


            }
            else if (AI == "X" && game.player1 == true && game.gameOver == false)
            {
                int[] AImove = findAIMove(game.t3arr);
                makeAIMove(AImove[0], AImove[1]);
            }
        }

        private void btnClickGeneric(object sender, EventArgs e, int row, int col)
        {

                bool moveSuccess = game.makeMove(row, col);
                Button btn = sender as Button;
                if (moveSuccess)
                {
                    // change image of button to 
                    if (game.player1)
                    {
                        btn.Image = Resources.icons8_o_100;
                    }
                    else
                    {
                        btn.Image = Resources.icons8_x_100;
                    }
                }
                string winner = game.winCheck();
                // either row win or diagonal win
                if (winner != "-")
                {
                    if (winner == "X")
                    {
                        MessageBox.Show("X Wins!");
                        this.Close();
                    }

                    if (winner == "O")
                    {
                        MessageBox.Show("O Wins!");
                    this.Close();
                    }
                    if (winner == "/")
                {
                    MessageBox.Show("Draw!");
                    game.gameOver = true;
                    this.Close();
                }

            }
        }

        private bool movesRemaining()
        {
            for (int i = 0; i <  3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (game.t3arr[i, j] == "-")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private int heuristic(string[,] board)
        {
            // check rows for victory game state
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                {
                    if (board[row, 0] == AI)
                    {
                        return 1;
                    }
                    else if (board[row, 0] == player)
                    {
                        return -1;
                    }
                }
            }
            // check columns for victory game state
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == board[1, col] && board[1, col] == board[2, col])
                {
                    if (board[0, col] == AI)
                    {
                        return 1;
                    }
                    else if (board[0, col] == player)
                    {
                        return -1;
                    }
                }
            }
            // check diagonals for victory game state
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                if (board[0, 0] == AI)
                {
                    return 1;
                }
                else if (board[0, 0] == player) 
                {
                    return -1;
                }
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[1, 1] == AI)
                {
                    return 1;
                }
                else if (board[1, 1] == player)
                {
                    return -1;
                }
            }
            // If no winners return 0;
            return 0;
        }
        private int minimax(int depth, string[,] board, bool isMaximizer)
        {
            int value = heuristic(board);
            if (value == 1)
            {
                return 1;
            }
            if (value == -1)
            {
                return -1;
            }
            if (!movesRemaining())
            {
                return 0;
            }
            if (isMaximizer)
            {
                int bestState = -10;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == "-")
                        {
                            // make move
                            board[i, j] = AI;
                            // check best move recursively
                            bestState = Math.Max(bestState, minimax(depth + 1, board, !isMaximizer));
                            // undo move
                            board[i, j] = "-";
                        }
                    }
                }
                return bestState;
            }
            else
            {
                int bestState = 10;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == "-")
                        {
                            // make move
                            board[i, j] = player;
                            // check best move recursively
                            bestState = Math.Min(bestState, minimax(depth + 1, board, !isMaximizer));
                            // undo move
                            board[i, j] = "-";
                        }
                    }
                }
                return bestState;
            }
        }

        private int[] findAIMove(string[,] board)
        {
            int randMoveValue = rnd.Next(101);
            if (randMoveValue > difficulty)
            {
                return makeRandomMove(board);
            }
            else
            {
                int bestValue = -10;
                int[] move = { 0, 0 };
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == "-")
                        {
                            board[i, j] = AI;
                            int moveValue = minimax(0, board, false);
                            board[i, j] = "-";
                            if (moveValue > bestValue)
                            {
                                move[0] = i;
                                move[1] = j;
                                bestValue = moveValue;
                            }
                        }
                    }
                }
                return move;
            }
        }

        private void TicTacToeAI_Load(object sender, EventArgs e)
        {
            if (AI == "X")
            {
                topLeftBtn.PerformClick();
            }
        }

        private void makeAIMove(int row, int col)
        {
            switch(row)
            {
                case 0:
                    switch(col)
                    {
                        case 0:
                            topLeftBtn.PerformClick();
                            break;
                        case 1:
                            topMidBtn.PerformClick();
                            break;
                        case 2:
                            topRightBtn.PerformClick();
                            break;
                    }
                    break;
                case 1:
                    switch (col)
                    {
                        case 0:
                            midLeftBtn.PerformClick();
                            break;
                        case 1:
                            midBtn.PerformClick();
                            break;
                        case 2:
                            midRightBtn.PerformClick();
                            break;
                    }
                    break;
                case 2:
                    switch (col)
                    {
                        case 0:
                            botLeftBtn.PerformClick();
                            break;
                        case 1:
                            botMidBtn.PerformClick();
                            break;
                        case 2:
                            botRightBtn.PerformClick();
                            break;
                    }
                    break;
            }
        }

        private int[] makeRandomMove(string[,] board)
        {
            List<int[]> possibleMoves = new List<int[]>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "-")
                    {
                        int[] move = { i, j };
                        possibleMoves.Add(move);
                    }
                }
            }
            int randIndex = rnd.Next(possibleMoves.Count);
            return possibleMoves[randIndex];
        }
    }
}
