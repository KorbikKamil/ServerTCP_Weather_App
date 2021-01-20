using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherServerLibrary;

namespace GUIClient
{
    public partial class Form1 : Form
    {
        public Client client = new Client();
        public Form1()
        {
            InitializeComponent();
            
            client.Start("127.0.0.1", 2048);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blad.Visible = false;
            string city = textBox1.Text;
            try
            {
                if (city == "") {
                    throw new Exception();
                }
                client.Send(city);
                string[] data;
             string recivedString;
        
                recivedString = client.Read();
                data = recivedString.Split('|');
                koordynaty.Text = "Koordynaty miejscowości: lon:" + data[0] + " lat:" + data[1];
                temperatura.Text = "Temperatura: " + data[2] + "°C";
                cisnienie.Text = "Ciśnienie: " + data[3] + "hPa";
                wilgotnosc.Text = "Wilgotność: " + data[4] + "%";
                wiatr.Text = "Prędkość wiatru: " + data[5] + "km/h";
                kraj.Text = "Kraj: " + data[6];

                StringBuilder mapLoc = new StringBuilder("https://www.openstreetmap.org/");
                //https://www.openstreetmap.org/?&mlat=52&mlon=18#map=12/51.9530/17.9350
                mapLoc.Append("?&mlat=" + data[1] + "&mlon=" + data[0] + "#map=12/" + data[1] + "/" + data[0]);
                //mapLoc.Append(data[1] + "/" + data[0]);
                mapLoc.Replace(",", ".");

                mapa.Navigate(mapLoc.ToString());
            } catch (Exception ex)
            {
                blad.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder mapLoc = new StringBuilder("https://www.openstreetmap.org/?#map=12/0/0");

            mapa.Navigate(mapLoc.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dane_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if(comboBox1.GetItemText)
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
