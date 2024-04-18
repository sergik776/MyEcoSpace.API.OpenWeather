using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather.Models
{
    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }

        public override string ToString()
        {
            return $"Wind: speed - {speed}, direction - {deg}, gust - {gust}";
        }
    }
}
