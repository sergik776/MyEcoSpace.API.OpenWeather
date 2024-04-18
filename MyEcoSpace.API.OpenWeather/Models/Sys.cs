using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather.Models
{
    public class Sys
    {
        public string pod { get; set; }

        public override string ToString()
        {
            return $"Part of the day (n - night, d - day): {pod}";
        }
    }
}
