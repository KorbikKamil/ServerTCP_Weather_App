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
            ClientHandler clientHandler = new ClientHandler(IPAddress.Parse("127.0.0.1"), 2048);
            clientHandler.Start();
        }
    }
}
