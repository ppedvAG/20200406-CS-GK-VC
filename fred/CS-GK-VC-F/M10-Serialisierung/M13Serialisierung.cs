using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Transportmittel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace M10_Serialisierung
{
    
    public partial class M13Serialisierung : Form
    {
        public List<Transportmittel.Transport> autoliste = new List<Transportmittel.Transport>();
        public M13Serialisierung()
        {
            InitializeComponent();
            for (int i = 0; i<5; i++)
            {
                autoliste.Add (new PKW("BMW", 53000, 250));

            }  
        }

        private void AktuelleListeAnzeigen()
        {
            string text = "";
            foreach (var item in autoliste)
            {
                text += item.sName + "\n";
            }
            label1.Text = text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "autoliste|*.pkwl";
            od.FileName = "autoliste.pkwl";
            if (od.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(od.FileName))
                {
                    try
                    {
                        List<Transport> geladeneListe = (List<Transport>)JsonConvert.DeserializeObject<List<Transport>>(sr.ReadToEnd());
                        autoliste = geladeneListe;
                        AktuelleListeAnzeigen();
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                        return;
                    }
                    finally
                    {
                        sr.Close();
                    }
                }
                MessageBox.Show("Datei wurde geladen!");
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Fahrzeuge.pkwl";
            saveFileDialog.Filter = "PKW-Liste|*.pkwl";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.Write(JsonConvert.SerializeObject(autoliste));
                    sw.Close();
                }
                MessageBox.Show("Datei wurde gespeichert!");
            }
        }
    }
}
