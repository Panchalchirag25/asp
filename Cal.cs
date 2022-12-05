using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator_66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num, ans;
        int count;
        private void button8_Click(object sender, EventArgs e)
        {
            txtAns.Text += 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtAns.Text += 9;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtAns.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtAns.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtAns.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtAns.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtAns.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtAns.Text += 6;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtAns.Text += 8;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtAns.Text += 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtAns.Text = txtAns.Text + ".";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            int length = txtAns.TextLength-1;
            string text = txtAns.Text;
            txtAns.Clear();
            for (int i = 0; i < length; i++)
            {
                txtAns.Text = txtAns.Text + text[i];
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAns.Text = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            compute();
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtAns.Text);
            txtAns.Clear();
            
            txtAns.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtAns.Text);
            txtAns.Clear();
            txtAns.Focus();
            count = 2;
            label1.Text = num.ToString() + "‐";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtAns.Text);
            txtAns.Clear();
            txtAns.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num = float.Parse(txtAns.Text);
            txtAns.Clear();
            txtAns.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        public void compute()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(txtAns.Text);
                    txtAns.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(txtAns.Text);
                    txtAns.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(txtAns.Text);
                    txtAns.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(txtAns.Text);
                    txtAns.Text = ans.ToString();
                    break;
                    
            default:
                    break;
            }
        }
    }
}

