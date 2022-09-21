using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            bool moveSuccess = game.makeMove(0, 0);
            if (moveSuccess)
            {
                // change image of button to 
                if (game.player1)
                {

                }
                else
                {

                }
            }
            int[] winner = game.winCheck();
            // either row win or diagonal win
            if (winner[0] != -1 || winner[1] != -1)
            {
                winLine(winner);
            }
        }

        private void topMidBtn_Click(object sender, EventArgs e)
        {

        }

        private void topRightBtn_Click(object sender, EventArgs e)
        {

        }

        private void midLeftBtn_Click(object sender, EventArgs e)
        {

        }

        private void midBtn_Click(object sender, EventArgs e)
        {

        }

        private void midRightBtn_Click(object sender, EventArgs e)
        {

        }

        private void botLeftBtn_Click(object sender, EventArgs e)
        {

        }

        private void botMidBtn_Click(object sender, EventArgs e)
        {

        }

        private void botRightBtn_Click(object sender, EventArgs e)
        {

        }

        private void TicTacToeTwoPlayer_Load(object sender, EventArgs e)
        {
            
        }
        private void winLine(int[] winner)
        {

        }
    }
}
