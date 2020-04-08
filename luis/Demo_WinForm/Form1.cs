using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;

        void CheckWinner(string xOrO)
        {
            if (button1.Text == xOrO && button2.Text == xOrO && button3.Text == xOrO)
            {
                MessageBox.Show(xOrO + " hat gewonnen!");
            }
            else if (button4.Text == xOrO && button5.Text == xOrO && button6.Text == xOrO)
            {
                MessageBox.Show(xOrO + " hat gewonnen!");
            }
            else if (button7.Text == xOrO && button8.Text == xOrO && button9.Text == xOrO)
            {
                MessageBox.Show(xOrO + " hat gewonnen!");
            }
            else if (button1.Text == xOrO && button4.Text == xOrO && button7.Text == xOrO)
            {
                MessageBox.Show(xOrO + " hat gewonnen!");
            }
            else if (button2.Text == xOrO && button5.Text == xOrO && button8.Text == xOrO)
            {
                MessageBox.Show(xOrO + " hat gewonnen!");
            }
            else if (button3.Text == xOrO && button6.Text == xOrO && button9.Text == xOrO)
            {
                MessageBox.Show(xOrO + " hat gewonnen!");
            }
            else if (button1.Text == xOrO && button5.Text == xOrO && button9.Text == xOrO)
            {
                MessageBox.Show(xOrO + " hat gewonnen!");
            }
            else if (button7.Text == xOrO && button5.Text == xOrO && button3.Text == xOrO)
            {
                MessageBox.Show(xOrO + " hat gewonnen!");
            }
            else if (counter >= 8)
            {
                MessageBox.Show("Unentschieden, das Spiel ist vorbei");
            }
        }

        void StepFunction(object senderobj)
        {
            string buttontext = ((Button)senderobj).Text;
            if (buttontext == "")
            {
                if(counter % 2 == 0)
                {
                    ((Button)senderobj).Text = "X";
                    CheckWinner("X");
                }
                else
                {
                    ((Button)senderobj).Text = "O";
                    CheckWinner("O");
                }
                counter++;
            }
            else
            {
                MessageBox.Show("Bist du blind? Klick woanders!");
            }
        }


        #region ButtonEventsUndZeichenSetzen

        
        private void button1_Click(object sender, EventArgs e)
        {
            StepFunction(sender);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            StepFunction(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StepFunction(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StepFunction(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StepFunction(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StepFunction(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StepFunction(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StepFunction(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StepFunction(sender);
        }

        #endregion

        private void button10_Click(object sender, EventArgs e)
        {
            counter = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
    }
}
