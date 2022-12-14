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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void twoPlayer_Click(object sender, EventArgs e)
        {
            TicTacToeTwoPlayer newGame = new TicTacToeTwoPlayer();
            newGame.ShowDialog();
        }

        private void onePlayer_Click(object sender, EventArgs e)
        {
            OnePlayerPrompt newPrompt = new OnePlayerPrompt();
            newPrompt.ShowDialog();
        }
    }
}
