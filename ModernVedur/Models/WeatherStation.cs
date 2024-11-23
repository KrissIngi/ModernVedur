using System.ComponentModel.DataAnnotations;

namespace ModernVedur.Models
{
    public class WeatherStation
    {
        public string Name { get; set; }
        public DateTime Atime { get; set; }
        public int IsFilterTemperature { get; set; }
        public int IsFilterWind { get; set; }
        public int IsFilterPrecipitation { get; set; }
    }
}
