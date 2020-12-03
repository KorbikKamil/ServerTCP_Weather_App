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
    public class WeatherGetter
    {
        /// <summary>
        /// Klucz api jest nieaktualny. Jeśli chcesz użyć tej implementacji, wygeneruj swój klucz na stronie https://openweathermap.org/
        /// </summary>
        static readonly string apiKey = "ffffffffffffffffffffffffffffffff";

        /// <summary>
        /// Funkcja zwracająca pogodę dla klienta
        /// </summary>
        /// <param name="stream">stream klienta</param>
        public static ApiObj getWeather(String city)
        {
            string apiUrl = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}", city, apiKey);
            string content = Http.Get(apiUrl);

            return JsonConvert.DeserializeObject<ApiObj>(content);
        }
    }
}
