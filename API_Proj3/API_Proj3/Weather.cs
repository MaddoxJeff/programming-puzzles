using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Proj3
{
    public class Weather
    {
        string summary { get; set; }
        string temp { get; set; }
        string humidity { get; set; }
        string pressure { get; set; }
        string windSpeed { get; set; }
        string windGust { get; set; }
        string windBearing { get; set; }
        string time { get; set; }
        string precipProbability { get; set; }
        string offSet { get; set; }

        string time0 { get; set; }
        string time1 { get; set; }
        string time2 { get; set; }
        string time3 { get; set; }
        string time4 { get; set; }



        public Weather(string Summary, string Temp, string Humidity, string Pressure, string WindSpeed, string WindGust, string WindBearing, string Time, string PrecipProbability, string OffSet,
            string Time0, string Time1, string Time2, string Time3, string Time4)
        {
            summary = Summary;
            temp = Temp;
            humidity = Humidity;
            pressure = Pressure;
            windSpeed = WindSpeed;
            windGust = WindGust;
            windBearing = WindBearing;
            time = Time;
            precipProbability = PrecipProbability;
            offSet = OffSet;
            time0 = Time0;
            time1 = Time1;
            time2 = Time2;
            time3 = Time3;
            time4 = Time4;
        }

        public Weather(string Summary, string Temp, string Humidity, string Pressure, string WindSpeed, string PrecipProbability, string Time)
        {
            summary = Summary;
            temp = Temp;
            humidity = Humidity;
            pressure = Pressure;
            windSpeed = WindSpeed;
            precipProbability = PrecipProbability;
            time = Time;
        }



        public string getSpecTime(string t)
        {
            double OffSet = 0;
            Double.TryParse(offSet, out OffSet);
            double d = 0;
            Double.TryParse(t, out d);
            d += OffSet;
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(d).ToUniversalTime();
            string temp = dtDateTime.ToString();
            string result = temp.Remove(0, 10);
            string res2 = "";
            string last2 = result.Substring(result.Length - 2);

            if (result.Length == 10)
            {
                res2 = result.Substring(0, 4);
                res2 += @" " + last2;
            }
                
            if (result.Length == 11)
            {
                res2 = result.Substring(0, 5);
                res2 += @" " + last2;
            }
                
            return res2;
        }

        public string getTemp()
        {
            string str = temp;
            str += @" °F";
            return str;
        }

        public string getTime()
        {
            double OffSet = 0;
            Double.TryParse(offSet, out OffSet);
            double d = 0;
            Double.TryParse(time, out d);
            d += OffSet;     
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(d).ToUniversalTime();                               
            string temp = dtDateTime.ToString();
            string result = temp.Remove(0, 10);
            return result;
        }

        
        public string getDate()
        {
            double OffSet = 0;
            Double.TryParse(offSet, out OffSet);
            double d = 0;
            Double.TryParse(time, out d);
            d += OffSet;
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(d).ToUniversalTime();
            string temp = dtDateTime.ToString();
            string result = temp.Substring(0, 9);
            return result;
        }

        public string getPrecipProbability()
        {
            string str = precipProbability;
            str += @" %";
            return str;
        }

        public string getWind()
        {
            string str = windSpeed;
            str += @" mph";
            return str;
        }

        public string getHumidity()
        {
            string str = humidity;
            str += @" %";
            return str;
        }

        public string getSummary()
        {
            return summary;
        }

    }
}
