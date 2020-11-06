using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;

namespace ServerClassLibrary
{
    /// <summary>
    /// Klasa implementująca działanie serwera
    /// </summary>
    public class Serwer
    {
        readonly IPAddress ipAdress;
        readonly int port;
        byte[] buffer = new byte[1024];
        byte[] welcome = Encoding.UTF8.GetBytes("Nastapiło poprawne połączenie\r\n");
        readonly TcpListener listener;
        readonly TcpClient client;
        readonly NetworkStream stream;
        static readonly string apiKey = "YOUR_API_KEY";
        

        /// <summary>
        /// Konstruktor klasy Serwer
        /// </summary>
        /// <param name="ip">Adress ip serwera</param>
        /// <param name="p">Port serwera</param>
        public Serwer(string ip, int p)
        {
            ipAdress = IPAddress.Parse(ip);
            port = p;

            listener = new TcpListener(ipAdress, port);
            listener.Start();

            client = listener.AcceptTcpClient();

            stream = client.GetStream();

            Console.WriteLine("Nastąpiło poprawne połączenie");
            stream.Write(welcome, 0, welcome.Length);
        }
        /// <summary>
        /// Funkcja pobierająca dane o pogodzie przy użyciu api "OpenWeather"
        /// </summary>
        public void getWeather()
        {
            byte[] question = Encoding.UTF8.GetBytes("\r\n(Jeśli chcesz wyjść wpisz exit)\r\nPodaj lokalizację, aby sprawdzić warunki pogodowe: ");
            byte[] localization = new byte[64];
            while (true)
            {
                stream.Write(question, 0, question.Length);

                int localizationLength = stream.Read(localization, 0, 64);
                byte[] trash = new byte[2];
                stream.Read(trash, 0, 2);
                string city = Encoding.UTF8.GetString(localization, 0, localizationLength);
                
                if(city == "exit")
                {
                    byte[] bye = Encoding.UTF8.GetBytes("Rozłączono z serwerem");
                    stream.Write(bye, 0, bye.Length);
                    break;
                }

                try
                {
                    string apiUrl = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", city, apiKey);
                    string content = Http.Get(apiUrl);

                    ApiObj cityWeather = JsonConvert.DeserializeObject<ApiObj>(content);

                    string outputValues = string.Format("\r\nKoordynaty miejscowośći: lon {0}  lat {1}" +
                                                        "\r\nTemperatura: {2}°C" +
                                                        "\r\nCiśnienie: {3}hPa" +
                                                        "\r\nWilgotność: {4}%" +
                                                        "\r\nPrędkość wiatru: {5}km/h" +
                                                        "\r\nKraj: {6}\r\n",
                                                        cityWeather.coord.lon,
                                                        cityWeather.coord.lat,
                                                        cityWeather.main.temp,
                                                        cityWeather.main.pressure,
                                                        cityWeather.main.humidity,
                                                        cityWeather.wind.speed,
                                                        cityWeather.sys.country);
                    byte[] weather = Encoding.UTF8.GetBytes(outputValues);
                    stream.Write(weather, 0, weather.Length);
                    byte[] licence = Encoding.UTF8.GetBytes("Dane pochodzą z openweathermap.org");
                    stream.Write(licence, 0 ,licence.Length);
                    Console.WriteLine("Zwrócono poprawnie dane!");
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                    byte[] error = Encoding.UTF8.GetBytes("Wpisano niepoprawną miejscowość!{0}\r\n");
                    stream.Write(error, 0, error.Length);
                }
            }
        }
    }
}
