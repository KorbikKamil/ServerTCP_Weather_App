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
            Serwer serwer = new Serwer("127.0.0.1", 2048);
            serwer.getWeather();
        }
    }
}
