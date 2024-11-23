using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernVedur.Models;
using System.Xml.Linq;

namespace ModernVedur.Pages
{
    public class WeatherModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int StationId { get; set; }

        public WeatherObservation Observation { get; set; }

        public async Task OnGetAsync()
        {
            if (StationId <= 0)
            {
                // No station ID provided; do not fetch data.
                return;
            }

            using (var httpClient = new HttpClient())
            {
                var apiUrl = $"https://xmlweather.vedur.is/?op_w=xml&type=obs&lang=en&view=xml&ids={StationId}";

                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    XDocument doc = XDocument.Parse(apiResponse);

                    var stationElement = doc.Descendants("station").FirstOrDefault();
                    if (stationElement != null)
                    {
                        Observation = new WeatherObservation
                        {
                            StationId = int.TryParse(stationElement.Attribute("id")?.Value, out var id) ? id : 0,
                            Name = stationElement.Element("name")?.Value,
                            Time = DateTime.TryParse(stationElement.Element("time")?.Value, out var time) ? time : DateTime.MinValue,
                            Link = stationElement.Element("link")?.Value,
                            F = stationElement.Element("F")?.Value,
                            D = stationElement.Element("D")?.Value,
                            FX = stationElement.Element("FX")?.Value,
                            FG = stationElement.Element("FG")?.Value,
                            T = stationElement.Element("T")?.Value,
                            W = stationElement.Element("W")?.Value,
                            V = stationElement.Element("V")?.Value,
                            R = stationElement.Element("R")?.Value,
                        };
                    }
                }
                else
                {
                    // Handle error response
                    ModelState.AddModelError(string.Empty, "Unable to fetch data from the weather API.");
                }
            }
        }
    }
}
