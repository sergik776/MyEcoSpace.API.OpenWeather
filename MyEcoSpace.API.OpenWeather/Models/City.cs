using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather.Models
{
    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public int population { get; set; }
        public int timezone { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();
            SB.Append("ID: ");
            SB.Append(id);
            SB.Append(", Name: ");
            SB.Append(name);
            SB.Append(", Cord: ");
            SB.Append(coord.ToString());
            SB.Append(", Population: ");
            SB.Append(population);
            SB.Append(", TimeZone: ");
            SB.Append(timezone);
            SB.Append(", SunRise: ");
            SB.Append(sunrise);
            SB.Append(", SunSet: ");
            SB.Append(sunset);
            return SB.ToString();
        }
    }
}
