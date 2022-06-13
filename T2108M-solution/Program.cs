using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2108M_solution.Project1;
using System.Net.Http;
using Newtonsoft.Json;


namespace T2108M_solution.dto
{
    class Program
    {
      static async Task main(string[] args)
        {
            CurrentWeather c = await GetCurrentWeather();
            Console.WriteLine(c.main.temp);
            
        }

        // 
        static async Task<CurrentWeather> GetCurrentWeather()
        {
            CurrentWeather current = null;
            HttpClient client = new HttpClient();
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            var res = await client.GetAsync(url);
            if (res.IsSuccessStatusCode)
            {
                string s = await res.Content.ReadAsStringAsync();
                current =  JsonConvert.DeserializeObject<CurrentWeather>(s);
            }
            return current;
            
        }
    }
}
