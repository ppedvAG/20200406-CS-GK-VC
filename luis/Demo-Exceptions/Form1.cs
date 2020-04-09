using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Exceptions
{
    public partial class Form1 : Form
    {
        public string VN { get; set; }
        public string NN { get; set; }
        public int Alter { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                VN = textBox_VN.Text;
                NN = textBox_NN.Text;
                Alter = int.Parse(textBox_AL.Text);
            }
            catch (FormatException fex)
            {
                MessageBox.Show($"Format-Fehlermeldung: {fex.Message}");
                return;
                //throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Allgemein-Fehlermeldung: {ex.Message}");
                return;
                //throw;
            }
            finally
            {
                MessageBox.Show($"Eingaben gespeichert: " +
                                $"\n Vorname: {VN}" +
                                $"\n Nachname: {NN}" +
                                $"\n Alter: {Alter}"
                                );
            }
        }
    }
}
