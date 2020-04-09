using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M10_ButtonKollision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Left++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Left--;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Das ist zu einfach
            button1.Left++;
            button2.Left--;
           // if (button1.Right >= button2.Left)
             //   MessageBox("Boom");
            
        }
    }
}
