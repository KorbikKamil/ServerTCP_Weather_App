using System;
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
            Console.WriteLine("Wybierz opcje: \n0 - serwer \n1 - Klient \n\nTwój wybór: ");

            int option = int.Parse(Console.ReadLine());

            if (option == 0)
            {
                ClientHandler clientHandler = new ClientHandler(IPAddress.Parse("127.0.0.1"), 2048);
                clientHandler.Start();
            }
            else if (option == 1)
            {
                Client client = new Client();
                client.Start("127.0.0.1", 2048);
            }
            else {
                Console.WriteLine("Nie ma takiej opcji!");
            }
        }
    }
}
