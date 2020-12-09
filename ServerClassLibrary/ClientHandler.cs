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
    public class ClientHandler : Server
    {
        public delegate void delegateHndlClient(NetworkStream stream);

        /// <summary>
        /// Inicjalizacja serwera
        /// </summary>
        /// <param name="IP">Adres IP serwera</param>
        /// <param name="port">Port serwera</param>
        public ClientHandler(IPAddress IP, int port) : base(IP, port) { }

        /// <summary>
        /// Funkcja startująca serwer
        /// </summary>
        public override void Start()
        {
            StartListening();
            //transmission starts within the accept function
            AcceptClient();
        }

        /// <summary>
        /// Akceptacja połączenia z klientem
        /// </summary>
        protected override void AcceptClient()
        {
            while (true) 
            { 
                TcpClient = TcpListener.AcceptTcpClient();
                Stream = TcpClient.GetStream();
                Console.WriteLine("Nastąpiło poprawne połączenie");
                //byte[] welcome = Encoding.UTF8.GetBytes("Nastapiło poprawne połączenie\r\n");
                //Stream.Write(welcome, 0, welcome.Length);
                delegateHndlClient HndlClient2 = new delegateHndlClient(handleClient);
                HndlClient2.BeginInvoke(Stream, clientDisconnect, TcpClient);
            }
        }

        /// <summary>
        /// Zakończenie połączenia z klientem
        /// </summary>
        /// <param name="er">klient</param>
        private void clientDisconnect(IAsyncResult er)
        {
            TcpClient tcpClient = (TcpClient)er.AsyncState;
            tcpClient.Close();
            Console.WriteLine("Połączenie zostało zakończone!");
        }

        private void handleClient(NetworkStream stream)
        {
            //byte[] question = Encoding.UTF8.GetBytes("\r\n(Jeśli chcesz wyjść wpisz exit)" +
                                                    //"\r\nPodaj lokalizację, aby sprawdzić warunki pogodowe: ");
            byte[] localization = new byte[64];
            while (true)
            {
                //stream.Write(question, 0, question.Length);

                int localizationLength = stream.Read(localization, 0, 64);
                //byte[] trash = new byte[2];
                //stream.Read(trash, 0, 2);
                string city = Encoding.UTF8.GetString(localization, 0, localizationLength);
                Console.Write(city);

                //if (city == "exit")
                //{
                //    byte[] bye = Encoding.UTF8.GetBytes("Rozłączono z serwerem");
                //    stream.Write(bye, 0, bye.Length);
                //    break;
                //}

                try
                {
                    ApiObj cityWeather = WeatherGetter.getWeather(city);

                    string outputValues = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}",                               
                                                        cityWeather.coord.lon,
                                                        cityWeather.coord.lat,
                                                        cityWeather.main.temp,
                                                        cityWeather.main.pressure,
                                                        cityWeather.main.humidity,
                                                        cityWeather.wind.speed,
                                                        cityWeather.sys.country);
                    byte[] weather = Encoding.UTF8.GetBytes(outputValues);
                    stream.Write(weather, 0, weather.Length);
                    //byte[] licence = Encoding.UTF8.GetBytes("Dane pochodzą z openweathermap.org");
                    //stream.Write(licence, 0, licence.Length);
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
