using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Proj3
{
    public class Location
    {
        string city { get; set; }
        string state { get; set; }
        string latitude { get; set; }
        string longitude { get; set; }
        string timeZone { get; set; }
        string utcOffset { get; set; }

        public Location(string City, string State, string Latitude, string Longitude, string TimeZone, string UtcOffset)
        {
            city = City;
            state = State;
            longitude = Longitude;
            latitude = Latitude;
            timeZone = TimeZone;
            utcOffset = UtcOffset;
        }

        public string getCity()
        {
            return city;
        }

        public string getState()
        {
            return state;
        }

        public string getLongitude()
        {
            return longitude;
        }

        public string getLatitude()
        {
            return latitude;
        }

        public string getOffset()
        {
            return utcOffset;
        }

        public string getTimeZone()
        {
            return timeZone;
        }
    }
}
