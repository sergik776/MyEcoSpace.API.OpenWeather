using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather.Models
{
    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }

        public override string ToString()
        {
            return $"ID: {id}, Group: {main}, Condition: {description}, IconID: {icon}";
        }
    }
}
