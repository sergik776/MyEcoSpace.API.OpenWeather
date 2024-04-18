using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather.Models
{
    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
        public int humidity { get; set; }
        public double temp_kf { get; set; }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append("Temp: ");
            SB.Append(temp);
            SB.Append(", Feels like: ");
            SB.Append(feels_like);
            SB.Append(", Temp Min: ");
            SB.Append(temp_min);
            SB.Append(", Temp Max: ");
            SB.Append(temp_max);
            SB.Append(", Pressure: ");
            SB.Append(pressure);
            SB.Append(", Pressure on sea level: ");
            SB.Append(sea_level);
            SB.Append(", Pressure on ground level: ");
            SB.Append(grnd_level);
            SB.Append(", Internal: ");
            SB.Append(temp_kf);

            return SB.ToString();
        }
    }
}
