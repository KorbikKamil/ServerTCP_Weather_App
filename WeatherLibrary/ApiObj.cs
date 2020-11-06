

namespace WeatherLibrary
{
    /// <summary>
    /// Klasa opisująca koordynaty wpisanej przez użytkownika lokalizacji
    /// </summary>
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }
    /// <summary>
    /// Klasa zawierająca właściwości główne pogody
    /// </summary>
    public class Main
    {
        public double temp { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }
    /// <summary>
    /// Klasa zawierająca właściwości wiatru
    /// </summary>
    public class Wind
    {
        public double speed { get; set; }
    }
    /// <summary>
    /// Klasa zawierająca właściwości lokalizacji
    /// </summary>
    public class Sys
    {
        public string country { get; set; }
    }
    /// <summary>
    /// Klasa główna - root
    /// </summary>
    public class ApiObj
    {
        public Coord coord { get; set; }
    
        public Main main { get; set; }
    
        public Wind wind { get; set; }
    
        public Sys sys { get; set; }
    }
}
