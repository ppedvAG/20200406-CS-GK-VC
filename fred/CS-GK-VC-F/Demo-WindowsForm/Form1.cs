using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int counter = 0;
        void CheckWinner(string x_or_o)
        {
            if (button1.Text == x_or_o && button2.Text == x_or_o && button3.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen");

            } 
            else if (button4.Text == x_or_o && button5.Text == x_or_o && button6.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen");
            }
            else if (button7.Text == x_or_o && button8.Text == x_or_o && button9.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen");
            }
            else if (button1.Text == x_or_o && button5.Text == x_or_o && button9.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen");
            }
            else if (button3.Text == x_or_o && button5.Text == x_or_o && button7.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen");
            }
            else if (button3.Text == x_or_o && button6.Text == x_or_o && button9.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen");
            }
            else if (button2.Text == x_or_o && button5.Text == x_or_o && button7.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen");
            }
            else if (button1.Text == x_or_o && button4.Text == x_or_o && button7.Text == x_or_o)
            {
                MessageBox.Show(x_or_o + " hat gewonnen");
            }
            else if (counter == 8)
            {
                MessageBox.Show("Unentschieden, macht lieber Sport!");
                // Das Beenden der Anwendung forcieren
                Environment.Exit(0);
            }

            //bedingung muss angepasst werden)
        }

        //void StepFunction(object senderobj)
        //{
        //    string buttontext = ((Button)senderobj).Text;
        //    if (buttontext == "")
        //    {
        //        if (counter % 2 == 0)
        //        {
        //            ((Button)senderobj).Text = "O";
        //            CheckWinner("O");
        //        }
        //        else
        //        {
        //            ((Button)senderobj).Text = "X";
        //            CheckWinner("X");
        //        }
        //        counter++;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Klick wo anders, du Idiot!");
        //    }
        //}

        void StepFunction(object senderobj)
        {
            string buttontext = ((Button)senderobj).Text;
            if (buttontext == "")
            {
                if (counter % 2 == 0)
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
    }

}
