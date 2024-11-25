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

        /// <summary>
        /// Main method/function that handles the data gathering, keeps track of the parameters,
        /// and orchestrates the program flow.
        /// </summary
        public async Task OnGetAsync()
        {
            // Create a list of stations from the station Data file.
            Stations = StationData.Stations;

            // If there is no Station id and Station name has value then we look for that station in our Stations list.
            if (StationId == 0 && !string.IsNullOrEmpty(StationName))
            {
                var station = Stations.FirstOrDefault(S => S.Name.Equals(StationName, StringComparison.OrdinalIgnoreCase));
                if (station != null)
                {
                    StationId = station.Id;
                }
            }

            // No station ID provided; do not fetch data.
            if (StationId <= 0)
            {

                return;
            }

            // This is used to keep track of the station selected, and display it in the search box.
            SelectedStationName = Stations.FirstOrDefault(s => s.Id == StationId)?.Name;

            using (var httpClient = new HttpClient())
            {
                // Call the endpoint for the current weather data.
                var apiUrl = $"https://xmlweather.vedur.is/?op_w=xml&type=obs&lang=is&view=xml&ids={StationId}";

                // Load the endpoint.
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {

                    // Used for getting the current weather data for a particular weather station.
                    await getWeatherStationData(response);

                    // Used to get data from the Vedur API endpoint that has the weather data for a weather station for the next few days
                    await getFutureWeatherData(httpClient);
                }
            }
        }

        /// <summary>
        /// This is used for getting the current weather data for a particular weather station, loads the data into the Observation model
        /// and parses it also.
        /// </summary>
        /// <param name="response">The HTTP response containing the XML weather observation data.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task getWeatherStationData(HttpResponseMessage response)
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
                    AreaId = Stations.FirstOrDefault(s => s.Id == StationId)?.AreaId ?? 101
                };
            }
            else
            {
                // Handle error response
                ModelState.AddModelError(string.Empty, "Unable to fetch data from the weather API.");
            }
        }

        /// <summary>
        /// This is used to get data from the Vedur API endpoint that has the weather data for a weather station for the next few days, then it populates the "FutureForecast" model with the elements loaded.
        /// </summary>
        /// <param name="response">The HTTP response containing the XML weather observation data.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        private async Task getFutureWeatherData(HttpClient httpClient)
        {
            // Load the data from the endpoint that has the data for the next few days.
            var apiUrlFuture = $"https://xmlweather.vedur.is/?op_w=xml&type=forec&lang=is&view=xml&ids={StationId}";
            var Futureresponse = await httpClient.GetAsync(apiUrlFuture);

            if (Futureresponse.IsSuccessStatusCode)
            {
                string apiResponseFuture = await Futureresponse.Content.ReadAsStringAsync();
                XDocument docFuture = XDocument.Parse(apiResponseFuture);

                var stationElementFuture = docFuture.Descendants("station").FirstOrDefault();

                if (stationElementFuture != null)
                {
                    // Create a future forecast list.
                    FutureForecast = new List<WeatherFutureForecast>();

                    var forecastElements = stationElementFuture.Elements("forecast");

                    // Loop through the forecasts for the station and save the values into FutureForecast list.
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
