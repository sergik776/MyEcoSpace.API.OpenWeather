using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather.Models
{
    public class Clouds
    {
        public int all { get; set; }

        public override string ToString()
        {
            return $"Cloudiness: {all} %";
        }
    }
}
