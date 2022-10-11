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
    public partial class OnePlayerPrompt : Form
    {
        public OnePlayerPrompt()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            string playerSide = "";
            int difficulty = difficultyTrackBar.Value;
            if (xRadioButton.Checked)
            {
                playerSide = "X";
            }
            else
            {
                playerSide = "O";
            }
            TicTacToeAI newGame = new TicTacToeAI(playerSide, difficulty);
            newGame.ShowDialog();
        }
    }
}
