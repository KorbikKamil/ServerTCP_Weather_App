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
            string city = textBox1.Text;
            client.Send(city);
            Console.Write(client.Read());
        }
    }
}
