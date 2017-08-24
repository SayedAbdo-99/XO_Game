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
    public partial class Game_Form : Form
    {
        public Game_Form()
        {
            InitializeComponent();
        }
        private void Btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Home home = new Form_Home();
            home.ShowDialog();
            this.Close();
        }
        private void Btn_Agine_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game_Form again = new Game_Form();
            again.ShowDialog();
            this.Close();
            
        }
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool flag =false;
        public void Btn_val_Check()
        {
            if ((Btn_1.Text == Btn_2.Text && Btn_1.Text == Btn_3.Text && Btn_1.Text != "") || (Btn_1.Text == Btn_4.Text && Btn_1.Text == Btn_7.Text && Btn_1.Text != "") ) flag = true;
            else if ((Btn_5.Text == Btn_2.Text && Btn_5.Text == Btn_8.Text && Btn_5.Text != "") || (Btn_5.Text == Btn_4.Text && Btn_5.Text == Btn_6.Text && Btn_5.Text != "")) flag = true;
            else if ((Btn_9.Text == Btn_7.Text && Btn_9.Text == Btn_8.Text && Btn_9.Text != "") || (Btn_9.Text == Btn_3.Text && Btn_9.Text == Btn_6.Text && Btn_9.Text != "")) flag = true;
            else if ((Btn_5.Text == Btn_1.Text && Btn_5.Text == Btn_9.Text && Btn_5.Text != "") || (Btn_5.Text == Btn_3.Text && Btn_5.Text == Btn_7.Text && Btn_5.Text != "")) flag = true;
        }
        public DateTime x = DateTime.MinValue;
        public DateTime o = DateTime.MinValue;
        bool Btn_val = true;
        private void Btn_Click(object sender, EventArgs e)
        {
            Button T = (Button)sender;
            if (Btn_val && T.Text != "O")
            {
                T.Text = "X";
                Lab_O.Visible = true;
                Lab_X.Visible = false;
                timer2.Start();
                timer1.Stop();
            }

            else if (!Btn_val && T.Text != "X")
            {
                T.Text = "O";
                Lab_O.Visible = false;
                Lab_X.Visible = true;
                T.ForeColor = Color.DarkViolet;
                timer1.Start();
                timer2.Stop();
            }
            Btn_val = !Btn_val;
            Btn_val_Check();
            if (flag == true )
            {
                if(T.Text=="X")
                    MessageBox.Show("WOoOo!! Player X Woin!!" + "\nThe X time of = " +  String.Format("{0:mm ss}", x.AddSeconds(count_x))
                                                    + "\nThe O time of = " +  String.Format("{0:mm ss}", o.AddSeconds(count_o)));
                else
                    MessageBox.Show("WOoOo!! Player O Woin!!" + "\nThe O time of = " + String.Format("{0:mm ss}", o.AddSeconds(count_o))
                                                    + "\nThe X time of = " + String.Format("{0:mm ss}", x.AddSeconds(count_x)));
            }
            else if (flag == false && (Btn_1.Text != "" && Btn_2.Text != "" && Btn_3.Text != "" && Btn_4.Text != "" && Btn_5.Text != "" && Btn_6.Text != "" && Btn_7.Text != "" && Btn_8.Text != "" && Btn_9.Text != ""))
            {
                MessageBox.Show("Sorry,No One Won!!" + "\nThe O time of = " + String.Format("{0:mm ss}", o.AddSeconds(count_o))
                                                      + "\nThe X time of = " + String.Format("{0:mm ss}", x.AddSeconds(count_x)));
                 Btn_Agine_Click(sender, e);
            }
        }//end Btm_Click
        int count_x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count_x++;
        }
        int count_o;
        private void timer2_Tick(object sender, EventArgs e)
        {
            count_o++;
        }
    }
}
