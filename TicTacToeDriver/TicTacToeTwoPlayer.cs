using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeDriver.Properties;

namespace TicTacToeDriver
{
    public partial class TicTacToeTwoPlayer : Form
    {
        TicTacToe game = new TicTacToe();



        public TicTacToeTwoPlayer()
        {
            InitializeComponent();
            
        }

        private void topLeftBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 0, 0);
        }

        private void topMidBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 0, 1);
        }

        private void topRightBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 0, 2);
        }

        private void midLeftBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 1, 0);
        }

        private void midBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 1, 1);
        }

        private void midRightBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 1, 2);
        }

        private void botLeftBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 2, 0);
        }

        private void botMidBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 2, 1);
        }

        private void botRightBtn_Click(object sender, EventArgs e)
        {
            btnClickGeneric(sender, e, 2, 2);
        }

        private void TicTacToeTwoPlayer_Load(object sender, EventArgs e)
        {
            
        }
        private void winLine(int[] winner)
        {
            MessageBox.Show("Congratulations!");
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
            int[] winner = game.winCheck();
            // either row win or diagonal win
            if (winner[0] != -1 || winner[1] != -1)
            {
                winLine(winner);
            }
        }
    }
}
