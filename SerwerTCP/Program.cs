using System.Net;
using WeatherServerLibrary;

namespace SerwerTCP
{
    /// <summary>
    /// Główna klasa programu
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            WeatherServer weatherServer = new WeatherServer(IPAddress.Parse("127.0.0.1"), 2048);
            weatherServer.Start();
        }
    }
}
