using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool Turn = true; //true = X turn, Y = O turn
        int Turn_Count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Deen_Kadir", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Turn)
            {
                b.Text = "X";
                b.BackColor = Color.DarkGoldenrod;
            }
            else
            {
                b.Text = "O";
                b.BackColor = Color.Moccasin;
            }
            Turn = !Turn;
            b.Enabled = false;
            Turn_Count++;

            Check_for_Winner();
        }

        private void Check_for_Winner()
        {
            bool There_is_a_winner = false;

                //Horizontal Check
                if((A1.Text == A2.Text)&&(A2.Text == A3.Text)&&(!A1.Enabled))
                    There_is_a_winner = true;
                else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                    There_is_a_winner = true;
                else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                    There_is_a_winner = true;

                //Vertical Check
                else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                    There_is_a_winner = true;
                else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                    There_is_a_winner = true;
                else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                    There_is_a_winner = true;

                //Diagonal Check
                else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                    There_is_a_winner = true;
                else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C2.Enabled))
                    There_is_a_winner = true;


            if (There_is_a_winner)
            {
                Disable_Button();

                string winner = "";
                    if(Turn)
                        winner = "O";
                    else
                        winner = "X";

                MessageBox.Show(winner + " Wins!", "Yay!");
            }
            else
            {
                if(Turn_Count == 9)
                    MessageBox.Show("Draw!", "Bummer!");
            }
        }//end Check_for_winner
        private void Disable_Button()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }//end try
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Turn = true;
            Turn_Count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch { }
        }

        private void borderPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
