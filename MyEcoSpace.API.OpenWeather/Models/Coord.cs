using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather.Models
{
    public class Coord
    {
        public double lat { get; set; }
        public double lon { get; set; }

        public override string ToString()
        {
            return $"Coordinates: Latitude: {lat}, Longitude: {lon}";
        }
    }
}
