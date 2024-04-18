using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcoSpace.API.OpenWeather
{
    internal class EndPoints
    {
        public class GetPath
        {
            public static string ThreeDaysFiveHours(string lat, string lon, string api)
            {
                return $"/data/2.5/forecast?lat={lat}&lon={lon}&appid={api}&units=metric";
            }
        }
    }
}
