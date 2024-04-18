using MyEcoSpace.API.OpenWeather.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather
{
    public class OpenWeather
    {
        private HttpClient _httpClient;
        private Config _config;

        public OpenWeather()
        {
            _config = ConfigReader.GetConfig(new StreamReader("appconfig.json").ReadToEnd());

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://" + _config.BaseAddress);
        }

        public async Task<FiveDaysThreeHoursResponse> FiveDaysThreeHours(string lat, string lon)
        {
            FiveDaysThreeHoursResponse response;
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, EndPoints.GetPath.ThreeDaysFiveHours(lat, lon, _config.APIKey));
                var result = await _httpClient.SendAsync(request);
                var jsonString = await result.Content.ReadAsStringAsync();
                Console.WriteLine(jsonString);
                response = JsonConvert.DeserializeObject<FiveDaysThreeHoursResponse>(jsonString);
                return response;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
