using System.ComponentModel.DataAnnotations;

namespace ModernVedur.Models
{
    public class WeatherStation
    {
        public string? name { get; set; }
        public DateTime? date { get; set; }
        public int temperature {  get; set; }
        public int windSpeed { get; set; }
        public int precipation { get; set; }
    }
}
