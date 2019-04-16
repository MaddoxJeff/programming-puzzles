using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace API_Proj3
{


    public partial class Form1 : Form 
    {


        public Boolean isClicked = false;    
        public int k = 0;
        public Form1()
        {
            InitializeComponent();

            #region adjustText

            labelTime.Font = new Font("Arial", 24, FontStyle.Bold);
            labelCity.Font = new Font("Arial", 24, FontStyle.Bold);
            labelState.Font = new Font("Arial", 24, FontStyle.Bold);
            labelDate.Font = new Font("Arial", 24, FontStyle.Bold);
            labelTemp.Font = new Font("Arial", 30, FontStyle.Bold);
            labelPrecipitation.Font = new Font("Arial", 24, FontStyle.Bold);
            labelWind.Font = new Font("Arial", 24, FontStyle.Bold);
            labelHumidity.Font = new Font("Arial", 24, FontStyle.Bold);
            labelSummary.Font = new Font("Arial", 30, FontStyle.Bold);
            labelTimeZone.Font = new Font("Arial", 24, FontStyle.Bold);

            #endregion



        }

        #region UI Event handler


        
        private void button1_Click(object sender, EventArgs e)
        {
            
            RestClient rClient = new RestClient();
            RestClient zipClient = new RestClient();
            zipClient.endPoint = "https://www.zipcodeapi.com/rest/dTOqa2Hsg7pPyYdlVfexivWireVmI0WrFzCw9WLNBVGLPEqQktJI0vGILabagKC7/info.json/" + textBoxRestURI.Text + "/degrees";
            string strCoordinates = string.Empty;
            strCoordinates = zipClient.makeRequest();
            dynamic zipData = JObject.Parse(strCoordinates);

            Location l = new Location(zipData.city.ToString(), zipData.state.ToString(), zipData.lat.ToString(), zipData.lng.ToString(), zipData.timezone.timezone_abbr.ToString(),
            zipData.timezone.utc_offset_sec.ToString());

            rClient.endPoint = "https://api.darksky.net/forecast/37a66de95c083bf850d6c997a34191aa/" + l.getLatitude() + "," + l.getLongitude();                   
            string strResponse = string.Empty;          
            strResponse = rClient.makeRequest();           
            dynamic data = JObject.Parse(strResponse);
            
            Weather w = new Weather(data.currently.summary.ToString(), data.currently.temperature.ToString(), data.currently.humidity.ToString(), 
            data.currently.pressure.ToString(), data.currently.windSpeed.ToString(), data.currently.windGust.ToString(), data.currently.windBearing.ToString(), 
            data.currently.time.ToString(), data.currently.precipProbability.ToString(), zipData.timezone.utc_offset_sec.ToString(), data.hourly.data[0].time.ToString(), data.hourly.data[1].time.ToString(), data.hourly.data[2].time.ToString(),
            data.hourly.data[3].time.ToString(), data.hourly.data[4].time.ToString());

            Weather hour0 = new Weather(data.hourly.data[k].summary.ToString(), data.hourly.data[k].temperature.ToString(), data.hourly.data[k].humidity.ToString(), 
            data.hourly.data[k].pressure.ToString(), data.hourly.data[k].windSpeed.ToString(), data.hourly.data[k].precipProbability.ToString(), data.hourly.data[k].time.ToString());

            if (isClicked == true)
            {
                labelSummary.Text = hour0.getSummary();
                labelTemp.Text = hour0.getTemp();
                labelPrecipitation.Text = hour0.getPrecipProbability();
                labelWind.Text = hour0.getWind();
                labelHumidity.Text = hour0.getHumidity();
                labelTime.Text = hour0.getTime();
            }
            if (isClicked == false)
            {              
                #region Label Definitions

                labelTemp.Text = w.getTemp();
                labelCity.Text = l.getCity();
                labelState.Text = l.getState();
                labelTime.Text = w.getTime();
                labelDate.Text = w.getDate();
                labelPrecipitation.Text = w.getPrecipProbability();
                labelWind.Text = w.getWind();
                labelHumidity.Text = w.getHumidity();
                labelSummary.Text = w.getSummary();
                labelTimeZone.Text = l.getTimeZone();

                //Change label names or index names to match
                labelHour1.Text = w.getSpecTime(data.hourly.data[0].time.ToString());
                labelHour2.Text = w.getSpecTime(data.hourly.data[1].time.ToString());
                labelHour3.Text = w.getSpecTime(data.hourly.data[2].time.ToString());
                labelHour4.Text = w.getSpecTime(data.hourly.data[3].time.ToString());
                labelHour5.Text = w.getSpecTime(data.hourly.data[4].time.ToString());
                labelHour6.Text = w.getSpecTime(data.hourly.data[5].time.ToString());
                labelHour7.Text = w.getSpecTime(data.hourly.data[6].time.ToString());
                labelHour8.Text = w.getSpecTime(data.hourly.data[7].time.ToString());
                labelHour9.Text = w.getSpecTime(data.hourly.data[8].time.ToString());
                labelHour10.Text = w.getSpecTime(data.hourly.data[9].time.ToString());
                labelHour11.Text = w.getSpecTime(data.hourly.data[10].time.ToString());
                labelHour12.Text = w.getSpecTime(data.hourly.data[11].time.ToString());

                #endregion
            }
            isClicked = false;
            #region Label Visibility

            labelCity.Visible = true;
            labelState.Visible = true;
            labelDate.Visible = true;
            labelTime.Visible = true;
            labelTimeZone.Visible = true;
            labelTemp.Visible = true;
            labelPrecipitation.Visible = true;
            labelSummary.Visible = true;
            labelWind.Visible = true;
            labelHumidity.Visible = true;
            labelHumLab.Visible = true;
            labelWindLab.Visible = true;
            labelTempLab.Visible = true;
            labelSumLab.Visible = true;
            labelPercLab.Visible = true;

            #endregion

        }



        private void labelChange(int i)
        {
            
            //labelTemp.Text = 
        }

        private void labelHour4_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            isClicked = true;
            button1.PerformClick();


        }








        #endregion

        //   private void debugOutput(string strDebugText)
        //   {
        //       try
        //      {
        //  System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
        //    textBoxResponse.Text = textBoxResponse.Text + strDebugText + Environment.NewLine;
        //   textBoxResponse.SelectionStart = textBoxResponse.TextLength;
        //  textBoxResponse.ScrollToCaret();
        //  }
        //  catch (Exception ex)
        // {
        //     System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
        // }
        // }

    }
}
