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
        public Form1()
        {
            InitializeComponent();

            Client client = new Client();
            client.Start("127.0.0.1", 2048);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
