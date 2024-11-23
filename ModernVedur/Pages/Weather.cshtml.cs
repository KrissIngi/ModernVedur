using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernVedur.Models;
using System.Xml.Linq;

namespace ModernVedur.Pages
{
    public class WeatherModel : PageModel
    {
        public List<WeatherStation> WeatherStations { get; set; }

        public async Task OnGetAsync()
        {
            WeatherStations = new List<WeatherStation>();

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://xmlweather.vedur.is/?op_w=xml&type=forec-info&lang=is&view=xml");
                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    XDocument doc = XDocument.Parse(apiResponse);

                    WeatherStations = doc.Descendants("model")
                        .Select(m => new WeatherStation
                        {
                            Name = m.Element("name")?.Value,
                            Atime = DateTime.TryParse(m.Element("atime")?.Value, out var atime) ? atime : DateTime.MinValue,
                            IsFilterTemperature = int.TryParse(m.Element("is_filter_temperature")?.Value, out var temp) ? temp : 0,
                            IsFilterWind = int.TryParse(m.Element("is_filter_wind")?.Value, out var wind) ? wind : 0,
                            IsFilterPrecipitation = int.TryParse(m.Element("is_filter_precipitation")?.Value, out var precip) ? precip : 0
                        })
                        .ToList();
                }
                else
                {
                    // Handle error
                }
            }
        }
    }
}
