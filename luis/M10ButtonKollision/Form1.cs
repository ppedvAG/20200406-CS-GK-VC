using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M10ButtonKollision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button3.Click += button1_Click;
            button3.Click += button2_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Left += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Left -= 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Left + button1.Width > button2.Left)
            {
                MessageBox.Show("Die Buttons kollidieren!");
            }
            
        }
    }
}
