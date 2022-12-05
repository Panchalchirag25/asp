using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe About");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "x";
            else
                b.Text = "0";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkforwinner();
        }

        private void checkforwinner()
        {
            bool winner = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
            {
                winner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                winner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                winner = true;
            }
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                winner = true;
            }
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                winner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                winner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                winner = true;
            }
            if (winner)
            {
                disableButton();
                String winnerer = "";
                if (turn)
                    winnerer = "0";
                else
                    winnerer = "x";
                Console.Beep();
                MessageBox.Show(winnerer+"wins..!","Yah...!");
                
            }
            else{
                if(turn_count==9)
                    MessageBox.Show("Draw...!","Bummer");
            }
        }

        private void disableButton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }
            catch {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
