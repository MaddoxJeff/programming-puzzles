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


        string detailSummary { get; set; }

        string icon { get; set; }

        string tempLow { get; set; }

        string tempHigh { get; set; }

        string tempLowTime { get; set; }

        string tempHighTime { get; set; }

        string precMaxTime { get; set; }

        string cloudCover { get; set; }

        string dewPoint { get; set; }

        string moonPhase { get; set; }

        string timeUp { get; set; }



        public Weather(string Summary, string Temp, string Humidity, string Pressure, string WindSpeed, string WindGust, string WindBearing, string Time, string PrecipProbability, string OffSet,
            string Time0, string DetailSummary, string Icon, string TempLow, string TempHigh, string TempLowTime, string TempHighTime, string PrecMaxTime, string CloudCover, string DewPoint,
            string MoonPhase)
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
            detailSummary = DetailSummary;
            icon = Icon;
            tempLow = TempLow;
            tempHigh = TempHigh;
            tempLowTime = TempLowTime;
            tempHighTime = TempHighTime;
            precMaxTime = PrecMaxTime;
            cloudCover = CloudCover;
            dewPoint = DewPoint;
            moonPhase = MoonPhase;
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

        public string getIcon()
        {
            return icon;
        }
        public string getMoonPhase()
        {
            return moonPhase;
        }
        public string getWindGust()
        {
            return windGust;
        }
        public string getWindBearing()
        {
            string str = windBearing;
            str += @" °";
            return str;
        }
        public string getRainTime()
        {
            double OffSet = 0;
            Double.TryParse(offSet, out OffSet);
            double d = 0;
            Double.TryParse(precMaxTime, out d);
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
        public string getCloudCover()
        {
            return cloudCover;
        }
        public string getPressure()
        {
            return pressure;
        }
        public string getDewPoint()
        {
            return dewPoint;
        }
        public string getSummaryDetails()
        {
            return detailSummary;
        }
        public string getTempLow()
        {
            return tempLow;
        }
        public string getTempHigh()
        {
            return tempHigh;
        }
        public string getTempLowTime()
        {
            double OffSet = 0;
            Double.TryParse(offSet, out OffSet);
            double d = 0;
            Double.TryParse(tempLowTime, out d);
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
        public string getTempHighTime()
        {
            double OffSet = 0;
            Double.TryParse(offSet, out OffSet);
            double d = 0;
            Double.TryParse(tempHighTime, out d);
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
        public string getRawTime()
        {
            return time;
        }
        public string getOffSet()
        {
            return offSet;
        }

        public string getSpecTime(string t, string awf)
        {
            double OffSet = 0;
            Double.TryParse(awf, out OffSet);
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
