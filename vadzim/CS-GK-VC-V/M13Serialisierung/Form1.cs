using MTransportConsumer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MTransportConsumer.Schiff;

namespace M13Serialisierung
{
    public partial class Form1 : Form
    {
        public static List<Transport> TransportListe = new List<Transport>();
        public enum Fahrzeugtypen { PKW = 0, Schiff = 1, Flugzeug = 2 }

        public Form1()
        {
            InitializeComponent();

            //zufällig 10 Elemente erzeugen
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                switch ((Fahrzeugtypen)random.Next(3))
                {
                    case Fahrzeugtypen.Flugzeug: TransportListe.Add(new Flugzeug($"Boing {random.Next(100)}", 10000000, 800, 200)); break;
                    case Fahrzeugtypen.PKW: TransportListe.Add(new PKW("Opel Astra", 20000, 190, 4)); break;
                    case Fahrzeugtypen.Schiff: TransportListe.Add(new Schiff("Titanik", 100000000, 200, SchiffsTreibstoff.Diesel)); break;
                    default: MessageBox.Show("Ungültiger Flugzeugtyp!"); break;
                }
            }

            AktuelleListeAnzeigen();
        }

        private void btn_Laden_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "fahrzeugliste|*.fz";
            od.FileName = "Fahrzeugliste.fz";
            if (od.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(od.FileName))
                {
                    try
                    {
                        List<Transport> geladeneListe = (List<Transport>)JsonConvert.DeserializeObject<List<Transport>>(sr.ReadToEnd());
                        TransportListe = geladeneListe;
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

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();// *todo Dialog wird nicht angezeigt
            sd.Filter = "fahrzeugliste|*.fz";
            sd.FileName = "Fahrzeugliste.fz";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sd.FileName))
                {
                    sw.Write(JsonConvert.SerializeObject(TransportListe));
                    sw.Close();
                }
                MessageBox.Show("Datei wurde gespeichert!");
            }
        }

        private void AktuelleListeAnzeigen()
        {
            string text = "";
            foreach (var item in TransportListe)
            {
                text += item.Name + "\n";
            }
            label1.Text = text;
        }
    }
}
