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

        public Weather[] timeChange = new Weather[12];
        public Label[] labTimeArr = new Label[12];
        public Label[] labValArr = new Label[36];
        public string[] Thime = new string[12];
        public string moon;
        public string icon;
        public string offSet;
        public string degree;
        public int k = 0;
        public int c;
        public Boolean clicked = false;
        
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
            labelSummaryDetails.Font = new Font("Arial", 20, FontStyle.Bold);
            labelHighTemp.Font = new Font("Arial", 24, FontStyle.Bold);
            labelLowTemp.Font = new Font("Arial", 24, FontStyle.Bold);
            labelLowTempTime.Font = new Font("Arial", 24, FontStyle.Bold);
            labelHighTempTime.Font = new Font("Arial", 24, FontStyle.Bold);
            labelWindBearing.Font = new Font("Arial", 24, FontStyle.Bold);
            labelWindGust.Font = new Font("Arial", 24, FontStyle.Bold);
            labelRainTime.Font = new Font("Arial", 24, FontStyle.Bold);
            labelPressure.Font = new Font("Arial", 24, FontStyle.Bold);
            labelDewPoint.Font = new Font("Arial", 24, FontStyle.Bold);
            labelCloudCover.Font = new Font("Arial", 24, FontStyle.Bold);
            labelMoonPhase.Font = new Font("Arial", 24, FontStyle.Bold);
            labelMoonName.Font = new Font("Arial", 20, FontStyle.Bold);


            #endregion



        }

       


        
        private void button1_Click(object sender, EventArgs e)
        {
            #region Base cases
            //base case
            if (clicked == true)
            {
                buttonSwitch();
                Bitmap b = new Bitmap(pictureBoxArrow.Image);
                float deg = float.Parse(degree.Remove(degree.Length - 2), System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                pictureBoxArrow.Image = RotateImage(b, (360%deg));
                pictureBoxArrow.Visible = false;
            }
            buttonMoon.Enabled = true;
            buttonWind.Enabled = true;
            buttonRain.Enabled = true;
            buttonTemp.Enabled = true;
            #endregion


            #region Api & Object Init

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
            data.currently.time.ToString(), data.currently.precipProbability.ToString(), zipData.timezone.utc_offset_sec.ToString(), data.hourly.data[0].time.ToString(),
            data.daily.data[0].summary.ToString(), data.currently.icon.ToString(), data.daily.data[0].temperatureLow.ToString(), data.daily.data[0].temperatureHigh.ToString(),
            data.daily.data[0].temperatureLowTime.ToString(), data.daily.data[0].temperatureHighTime.ToString(), data.daily.data[0].precipIntensityMaxTime.ToString(),
            data.daily.data[0].cloudCover.ToString(), data.daily.data[0].dewPoint.ToString(), data.daily.data[0].moonPhase.ToString());
            
            
            offSet = w.getOffSet();
            
            for(int i = 0; i < 12; i++)
            {
                timeChange[i] = new Weather(data.hourly.data[i].summary.ToString(), data.hourly.data[i].temperature.ToString(), data.hourly.data[k].humidity.ToString(),
            data.hourly.data[i].pressure.ToString(), data.hourly.data[i].windSpeed.ToString(), data.hourly.data[i].precipProbability.ToString(), data.hourly.data[i].time.ToString());
                Thime[i] = timeChange[i].getRawTime();
            }

            #endregion

            #region init Array values

            labTimeArr[0] = labelHour0;
            labTimeArr[1] = labelHour1;
            labTimeArr[2] = labelHour2;
            labTimeArr[3] = labelHour3;
            labTimeArr[4] = labelHour4;
            labTimeArr[5] = labelHour5;
            labTimeArr[6] = labelHour6;
            labTimeArr[7] = labelHour7;
            labTimeArr[8] = labelHour8;
            labTimeArr[9] = labelHour9;
            labTimeArr[10] = labelHour10;
            labTimeArr[11] = labelHour11;

            labValArr[0] = labelCity;
            labValArr[1] = labelState;
            labValArr[2] = labelDate;
            labValArr[3] = labelTime;
            labValArr[4] = labelTimeZone;
            labValArr[5] = labelTemp;
            labValArr[6] = labelPrecipitation;
            labValArr[7] = labelSummary;
            labValArr[8] = labelWind;
            labValArr[9] = labelHumidity;
            labValArr[10] = labelHumLab;
            labValArr[11] = labelWindLab;
            labValArr[12] = labelTempLab;
            labValArr[13] = labelSumLab;
            labValArr[14] = labelPercLab;
            labValArr[15] = labelSummaryDetails;
            labValArr[16] = labelLowDisplay;
            labValArr[17] = labelHighDisplay;
            labValArr[18] = labelLowTemp;
            labValArr[19] = labelHighTemp;
            labValArr[20] = labelLowTempTime;
            labValArr[21] = labelHighTempTime;
            labValArr[22] = labelRainDisplay;
            labValArr[23] = labelCloudCoverDisplay;
            labValArr[24] = labelPressureDisplay;
            labValArr[25] = labelDewPointDisplay;
            labValArr[26] = labelRainTime;
            labValArr[27] = labelCloudCover;
            labValArr[28] = labelPressure;
            labValArr[29] = labelDewPoint;
            labValArr[30] = labelWindBearingDisplay;
            labValArr[31] = labelWindGustDisplay;
            labValArr[32] = labelWindBearing;
            labValArr[33] = labelWindGust;
            labValArr[34] = labelMoonPhaseDisplay;
            labValArr[35] = labelMoonPhase;
            icon = w.getIcon();

            #endregion


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
            labelSummaryDetails.Text = w.getSummaryDetails();
            labelLowTemp.Text = w.getTempLow();
            labelHighTemp.Text = w.getTempHigh();
            labelLowTempTime.Text = w.getTempLowTime();
            labelHighTempTime.Text = w.getTempHighTime();
            labelCloudCover.Text = w.getCloudCover();
            labelRainTime.Text = w.getRainTime();
            labelPressure.Text = w.getPressure();
            labelDewPoint.Text = w.getDewPoint();
            labelWindBearing.Text = w.getWindBearing();
            labelWindGust.Text = w.getWindGust();
            labelMoonPhase.Text = w.getMoonPhase();
            degree = w.getWindBearing();

                for (int i = 0; i < 12; i++)
                {
                    labTimeArr[i].Text = w.getSpecTime(data.hourly.data[i].time.ToString(),offSet);
                }


                #endregion
            

            #region Label Visibility

            for(int i = 0; i < 15; i++)
            {
                labValArr[i].Visible = true;
            }
            for(int i = 0; i < 12; i++)
            {
                labTimeArr[i].Visible = true;
            }


            //c resets the value for how many times "Wind Analysis" is clicked
            clicked = true;
            c = 0;

            #endregion

        }

        #region Time Label Clicks

        private void labelChange(int i)
        {
            labValArr[7].Text = timeChange[i].getSummary();
            labValArr[5].Text = timeChange[i].getTemp();
            labValArr[6].Text = timeChange[i].getPrecipProbability();
            labValArr[8].Text = timeChange[i].getWind();
            labValArr[9].Text = timeChange[i].getHumidity();
            labValArr[3].Text = timeChange[i].getSpecTime(Thime[i], offSet);
        }

        private void LabelHour0_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);

            k = x;
            labelChange(x);
        }

        private void LabelHour1_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            labelChange(x);
        }

        private void LabelHour2_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            labelChange(x);
        }

        private void LabelHour3_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            labelChange(x);
        }

        private void LabelHour4_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            labelChange(x);
        }

        private void LabelHour5_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            labelChange(x);
        }

        private void LabelHour6_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            labelChange(x);
        }

        private void LabelHour7_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            labelChange(x);
        }

        private void LabelHour8_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            labelChange(x);
        }

        private void LabelHour9_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            labelChange(x);
        }

        private void LabelHour10_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            labelChange(10);
        }

        private void LabelHour11_Click_1(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            string name = lbl.Name;
            string num = name.Substring(name.Length - 1);
            int x = 0;
            Int32.TryParse(num, out x);
            k = x;
            labelChange(11);
        }

        #endregion


        #region Side Buttons


        private void buttonSwitch()
        {
            for (int i = 15; i < 36; i++)
            {
                labValArr[i].Visible = false;
            }
            pictureBoxArrow.Visible = false;
            pictureBoxMoon.Visible = false;
            pictureBoxIcon.Visible = false;
            labelMoonName.Visible = false;
        }
        private void ButtonTemp_Click(object sender, EventArgs e)
        {
            buttonSwitch();
            pictureBoxIcon.Visible = true;
            for (int i = 15; i < 22; i++)
            {
                labValArr[i].Visible = true;
            }
            checkIcon();

        }

        private void ButtonRain_Click(object sender, EventArgs e)
        {
            buttonSwitch();
            for (int i = 22; i < 30; i++)
            {
                labValArr[i].Visible = true;
            }
        }

        private void ButtonWind_Click(object sender, EventArgs e)
        {
            buttonSwitch();
            pictureBoxArrow.Visible = true;

            for (int i = 30; i < 34; i++)
            {
                labValArr[i].Visible = true;
            }
            //base case
            if (c == 0)
            {
                Bitmap b = new Bitmap(pictureBoxArrow.Image);
                float deg = float.Parse(degree.Remove(degree.Length - 2), System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                pictureBoxArrow.Image = RotateImage(b, deg);
            }
            c++;                         
        }

        private void ButtonMoon_Click(object sender, EventArgs e)
        {
            buttonSwitch();
            pictureBoxMoon.Visible = true;
            labelMoonName.Visible = true;

            for (int i = 34; i < 36; i++)
            {
                labValArr[i].Visible = true;
            }
            checkMoon();
            labelMoonName.Text = moon;
        }

        public void checkIcon()
        {
            if(icon == "clear-day")
            {
                pictureBoxIcon.Image = Properties.Resources.Sunny;
            }
            if (icon == "night")
            {
                pictureBoxIcon.Image = Properties.Resources.Clear_sky_night;
            }
            if (icon == "rain")
            {
                pictureBoxIcon.Image = Properties.Resources.rain;
            }
            if (icon == "snow")
            {
                pictureBoxIcon.Image = Properties.Resources.Snowy;
            }
            if (icon == "wind")
            {
                pictureBoxIcon.Image = Properties.Resources.Windy;
            }
            if (icon == "sleet")
            {
                pictureBoxIcon.Image = Properties.Resources.Sleet;
            }
            if (icon == "fog")
            {
                pictureBoxIcon.Image = Properties.Resources.Foggy;
            }
            if (icon == "cloudy")
            {
                pictureBoxIcon.Image = Properties.Resources.Cloudy;
            }
            if (icon == "partly-cloudy-day")
            {
                pictureBoxIcon.Image = Properties.Resources.Partly_Cloudy;
            }
            if (icon == "partly-cloudy-night")
            {
                pictureBoxIcon.Image = Properties.Resources.Cloudy_night;
            }
        }
        private void checkMoon()
        {
            
            double x = 0;
            string str = labValArr[35].Text;
            double.TryParse(str, out x);
            if (x >= 0.00 || x <= 0.09)
            {
                pictureBoxMoon.Image = Properties.Resources._10;
                moon = "New Moon";
            }
            if (x >= 0.10 && x <= 0.24)
            {
                pictureBoxMoon.Image = Properties.Resources._30;
                moon = "Waxing Cresent";
            }
            if (x >= 0.25 && x <= 0.39)
            {
                pictureBoxMoon.Image = Properties.Resources._40;
                moon = "First Quarter";
            }
            if (x >= 0.40 && x <= 0.49)
            {
                pictureBoxMoon.Image = Properties.Resources._45;
                moon = "Waxing Gibbous";
            }
            if (x >= 0.50 && x <= 0.55)
            {
                pictureBoxMoon.Image = Properties.Resources.Full;
                moon = "Full Moon";
            }
            if (x >= 0.56 && x <= 0.69)
            {
                pictureBoxMoon.Image = Properties.Resources._60;
                moon = "Waning Gibbous";
            }
            if (x >= 0.70 && x <= 0.79)
            {
                pictureBoxMoon.Image = Properties.Resources._70;
                moon = "Third Quarter";
            }
            if (x >= 0.80 && x <= 0.85)
            {
                pictureBoxMoon.Image = Properties.Resources._80;
                moon = "Third Quarter";
            }
            if (x >= 0.86 && x <= 0.94)
            {
                pictureBoxMoon.Image = Properties.Resources._90;
                moon = "Waning Cresent";
            }
            if (x >= 0.95 && x <= 0.99)
            {
                pictureBoxMoon.Image = Properties.Resources._95;
                moon = "Waning Cresent";
            }

        }

        #endregion 

        #region Rotation methods
        private Bitmap RotateImage(Bitmap bmp, float angle)
        {
            float height = bmp.Height;
            float width = bmp.Width;
            int hypotenuse = System.Convert.ToInt32(System.Math.Floor(Math.Sqrt(height * height + width * width)));
            Bitmap rotatedImage = new Bitmap(hypotenuse, hypotenuse);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform((float)rotatedImage.Width / 2, (float)rotatedImage.Height / 2); //set the rotation point as the center into the matrix
                g.RotateTransform(angle); //rotate
                g.TranslateTransform(-(float)rotatedImage.Width / 2, -(float)rotatedImage.Height / 2); //restore rotation point into the matrix
                g.DrawImage(bmp, (hypotenuse - width) / 2, (hypotenuse - height) / 2, width, height);
            }
            return rotatedImage;
        }

        public void resetRotation(Bitmap b, float f)
        {
            RotateImage(b, Math.Abs(f));
        }


        #endregion


    }
}
