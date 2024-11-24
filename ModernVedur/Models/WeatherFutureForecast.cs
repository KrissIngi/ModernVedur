namespace ModernVedur.Models
{
    public class WeatherFutureForecast
    {
        public int StationId { get; set; }
        public string Name { get; set; }
        public DateTime ftime { get; set; }
        public string Link { get; set; }
        public string F { get; set; } // Wind speed
        public string D { get; set; } // Wind direction
        public string T { get; set; } // Temperature 
        public string W { get; set; } // Weather description
    }
}
