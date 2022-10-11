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
            TicTacToeAI newGame = new TicTacToeAI();
            newGame.ShowDialog();
        }
    }
}
