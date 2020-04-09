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

namespace M13Serialisierung
{
    public partial class Form1 : Form
    {

        List<Transport> carList = new List<Transport>();
        
        public Form1()
        {
            InitializeComponent();
            carList.Add(new PKW("Audi", 40000, 240,  5));
            carList.Add(new PKW("BMW", 30000, 220, 5));
            carList.Add(new PKW("VW", 30000, 210, 5));
            carList.Add(new PKW("Skoda", 30000, 240, 5));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader("Autoliste.txt");
            List<Transport> ergebnissList = JsonConvert.DeserializeObject<List<Transport>>(streamReader.ReadToEnd());

            foreach (var item in ergebnissList)
            {
                Ausgabe.Text += $" {item.BeschreibeMich()} \n";
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("Autoliste.txt");
            streamWriter.Write(JsonConvert.SerializeObject(carList));
            streamWriter.Close();
        }
    }
}
