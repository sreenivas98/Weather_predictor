using Newtonsoft.Json.Linq;

namespace MiniProject_new
{
    public class WeatherApi
    {
        private const string API_KEY = "2038b1498e6941f0867230d44acc56e0";
        private const string API_URL1 = "http://api.openweathermap.org/data/2.5/weather?zip={0}&appid={1}&units=metric";
        private const string API_URL2 = "http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric";
        private readonly HttpClient _httpClient;
        public WeatherApi()
        {
            _httpClient = new HttpClient();
        }
        public async void getForecast(string locationData)
        {
            string[] locData = locationData.Split(':');
            string type = locData[0].Trim();
            string location = locData[1].Trim();
            string url = "";
            switch (type)
            {
                case "zipCode":
                    if (!string.IsNullOrEmpty(location))
                    {
                        url = string.Format(API_URL1, location, API_KEY);
                    }
                    break;
                case "city":
                    if (!string.IsNullOrEmpty(location))
                    {
                        url = string.Format(API_URL2, location, API_KEY);
                    }
                    break;
            }
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(json);
                float temperature = data["main"]["temp"].Value<float>();
                float feels_like = data["main"]["feels_like"].Value<float>();
                float temp_min = data["main"]["temp_min"].Value<float>();
                float temp_max = data["main"]["temp_max"].Value<float>();
                float pressure = data["main"]["pressure"].Value<float>();
                float humidity = data["main"]["humidity"].Value<float>();
                string description = data["weather"][0]["description"].Value<string>();
                // Data returned by weather API is parsed into "data"
                float latitude = data["coord"]["lon"].Value<float>();
                float longitude = data["coord"]["lat"].Value<float>();


                float wind_speed = data["wind"]["speed"].Value<float>();
                float visibility = data["visibility"].Value<float>();
                float wind_direction_degrees = data["wind"]["deg"].Value<float>();


                string country = data["sys"]["country"].Value<string>();
                string city = data["name"].Value<string>();

                string wind_direction = "";

                if (wind_direction_degrees == 0) { wind_direction = "North"; }
                else if (wind_direction_degrees > 0 && wind_direction_degrees < 90) { wind_direction = "Northeast"; }
                else if (wind_direction_degrees == 90) { wind_direction = "East"; }
                else if (wind_direction_degrees > 90 && wind_direction_degrees < 180) { wind_direction = "Southeast"; }
                else if (wind_direction_degrees == 180) { wind_direction = "South"; }
                else if (wind_direction_degrees > 180 && wind_direction_degrees < 270) { wind_direction = "Southwest"; }
                else if (wind_direction_degrees == 270) { wind_direction = "West"; }
                else if (wind_direction_degrees > 270 && wind_direction_degrees < 360) { wind_direction = "Northwest"; }

                string Weatherforecast = $"Temperature in {city}: {temperature:F2}°C\nWeather: " +
                        $"{description}\nThe feels like temperature is {feels_like:F2}°C\n" +
                        $"The atmospheric pressure is {pressure}mbar\n" +
                        $"The relative humidity is {humidity}%\n" +
                        $"The latitude of the location is {latitude}°\n" +
                        $"The longitude of the location is {longitude}°\n" +
                        $"The wind speed is {wind_speed}km/hr\n" +
                        $"The wind direction is {wind_direction}";

                ResponseForm responseForm = new ResponseForm();
                responseForm.setLabelText(Weatherforecast);
                responseForm.Show();
               
            }
        }
        private class WeatherData
        {
            public MainData? Main { get; set; }
            public Weather[]? Weather { get; set; }
        }
        private class MainData
        {
            public double Temp { get; set; }
        }
        private class Weather
        {
            public string? Description { get; set; }
        }
    }
}