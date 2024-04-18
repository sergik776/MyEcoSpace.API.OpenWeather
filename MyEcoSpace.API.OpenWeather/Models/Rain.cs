using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather.Models
{
    public class Rain
    {
        public double _3h { get; set; }

        public override string ToString()
        {
            return $"Rain (last 3 hours): {_3h}";
        }
    }
}
