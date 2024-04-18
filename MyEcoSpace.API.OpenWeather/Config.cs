using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather
{
    public class Config
    {
        public string? APIKey { get; set; }
        public string? BaseAddress { get; set;}

        public override string ToString()
        {
            return $"{APIKey} {BaseAddress}";
        }
    }
}
