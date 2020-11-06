using System;
using System.IO;
using System.Net;

namespace ServerClassLibrary
{
    /// <summary>
    /// Klasa służąca do łączenia z serwerem api.
    /// </summary>
    public class Http
    {
        public static CookieContainer cookieContainer = new CookieContainer();
        /// <summary>
        /// Funkcja służąca wysłaniu zapytania typu GET
        /// </summary>
        /// <param name="url">Adres url służący do komunikacji z serwerem</param>
        /// <returns>Funkcja zwraca dane wysłane przez serwer</returns>
        public static string Get(string url)
        {
            var source = string.Empty;
            try
            {
                var req = (HttpWebRequest)WebRequest.Create(url);
                req.CookieContainer = cookieContainer;
                req.Method = "GET";
                req.KeepAlive = true;

                HttpWebResponse response = (HttpWebResponse)req.GetResponse();
                Stream dataStream = response.GetResponseStream();

                if(dataStream != null)
                {
                    using (var reader = new StreamReader(dataStream))
                    {
                        source = reader.ReadToEnd();
                    }

                    req.CookieContainer.Add(response.Cookies);
                    cookieContainer.Add(response.Cookies);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Get error: {0}", e.Message);
            }
            return source;
        }
    }
}
