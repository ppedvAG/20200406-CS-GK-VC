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
            Boom.Click += button1_Click;
            Boom.Click += button2_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Left+=10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Left-=10;
        }

        private void Boom_Click(object sender, EventArgs e)
        {
            if (button1.Right > button2.Left)
                MessageBox.Show("Kollision macht boom!");
        }
    }
}
