using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WeatherServerLibrary;
using Windows.UI.Notifications;

namespace GUIClient
{
    public partial class Form1 : Form
    {
        private String notCityName;
        private int notTime;
        private System.Timers.Timer aTimer;

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

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            client.Send(notCityName);
            string[] data;
            string recivedString;

            recivedString = client.Read();
            data = recivedString.Split('|');

            String notString = String.Format("Pogoda dla {0}, temp {1}°C, ciśn {2} hPa, wilg {3}%, wiatr {4} km/h", notCityName, data[2], data[3], data[4], data[5]);

            DesktopNotificationManagerCompat.RegisterAumidAndComServer<NotificationHandler>("Twoja Pogodynka");
            DesktopNotificationManagerCompat.RegisterActivator<NotificationHandler>();
            ToastContent toastContent = new ToastContentBuilder()
                .AddToastActivationInfo("", ToastActivationType.Background)
                .AddText(notString)
                .GetToastContent();

            // And create the toast notification
            var toast = new ToastNotification(toastContent.GetXml());

            // And then show it
            DesktopNotificationManagerCompat.CreateToastNotifier().Show(toast);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(blad.Visible==false)
            {
                if(textBox1.Text=="")
                {
                    return;
                }
                notCityName = textBox1.Text;
                notTime = Int32.Parse(comboBox1.SelectedItem.ToString());


                if(aTimer!=null&&aTimer.Enabled==true)
                {
                    aTimer.Stop();
                    label4.Text = String.Format("Powiadomienie wyłaczone");
                }

                if (notTime != 0)
                {
                    aTimer = new System.Timers.Timer(notTime * 1000);
                    // Hook up the Elapsed event for the timer. 
                    aTimer.Elapsed += OnTimedEvent;
                    aTimer.AutoReset = true;
                    aTimer.Enabled = true;
                    label4.Text = String.Format("Powiadomienie: {0}, co {1} sekund", notCityName, notTime);
                }
            } else
            {
                //TODO: what to do if fail?
            }
            //if(comboBox1.GetItemText)
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }


    }
}
