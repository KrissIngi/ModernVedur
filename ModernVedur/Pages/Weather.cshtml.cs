using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModernVedur.Data;
using ModernVedur.Models;
using System.Xml.Linq;

namespace ModernVedur.Pages
{
    public class WeatherModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int StationId { get; set; }
        [BindProperty(SupportsGet = true)]
        public string StationName { get; set; }
        [BindProperty(SupportsGet = true)]
        public bool LoadFutureForecast { get; set; }

        public List<StationInfo> Stations { get; set; }
        public WeatherObservation Observation { get; set; }
        public List<WeatherFutureForecast> FutureForecast { get; set; }

        public string SelectedStationName { get; set; }

        public async Task OnGetAsync()
        {
            Stations = StationData.Stations;

            if (StationId == 0 && !string.IsNullOrEmpty(StationName))
            {
                var station = Stations.FirstOrDefault(S => S.Name.Equals(StationName, StringComparison.OrdinalIgnoreCase));
                if (station != null)
                {
                    StationId = station.Id;
                }
            }

            if (StationId <= 0)
            {
                // No station ID provided; do not fetch data.
                return;
            }

            SelectedStationName = Stations.FirstOrDefault(s => s.Id == StationId)?.Name;

            using (var httpClient = new HttpClient())
            {
                var apiUrl = $"https://xmlweather.vedur.is/?op_w=xml&type=obs&lang=is&view=xml&ids={StationId}";

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
                    else
                    {
                        // Handle error response
                        ModelState.AddModelError(string.Empty, "Unable to fetch data from the weather API.");
                    }

                    if(LoadFutureForecast)
                    {
                        var apiUrlFuture = $"https://xmlweather.vedur.is/?op_w=xml&type=forec&lang=is&view=xml&ids={StationId}";
                        var Futureresponse = await httpClient.GetAsync(apiUrlFuture);

                        if (Futureresponse.IsSuccessStatusCode)
                        {
                            string apiResponseFuture = await Futureresponse.Content.ReadAsStringAsync();
                            XDocument docFuture = XDocument.Parse(apiResponseFuture);

                            var stationElementFuture = docFuture.Descendants("station").FirstOrDefault();

                            if (stationElementFuture != null)
                            {
                                FutureForecast = new List<WeatherFutureForecast>();

                                var forecastElements = stationElementFuture.Elements("forecast");

                                foreach (var forecastElement in forecastElements)
                                {
                                    var futureForcast = new WeatherFutureForecast
                                    {
                                        ftime = DateTime.TryParse(forecastElement.Element("ftime")?.Value, out var time) ? time : DateTime.MinValue,
                                        F = forecastElement.Element("F")?.Value,
                                        D = forecastElement.Element("D")?.Value,
                                        T = forecastElement.Element("T")?.Value,
                                        W = forecastElement.Element("W")?.Value,
                                    };

                                    FutureForecast.Add(futureForcast);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
