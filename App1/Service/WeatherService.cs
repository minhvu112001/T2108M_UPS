using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2108M_UPS.Service;

using System.Net.Http;
using Newtonsoft.Json;

namespace T2108M_UPS.Service
{
    class WeatherService
    {

        public async Task<CurrentWeather> GetCurrentWeather()
        {
            HttpClient client = new HttpClient();
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            var ws = await client.GetAsync(url);
            if (ws.IsSuccessStatusCode)
            {
                var stringContent = await ws.Content.ReadAsStringAsync();
                var current = JsonConvert.DeserializeObject<CurrentWeather>(stringContent);
            }
        }




    }
}
