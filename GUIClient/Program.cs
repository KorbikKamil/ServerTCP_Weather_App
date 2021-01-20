using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Notifications;

namespace GUIClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DesktopNotificationManagerCompat.RegisterAumidAndComServer<NotificationHandler>("Twoja Pogodynka");
            DesktopNotificationManagerCompat.RegisterActivator<NotificationHandler>();
            ToastContent toastContent = new ToastContentBuilder()
                .AddToastActivationInfo("", ToastActivationType.Background)
                .AddText("Pogoda dla: Konin 26C Słonecznie")
                .GetToastContent();

            // And create the toast notification
            var toast = new ToastNotification(toastContent.GetXml());

            // And then show it
            DesktopNotificationManagerCompat.CreateToastNotifier().Show(toast);

            Application.Run(new Form1());
        }
    }
}
