using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelPin.Text = labelPin.Text + button1.Text;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            labelPin.Text = labelPin.Text + button2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            labelPin.Text = labelPin.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelPin.Text = labelPin.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelPin.Text = labelPin.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelPin.Text = labelPin.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelPin.Text = labelPin.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelPin.Text = labelPin.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelPin.Text = labelPin.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            labelPin.Text = labelPin.Text + button0.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelPin.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult messageExit;
            messageExit = MessageBox.Show("Exit ATM system:","ATM Information",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (messageExit==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
