using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyEcoSpace.API.OpenWeather.Models
{
    public class FiveDaysThreeHoursResponse
    {
        public string cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
        public List<WeatherForecast> list { get; set; }
        public City city { get; set; }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();
            SB.Append("internal: ");
            SB.Append(cod);
            SB.Append(", Message: ");
            SB.Append(message);
            SB.Append(", Timestamp: ");
            SB.Append(cnt);
            foreach(var w in list)
            {
                SB.AppendLine("\nWeather: ");
                SB.Append(w.ToString());
            }
            SB.AppendLine(", City: ");
            SB.Append(city.ToString());

            return SB.ToString();
        }
    }
}
