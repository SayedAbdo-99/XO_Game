using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game_Form xo = new Game_Form();
            xo.ShowDialog();
            this.Close();
        }

        private void Btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic-tac-toe: (also known as noughts and crosses or Xs and Os):-\n is a paper-and-pencil game for two players, X and O, who take turns marking the spaces in a 3×3 grid. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row wins the game");
        
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
