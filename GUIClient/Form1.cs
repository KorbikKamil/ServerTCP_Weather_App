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
            client.Send(city);
            string[] data;
            string recivedString;
            try
            {
                recivedString = client.Read();
                data = recivedString.Split('|');
                koordynaty.Text = "Koordynaty miejscowości: lon:" + data[0] + " lat:" + data[1];
                temperatura.Text = "Temperatura: " + data[2] + "°C";
                cisnienie.Text = "Ciśnienie: " + data[3] + "hPa";
                wilgotnosc.Text = "Wilgotność: " + data[4] + "%";
                wiatr.Text = "Prędkość wiatru: " + data[5] + "km/h";
                kraj.Text = "Kraj: " + data[6];
            } catch (Exception ex)
            {
                blad.Visible = true;
            }
        }
    }
}
