using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather.Models
{
    public class WeatherForecast
    {
        public long dt { get; set; }
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public Clouds clouds { get; set; }
        public Wind wind { get; set; }
        public int visibility { get; set; }
        public double pop { get; set; }
        public Rain rain { get; set; }
        public Sys sys { get; set; }
        public DateTime dt_txt { get; set; }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();

            SB.Append("Time: ");
            SB.Append(dt.ToString());
            SB.Append(", Main: ");
            SB.AppendLine(main.ToString());
            foreach(var w in weather)
            {
                SB.AppendLine("Weather: ");
                SB.Append(w.ToString());
            }
            SB.Append(", Clouds: ");
            SB.Append(clouds.ToString());
            SB.Append(", Wind: ");
            SB.Append(wind);
            SB.Append(", Visibility: ");
            SB.Append(visibility);
            SB.Append(", Probability of precipitation:");
            SB.Append(pop);
            SB.Append(", Rain: ");
            SB.Append(rain);
            SB.Append(", SYS: ");
            SB.Append(sys.ToString());
            SB.Append(", Time: ");
            SB.Append(dt_txt);

            return SB.ToString();
        }
    }
}
