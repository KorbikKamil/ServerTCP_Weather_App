using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using WeatherLibrary;
using System.IO;

namespace WeatherServerLibrary
{
    /// <summary>
    /// Klasa implementująca działanie serwera
    /// </summary>
    public class WeatherServer : Server
    {

        static readonly string apiKey = "a3f16ef88f8535836dffea2213656bf1";

        public delegate void delegateGetWeather(NetworkStream stream);

        public WeatherServer(IPAddress IP, int port) : base(IP, port) { }

        public override void Start()
        {
            StartListening();
            //transmission starts within the accept function
            AcceptClient();
        }

        protected override void AcceptClient()
        {
            while (true) 
            { 
                TcpClient = TcpListener.AcceptTcpClient();
                Stream = TcpClient.GetStream();
                Console.WriteLine("Nastąpiło poprawne połączenie");
                byte[] welcome = Encoding.UTF8.GetBytes("Nastapiło poprawne połączenie\r\n");
                Stream.Write(welcome, 0, welcome.Length);
                delegateGetWeather getWeathers = new delegateGetWeather(getWeather);
                getWeathers.BeginInvoke(Stream, getWeatherCallback, TcpClient);
            }
        }

        private void getWeatherCallback(IAsyncResult er)
        {
            TcpClient tcpClient = (TcpClient)er.AsyncState;
            tcpClient.Close();
            Console.WriteLine("Połączenie zostało zakończone!");
        }

        private void getWeather(NetworkStream stream)
        {
            byte[] question = Encoding.UTF8.GetBytes("\r\n(Jeśli chcesz wyjść wpisz exit)" +
                                                    "\r\nPodaj lokalizację, aby sprawdzić warunki pogodowe: ");
            byte[] localization = new byte[64];
            while (true)
            {
                stream.Write(question, 0, question.Length);

                int localizationLength = stream.Read(localization, 0, 64);
                byte[] trash = new byte[2];
                stream.Read(trash, 0, 2);
                string city = Encoding.UTF8.GetString(localization, 0, localizationLength);

                if (city == "exit")
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
                    stream.Write(licence, 0, licence.Length);
                    Console.WriteLine("Zwrócono poprawnie dane!");
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message);
                    byte[] error = Encoding.UTF8.GetBytes("Wpisano niepoprawną miejscowość!\r\n");
                    stream.Write(error, 0, error.Length);
                }
            }
        }
    }
}
