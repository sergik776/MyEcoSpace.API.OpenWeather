using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather
{
    public static class ConfigReader
    {
        public static Config? GetConfig(string json)
        {
            Config config = new Config();
            config = JsonConvert.DeserializeObject<Config>(json);
            return config;
        }
    }
}
