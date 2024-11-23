namespace ModernVedur.Models
{
    public class WeatherObservation
    {
        public int StationId { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public DateTime ftime { get; set; }
        public string Link { get; set; }
        public string F { get; set; } // Wind speed

        public string D { get; set; } // Wind direction
        public string FX { get; set; } // Maximum wind speed
        public string FG { get; set; } // Wind gust
        public string T { get; set; } // Temperature 
        public string W { get; set; } // Weather description
        public string V { get; set; } // Visibility
        public string R { get; set; } //Precipitation
    }
}
