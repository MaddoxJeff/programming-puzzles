namespace API_Proj3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPrecipitation = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelTimeZone = new System.Windows.Forms.Label();
            this.labelSumLab = new System.Windows.Forms.Label();
            this.labelTempLab = new System.Windows.Forms.Label();
            this.labelPercLab = new System.Windows.Forms.Label();
            this.labelHumLab = new System.Windows.Forms.Label();
            this.labelWindLab = new System.Windows.Forms.Label();
            this.labelHour0 = new System.Windows.Forms.Label();
            this.labelHour1 = new System.Windows.Forms.Label();
            this.labelHour2 = new System.Windows.Forms.Label();
            this.labelHour3 = new System.Windows.Forms.Label();
            this.labelHour4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRestURI = new System.Windows.Forms.TextBox();
            this.buttonWind = new System.Windows.Forms.Button();
            this.buttonRain = new System.Windows.Forms.Button();
            this.buttonMoon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTemp = new System.Windows.Forms.Button();
            this.labelHour5 = new System.Windows.Forms.Label();
            this.labelHour6 = new System.Windows.Forms.Label();
            this.labelHour7 = new System.Windows.Forms.Label();
            this.labelHour8 = new System.Windows.Forms.Label();
            this.labelHour9 = new System.Windows.Forms.Label();
            this.labelHour10 = new System.Windows.Forms.Label();
            this.labelHour11 = new System.Windows.Forms.Label();
            this.labelSummaryDetails = new System.Windows.Forms.Label();
            this.labelLowTemp = new System.Windows.Forms.Label();
            this.labelHighTemp = new System.Windows.Forms.Label();
            this.labelHighDisplay = new System.Windows.Forms.Label();
            this.labelLowDisplay = new System.Windows.Forms.Label();
            this.labelHighTempTime = new System.Windows.Forms.Label();
            this.labelLowTempTime = new System.Windows.Forms.Label();
            this.labelRainDisplay = new System.Windows.Forms.Label();
            this.labelCloudCoverDisplay = new System.Windows.Forms.Label();
            this.labelPressureDisplay = new System.Windows.Forms.Label();
            this.labelDewPointDisplay = new System.Windows.Forms.Label();
            this.labelCloudCover = new System.Windows.Forms.Label();
            this.labelRainTime = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelDewPoint = new System.Windows.Forms.Label();
            this.labelWindGustDisplay = new System.Windows.Forms.Label();
            this.labelWindGust = new System.Windows.Forms.Label();
            this.labelWindBearingDisplay = new System.Windows.Forms.Label();
            this.labelWindBearing = new System.Windows.Forms.Label();
            this.labelMoonPhaseDisplay = new System.Windows.Forms.Label();
            this.labelMoonPhase = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.labelMoonName = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelCity.Location = new System.Drawing.Point(352, 50);
            this.labelCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(49, 25);
            this.labelCity.TabIndex = 9;
            this.labelCity.Text = "City";
            this.labelCity.Visible = false;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelState.Location = new System.Drawing.Point(352, 108);
            this.labelState.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(62, 25);
            this.labelState.TabIndex = 10;
            this.labelState.Text = "State";
            this.labelState.Visible = false;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelTemp.Location = new System.Drawing.Point(352, 533);
            this.labelTemp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(66, 25);
            this.labelTemp.TabIndex = 11;
            this.labelTemp.Text = "Temp";
            this.labelTemp.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelDate.Location = new System.Drawing.Point(896, 50);
            this.labelDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(57, 25);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Date";
            this.labelDate.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelTime.Location = new System.Drawing.Point(896, 108);
            this.labelTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(59, 25);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "Time";
            this.labelTime.Visible = false;
            // 
            // labelPrecipitation
            // 
            this.labelPrecipitation.AutoSize = true;
            this.labelPrecipitation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelPrecipitation.Location = new System.Drawing.Point(919, 327);
            this.labelPrecipitation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPrecipitation.Name = "labelPrecipitation";
            this.labelPrecipitation.Size = new System.Drawing.Size(129, 25);
            this.labelPrecipitation.TabIndex = 15;
            this.labelPrecipitation.Text = "precipitation";
            this.labelPrecipitation.Visible = false;
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelWind.Location = new System.Drawing.Point(919, 616);
            this.labelWind.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(61, 25);
            this.labelWind.TabIndex = 16;
            this.labelWind.Text = "Wind";
            this.labelWind.Visible = false;
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelHumidity.Location = new System.Drawing.Point(919, 477);
            this.labelHumidity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(95, 25);
            this.labelHumidity.TabIndex = 17;
            this.labelHumidity.Text = "Humidity";
            this.labelHumidity.Visible = false;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelSummary.Location = new System.Drawing.Point(352, 327);
            this.labelSummary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(102, 25);
            this.labelSummary.TabIndex = 18;
            this.labelSummary.Text = "Summary";
            this.labelSummary.Visible = false;
            // 
            // labelTimeZone
            // 
            this.labelTimeZone.AutoSize = true;
            this.labelTimeZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelTimeZone.Location = new System.Drawing.Point(1294, 108);
            this.labelTimeZone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTimeZone.Name = "labelTimeZone";
            this.labelTimeZone.Size = new System.Drawing.Size(101, 25);
            this.labelTimeZone.TabIndex = 19;
            this.labelTimeZone.Text = "timeZone";
            this.labelTimeZone.Visible = false;
            // 
            // labelSumLab
            // 
            this.labelSumLab.AutoSize = true;
            this.labelSumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumLab.Location = new System.Drawing.Point(352, 275);
            this.labelSumLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSumLab.Name = "labelSumLab";
            this.labelSumLab.Size = new System.Drawing.Size(131, 30);
            this.labelSumLab.TabIndex = 22;
            this.labelSumLab.Text = "Summary";
            this.labelSumLab.Visible = false;
            // 
            // labelTempLab
            // 
            this.labelTempLab.AutoSize = true;
            this.labelTempLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempLab.Location = new System.Drawing.Point(352, 477);
            this.labelTempLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTempLab.Name = "labelTempLab";
            this.labelTempLab.Size = new System.Drawing.Size(171, 30);
            this.labelTempLab.TabIndex = 23;
            this.labelTempLab.Text = "Temperature";
            this.labelTempLab.Visible = false;
            // 
            // labelPercLab
            // 
            this.labelPercLab.AutoSize = true;
            this.labelPercLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercLab.Location = new System.Drawing.Point(919, 275);
            this.labelPercLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPercLab.Name = "labelPercLab";
            this.labelPercLab.Size = new System.Drawing.Size(167, 30);
            this.labelPercLab.TabIndex = 24;
            this.labelPercLab.Text = "Percipitation";
            this.labelPercLab.Visible = false;
            // 
            // labelHumLab
            // 
            this.labelHumLab.AutoSize = true;
            this.labelHumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHumLab.Location = new System.Drawing.Point(919, 428);
            this.labelHumLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHumLab.Name = "labelHumLab";
            this.labelHumLab.Size = new System.Drawing.Size(122, 30);
            this.labelHumLab.TabIndex = 25;
            this.labelHumLab.Text = "Humidity";
            this.labelHumLab.Visible = false;
            // 
            // labelWindLab
            // 
            this.labelWindLab.AutoSize = true;
            this.labelWindLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindLab.Location = new System.Drawing.Point(919, 561);
            this.labelWindLab.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWindLab.Name = "labelWindLab";
            this.labelWindLab.Size = new System.Drawing.Size(76, 30);
            this.labelWindLab.TabIndex = 26;
            this.labelWindLab.Text = "Wind";
            this.labelWindLab.Visible = false;
            // 
            // labelHour0
            // 
            this.labelHour0.AutoSize = true;
            this.labelHour0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour0.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour0.Location = new System.Drawing.Point(286, 923);
            this.labelHour0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour0.Name = "labelHour0";
            this.labelHour0.Size = new System.Drawing.Size(84, 37);
            this.labelHour0.TabIndex = 27;
            this.labelHour0.Text = "label";
            this.labelHour0.Visible = false;
            this.labelHour0.Click += new System.EventHandler(this.LabelHour0_Click_1);
            // 
            // labelHour1
            // 
            this.labelHour1.AutoSize = true;
            this.labelHour1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHour1.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour1.Location = new System.Drawing.Point(434, 923);
            this.labelHour1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour1.Name = "labelHour1";
            this.labelHour1.Size = new System.Drawing.Size(100, 37);
            this.labelHour1.TabIndex = 28;
            this.labelHour1.Text = "label1";
            this.labelHour1.Visible = false;
            this.labelHour1.Click += new System.EventHandler(this.LabelHour1_Click_1);
            // 
            // labelHour2
            // 
            this.labelHour2.AutoSize = true;
            this.labelHour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHour2.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour2.Location = new System.Drawing.Point(600, 923);
            this.labelHour2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour2.Name = "labelHour2";
            this.labelHour2.Size = new System.Drawing.Size(100, 37);
            this.labelHour2.TabIndex = 29;
            this.labelHour2.Text = "label1";
            this.labelHour2.Visible = false;
            this.labelHour2.Click += new System.EventHandler(this.LabelHour2_Click_1);
            // 
            // labelHour3
            // 
            this.labelHour3.AutoSize = true;
            this.labelHour3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHour3.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour3.Location = new System.Drawing.Point(786, 923);
            this.labelHour3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour3.Name = "labelHour3";
            this.labelHour3.Size = new System.Drawing.Size(100, 37);
            this.labelHour3.TabIndex = 30;
            this.labelHour3.Text = "label1";
            this.labelHour3.Visible = false;
            this.labelHour3.Click += new System.EventHandler(this.LabelHour3_Click_1);
            // 
            // labelHour4
            // 
            this.labelHour4.AutoSize = true;
            this.labelHour4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHour4.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour4.Location = new System.Drawing.Point(974, 923);
            this.labelHour4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour4.Name = "labelHour4";
            this.labelHour4.Size = new System.Drawing.Size(100, 37);
            this.labelHour4.TabIndex = 31;
            this.labelHour4.Text = "label1";
            this.labelHour4.Visible = false;
            this.labelHour4.Click += new System.EventHandler(this.LabelHour4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.button1.Location = new System.Drawing.Point(0, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 131);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Weather";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxRestURI);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 171);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(2, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter ZipCode";
            // 
            // textBoxRestURI
            // 
            this.textBoxRestURI.Location = new System.Drawing.Point(24, 94);
            this.textBoxRestURI.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxRestURI.Name = "textBoxRestURI";
            this.textBoxRestURI.Size = new System.Drawing.Size(220, 31);
            this.textBoxRestURI.TabIndex = 0;
            // 
            // buttonWind
            // 
            this.buttonWind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.buttonWind.Enabled = false;
            this.buttonWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonWind.Location = new System.Drawing.Point(0, 523);
            this.buttonWind.Margin = new System.Windows.Forms.Padding(6);
            this.buttonWind.Name = "buttonWind";
            this.buttonWind.Size = new System.Drawing.Size(274, 131);
            this.buttonWind.TabIndex = 8;
            this.buttonWind.Text = "Wind Analysis";
            this.buttonWind.UseVisualStyleBackColor = false;
            this.buttonWind.Click += new System.EventHandler(this.ButtonWind_Click);
            // 
            // buttonRain
            // 
            this.buttonRain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.buttonRain.Enabled = false;
            this.buttonRain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonRain.Location = new System.Drawing.Point(0, 682);
            this.buttonRain.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRain.Name = "buttonRain";
            this.buttonRain.Size = new System.Drawing.Size(274, 131);
            this.buttonRain.TabIndex = 9;
            this.buttonRain.Text = "Rain Analysis";
            this.buttonRain.UseVisualStyleBackColor = false;
            this.buttonRain.Click += new System.EventHandler(this.ButtonRain_Click);
            // 
            // buttonMoon
            // 
            this.buttonMoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.buttonMoon.Enabled = false;
            this.buttonMoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonMoon.Location = new System.Drawing.Point(0, 845);
            this.buttonMoon.Margin = new System.Windows.Forms.Padding(6);
            this.buttonMoon.Name = "buttonMoon";
            this.buttonMoon.Size = new System.Drawing.Size(274, 126);
            this.buttonMoon.TabIndex = 10;
            this.buttonMoon.Text = "Moon Phase";
            this.buttonMoon.UseVisualStyleBackColor = false;
            this.buttonMoon.Click += new System.EventHandler(this.ButtonMoon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.buttonTemp);
            this.panel1.Controls.Add(this.buttonMoon);
            this.panel1.Controls.Add(this.buttonRain);
            this.panel1.Controls.Add(this.buttonWind);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 1002);
            this.panel1.TabIndex = 20;
            // 
            // buttonTemp
            // 
            this.buttonTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(66)))));
            this.buttonTemp.Enabled = false;
            this.buttonTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.buttonTemp.Location = new System.Drawing.Point(0, 361);
            this.buttonTemp.Margin = new System.Windows.Forms.Padding(6);
            this.buttonTemp.Name = "buttonTemp";
            this.buttonTemp.Size = new System.Drawing.Size(274, 131);
            this.buttonTemp.TabIndex = 11;
            this.buttonTemp.Text = "Temp Details";
            this.buttonTemp.UseVisualStyleBackColor = false;
            this.buttonTemp.Click += new System.EventHandler(this.ButtonTemp_Click);
            // 
            // labelHour5
            // 
            this.labelHour5.AutoSize = true;
            this.labelHour5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHour5.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour5.Location = new System.Drawing.Point(1144, 923);
            this.labelHour5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour5.Name = "labelHour5";
            this.labelHour5.Size = new System.Drawing.Size(100, 37);
            this.labelHour5.TabIndex = 32;
            this.labelHour5.Text = "label1";
            this.labelHour5.Visible = false;
            this.labelHour5.Click += new System.EventHandler(this.LabelHour5_Click_1);
            // 
            // labelHour6
            // 
            this.labelHour6.AutoSize = true;
            this.labelHour6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHour6.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour6.Location = new System.Drawing.Point(1314, 923);
            this.labelHour6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour6.Name = "labelHour6";
            this.labelHour6.Size = new System.Drawing.Size(102, 37);
            this.labelHour6.TabIndex = 33;
            this.labelHour6.Text = "label2";
            this.labelHour6.Visible = false;
            this.labelHour6.Click += new System.EventHandler(this.LabelHour6_Click_1);
            // 
            // labelHour7
            // 
            this.labelHour7.AutoSize = true;
            this.labelHour7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHour7.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour7.Location = new System.Drawing.Point(1472, 923);
            this.labelHour7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour7.Name = "labelHour7";
            this.labelHour7.Size = new System.Drawing.Size(102, 37);
            this.labelHour7.TabIndex = 34;
            this.labelHour7.Text = "label4";
            this.labelHour7.Visible = false;
            this.labelHour7.Click += new System.EventHandler(this.LabelHour7_Click_1);
            // 
            // labelHour8
            // 
            this.labelHour8.AutoSize = true;
            this.labelHour8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHour8.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour8.Location = new System.Drawing.Point(1632, 923);
            this.labelHour8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour8.Name = "labelHour8";
            this.labelHour8.Size = new System.Drawing.Size(102, 37);
            this.labelHour8.TabIndex = 35;
            this.labelHour8.Text = "label5";
            this.labelHour8.Visible = false;
            this.labelHour8.Click += new System.EventHandler(this.LabelHour8_Click_1);
            // 
            // labelHour9
            // 
            this.labelHour9.AutoSize = true;
            this.labelHour9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHour9.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour9.Location = new System.Drawing.Point(1804, 923);
            this.labelHour9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour9.Name = "labelHour9";
            this.labelHour9.Size = new System.Drawing.Size(102, 37);
            this.labelHour9.TabIndex = 36;
            this.labelHour9.Text = "label6";
            this.labelHour9.Visible = false;
            this.labelHour9.Click += new System.EventHandler(this.LabelHour9_Click_1);
            // 
            // labelHour10
            // 
            this.labelHour10.AutoSize = true;
            this.labelHour10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHour10.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour10.Location = new System.Drawing.Point(1954, 923);
            this.labelHour10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour10.Name = "labelHour10";
            this.labelHour10.Size = new System.Drawing.Size(102, 37);
            this.labelHour10.TabIndex = 37;
            this.labelHour10.Text = "label7";
            this.labelHour10.Visible = false;
            this.labelHour10.Click += new System.EventHandler(this.LabelHour10_Click_1);
            // 
            // labelHour11
            // 
            this.labelHour11.AutoSize = true;
            this.labelHour11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHour11.ForeColor = System.Drawing.Color.SpringGreen;
            this.labelHour11.Location = new System.Drawing.Point(2106, 923);
            this.labelHour11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHour11.Name = "labelHour11";
            this.labelHour11.Size = new System.Drawing.Size(102, 37);
            this.labelHour11.TabIndex = 38;
            this.labelHour11.Text = "label8";
            this.labelHour11.Visible = false;
            this.labelHour11.Click += new System.EventHandler(this.LabelHour11_Click_1);
            // 
            // labelSummaryDetails
            // 
            this.labelSummaryDetails.AutoSize = true;
            this.labelSummaryDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelSummaryDetails.Location = new System.Drawing.Point(1294, 306);
            this.labelSummaryDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSummaryDetails.Name = "labelSummaryDetails";
            this.labelSummaryDetails.Size = new System.Drawing.Size(165, 25);
            this.labelSummaryDetails.TabIndex = 39;
            this.labelSummaryDetails.Text = "summaryDetails";
            this.labelSummaryDetails.Visible = false;
            // 
            // labelLowTemp
            // 
            this.labelLowTemp.AutoSize = true;
            this.labelLowTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelLowTemp.Location = new System.Drawing.Point(1282, 698);
            this.labelLowTemp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLowTemp.Name = "labelLowTemp";
            this.labelLowTemp.Size = new System.Drawing.Size(154, 25);
            this.labelLowTemp.TabIndex = 40;
            this.labelLowTemp.Text = "lowtempdetails";
            this.labelLowTemp.Visible = false;
            // 
            // labelHighTemp
            // 
            this.labelHighTemp.AutoSize = true;
            this.labelHighTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelHighTemp.Location = new System.Drawing.Point(1282, 579);
            this.labelHighTemp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHighTemp.Name = "labelHighTemp";
            this.labelHighTemp.Size = new System.Drawing.Size(163, 25);
            this.labelHighTemp.TabIndex = 41;
            this.labelHighTemp.Text = "hightempdetails";
            this.labelHighTemp.Visible = false;
            // 
            // labelHighDisplay
            // 
            this.labelHighDisplay.AutoSize = true;
            this.labelHighDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighDisplay.Location = new System.Drawing.Point(1282, 523);
            this.labelHighDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHighDisplay.Name = "labelHighDisplay";
            this.labelHighDisplay.Size = new System.Drawing.Size(70, 30);
            this.labelHighDisplay.TabIndex = 42;
            this.labelHighDisplay.Text = "High";
            this.labelHighDisplay.Visible = false;
            // 
            // labelLowDisplay
            // 
            this.labelLowDisplay.AutoSize = true;
            this.labelLowDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLowDisplay.Location = new System.Drawing.Point(1282, 657);
            this.labelLowDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLowDisplay.Name = "labelLowDisplay";
            this.labelLowDisplay.Size = new System.Drawing.Size(63, 30);
            this.labelLowDisplay.TabIndex = 43;
            this.labelLowDisplay.Text = "Low";
            this.labelLowDisplay.Visible = false;
            // 
            // labelHighTempTime
            // 
            this.labelHighTempTime.AutoSize = true;
            this.labelHighTempTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelHighTempTime.Location = new System.Drawing.Point(1658, 579);
            this.labelHighTempTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHighTempTime.Name = "labelHighTempTime";
            this.labelHighTempTime.Size = new System.Drawing.Size(157, 25);
            this.labelHighTempTime.TabIndex = 44;
            this.labelHighTempTime.Text = "HighTempTime";
            this.labelHighTempTime.Visible = false;
            // 
            // labelLowTempTime
            // 
            this.labelLowTempTime.AutoSize = true;
            this.labelLowTempTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelLowTempTime.Location = new System.Drawing.Point(1658, 698);
            this.labelLowTempTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLowTempTime.Name = "labelLowTempTime";
            this.labelLowTempTime.Size = new System.Drawing.Size(145, 25);
            this.labelLowTempTime.TabIndex = 45;
            this.labelLowTempTime.Text = "lowTempTime";
            this.labelLowTempTime.Visible = false;
            // 
            // labelRainDisplay
            // 
            this.labelRainDisplay.AutoSize = true;
            this.labelRainDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRainDisplay.Location = new System.Drawing.Point(1294, 428);
            this.labelRainDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRainDisplay.Name = "labelRainDisplay";
            this.labelRainDisplay.Size = new System.Drawing.Size(132, 30);
            this.labelRainDisplay.TabIndex = 46;
            this.labelRainDisplay.Text = "RainTime";
            this.labelRainDisplay.Visible = false;
            // 
            // labelCloudCoverDisplay
            // 
            this.labelCloudCoverDisplay.AutoSize = true;
            this.labelCloudCoverDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloudCoverDisplay.Location = new System.Drawing.Point(1294, 275);
            this.labelCloudCoverDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCloudCoverDisplay.Name = "labelCloudCoverDisplay";
            this.labelCloudCoverDisplay.Size = new System.Drawing.Size(167, 30);
            this.labelCloudCoverDisplay.TabIndex = 47;
            this.labelCloudCoverDisplay.Text = "Cloud Cover";
            this.labelCloudCoverDisplay.Visible = false;
            // 
            // labelPressureDisplay
            // 
            this.labelPressureDisplay.AutoSize = true;
            this.labelPressureDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPressureDisplay.Location = new System.Drawing.Point(1691, 275);
            this.labelPressureDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPressureDisplay.Name = "labelPressureDisplay";
            this.labelPressureDisplay.Size = new System.Drawing.Size(124, 30);
            this.labelPressureDisplay.TabIndex = 48;
            this.labelPressureDisplay.Text = "Pressure";
            this.labelPressureDisplay.Visible = false;
            // 
            // labelDewPointDisplay
            // 
            this.labelDewPointDisplay.AutoSize = true;
            this.labelDewPointDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDewPointDisplay.Location = new System.Drawing.Point(1691, 423);
            this.labelDewPointDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDewPointDisplay.Name = "labelDewPointDisplay";
            this.labelDewPointDisplay.Size = new System.Drawing.Size(139, 30);
            this.labelDewPointDisplay.TabIndex = 49;
            this.labelDewPointDisplay.Text = "Dew Point";
            this.labelDewPointDisplay.Visible = false;
            // 
            // labelCloudCover
            // 
            this.labelCloudCover.AutoSize = true;
            this.labelCloudCover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelCloudCover.Location = new System.Drawing.Point(1294, 327);
            this.labelCloudCover.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCloudCover.Name = "labelCloudCover";
            this.labelCloudCover.Size = new System.Drawing.Size(191, 25);
            this.labelCloudCover.TabIndex = 50;
            this.labelCloudCover.Text = "CloudCoverDetails";
            this.labelCloudCover.Visible = false;
            // 
            // labelRainTime
            // 
            this.labelRainTime.AutoSize = true;
            this.labelRainTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelRainTime.Location = new System.Drawing.Point(1282, 477);
            this.labelRainTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRainTime.Name = "labelRainTime";
            this.labelRainTime.Size = new System.Drawing.Size(169, 25);
            this.labelRainTime.TabIndex = 51;
            this.labelRainTime.Text = "RainTimeDetails";
            this.labelRainTime.Visible = false;
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelPressure.Location = new System.Drawing.Point(1691, 336);
            this.labelPressure.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(164, 25);
            this.labelPressure.TabIndex = 52;
            this.labelPressure.Text = "PressureDetails";
            this.labelPressure.Visible = false;
            // 
            // labelDewPoint
            // 
            this.labelDewPoint.AutoSize = true;
            this.labelDewPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelDewPoint.Location = new System.Drawing.Point(1691, 482);
            this.labelDewPoint.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDewPoint.Name = "labelDewPoint";
            this.labelDewPoint.Size = new System.Drawing.Size(169, 25);
            this.labelDewPoint.TabIndex = 53;
            this.labelDewPoint.Text = "DewPointDetails";
            this.labelDewPoint.Visible = false;
            // 
            // labelWindGustDisplay
            // 
            this.labelWindGustDisplay.AutoSize = true;
            this.labelWindGustDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindGustDisplay.Location = new System.Drawing.Point(1297, 276);
            this.labelWindGustDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWindGustDisplay.Name = "labelWindGustDisplay";
            this.labelWindGustDisplay.Size = new System.Drawing.Size(134, 30);
            this.labelWindGustDisplay.TabIndex = 54;
            this.labelWindGustDisplay.Text = "WindGust";
            this.labelWindGustDisplay.Visible = false;
            // 
            // labelWindGust
            // 
            this.labelWindGust.AutoSize = true;
            this.labelWindGust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelWindGust.Location = new System.Drawing.Point(1294, 327);
            this.labelWindGust.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWindGust.Name = "labelWindGust";
            this.labelWindGust.Size = new System.Drawing.Size(172, 25);
            this.labelWindGust.TabIndex = 55;
            this.labelWindGust.Text = "WindGustDetails";
            this.labelWindGust.Visible = false;
            // 
            // labelWindBearingDisplay
            // 
            this.labelWindBearingDisplay.AutoSize = true;
            this.labelWindBearingDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWindBearingDisplay.Location = new System.Drawing.Point(1292, 428);
            this.labelWindBearingDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWindBearingDisplay.Name = "labelWindBearingDisplay";
            this.labelWindBearingDisplay.Size = new System.Drawing.Size(179, 30);
            this.labelWindBearingDisplay.TabIndex = 56;
            this.labelWindBearingDisplay.Text = "Wind Bearing";
            this.labelWindBearingDisplay.Visible = false;
            // 
            // labelWindBearing
            // 
            this.labelWindBearing.AutoSize = true;
            this.labelWindBearing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelWindBearing.Location = new System.Drawing.Point(1282, 477);
            this.labelWindBearing.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelWindBearing.Name = "labelWindBearing";
            this.labelWindBearing.Size = new System.Drawing.Size(201, 25);
            this.labelWindBearing.TabIndex = 57;
            this.labelWindBearing.Text = "WindBearingDetails";
            this.labelWindBearing.Visible = false;
            // 
            // labelMoonPhaseDisplay
            // 
            this.labelMoonPhaseDisplay.AutoSize = true;
            this.labelMoonPhaseDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoonPhaseDisplay.Location = new System.Drawing.Point(1297, 376);
            this.labelMoonPhaseDisplay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMoonPhaseDisplay.Name = "labelMoonPhaseDisplay";
            this.labelMoonPhaseDisplay.Size = new System.Drawing.Size(166, 30);
            this.labelMoonPhaseDisplay.TabIndex = 58;
            this.labelMoonPhaseDisplay.Text = "Moon Phase";
            this.labelMoonPhaseDisplay.Visible = false;
            // 
            // labelMoonPhase
            // 
            this.labelMoonPhase.AutoSize = true;
            this.labelMoonPhase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelMoonPhase.Location = new System.Drawing.Point(1297, 428);
            this.labelMoonPhase.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMoonPhase.Name = "labelMoonPhase";
            this.labelMoonPhase.Size = new System.Drawing.Size(193, 25);
            this.labelMoonPhase.TabIndex = 59;
            this.labelMoonPhase.Text = "MoonPhaseDetails";
            this.labelMoonPhase.Visible = false;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::API_Proj3.Properties.Resources.Cloudy_night;
            this.pictureBoxIcon.Location = new System.Drawing.Point(1598, 35);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(262, 235);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 62;
            this.pictureBoxIcon.TabStop = false;
            this.pictureBoxIcon.Visible = false;
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.Image = global::API_Proj3.Properties.Resources._95;
            this.pictureBoxMoon.Location = new System.Drawing.Point(1499, 169);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(730, 707);
            this.pictureBoxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxMoon.TabIndex = 61;
            this.pictureBoxMoon.TabStop = false;
            this.pictureBoxMoon.Visible = false;
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.Image = global::API_Proj3.Properties.Resources.images;
            this.pictureBoxArrow.Location = new System.Drawing.Point(1811, 276);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(330, 330);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxArrow.TabIndex = 60;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Visible = false;
            // 
            // labelMoonName
            // 
            this.labelMoonName.AutoSize = true;
            this.labelMoonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelMoonName.Location = new System.Drawing.Point(1641, 81);
            this.labelMoonName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMoonName.Name = "labelMoonName";
            this.labelMoonName.Size = new System.Drawing.Size(162, 30);
            this.labelMoonName.TabIndex = 63;
            this.labelMoonName.Text = "Moon Name";
            this.labelMoonName.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(2266, 1002);
            this.Controls.Add(this.labelMoonName);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.pictureBoxMoon);
            this.Controls.Add(this.pictureBoxArrow);
            this.Controls.Add(this.labelMoonPhase);
            this.Controls.Add(this.labelMoonPhaseDisplay);
            this.Controls.Add(this.labelWindBearing);
            this.Controls.Add(this.labelWindBearingDisplay);
            this.Controls.Add(this.labelWindGust);
            this.Controls.Add(this.labelWindGustDisplay);
            this.Controls.Add(this.labelDewPoint);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelRainTime);
            this.Controls.Add(this.labelCloudCover);
            this.Controls.Add(this.labelDewPointDisplay);
            this.Controls.Add(this.labelPressureDisplay);
            this.Controls.Add(this.labelCloudCoverDisplay);
            this.Controls.Add(this.labelRainDisplay);
            this.Controls.Add(this.labelLowTempTime);
            this.Controls.Add(this.labelHighTempTime);
            this.Controls.Add(this.labelLowDisplay);
            this.Controls.Add(this.labelHighDisplay);
            this.Controls.Add(this.labelHighTemp);
            this.Controls.Add(this.labelLowTemp);
            this.Controls.Add(this.labelSummaryDetails);
            this.Controls.Add(this.labelHour11);
            this.Controls.Add(this.labelHour10);
            this.Controls.Add(this.labelHour9);
            this.Controls.Add(this.labelHour8);
            this.Controls.Add(this.labelHour7);
            this.Controls.Add(this.labelHour6);
            this.Controls.Add(this.labelHour5);
            this.Controls.Add(this.labelHour4);
            this.Controls.Add(this.labelHour3);
            this.Controls.Add(this.labelHour2);
            this.Controls.Add(this.labelHour1);
            this.Controls.Add(this.labelHour0);
            this.Controls.Add(this.labelWindLab);
            this.Controls.Add(this.labelHumLab);
            this.Controls.Add(this.labelPercLab);
            this.Controls.Add(this.labelTempLab);
            this.Controls.Add(this.labelSumLab);
            this.Controls.Add(this.labelWind);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTimeZone);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.labelPrecipitation);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCity);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Weather";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPrecipitation;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelTimeZone;
        private System.Windows.Forms.Label labelSumLab;
        private System.Windows.Forms.Label labelTempLab;
        private System.Windows.Forms.Label labelPercLab;
        private System.Windows.Forms.Label labelHumLab;
        private System.Windows.Forms.Label labelWindLab;
        private System.Windows.Forms.Label labelHour0;
        private System.Windows.Forms.Label labelHour1;
        private System.Windows.Forms.Label labelHour2;
        private System.Windows.Forms.Label labelHour3;
        private System.Windows.Forms.Label labelHour4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRestURI;
        private System.Windows.Forms.Button buttonWind;
        private System.Windows.Forms.Button buttonRain;
        private System.Windows.Forms.Button buttonMoon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHour5;
        private System.Windows.Forms.Label labelHour6;
        private System.Windows.Forms.Label labelHour7;
        private System.Windows.Forms.Label labelHour8;
        private System.Windows.Forms.Label labelHour9;
        private System.Windows.Forms.Label labelHour10;
        private System.Windows.Forms.Label labelHour11;
        private System.Windows.Forms.Button buttonTemp;
        private System.Windows.Forms.Label labelSummaryDetails;
        private System.Windows.Forms.Label labelLowTemp;
        private System.Windows.Forms.Label labelHighTemp;
        private System.Windows.Forms.Label labelHighDisplay;
        private System.Windows.Forms.Label labelLowDisplay;
        private System.Windows.Forms.Label labelHighTempTime;
        private System.Windows.Forms.Label labelLowTempTime;
        private System.Windows.Forms.Label labelRainDisplay;
        private System.Windows.Forms.Label labelCloudCoverDisplay;
        private System.Windows.Forms.Label labelPressureDisplay;
        private System.Windows.Forms.Label labelDewPointDisplay;
        private System.Windows.Forms.Label labelCloudCover;
        private System.Windows.Forms.Label labelRainTime;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelDewPoint;
        private System.Windows.Forms.Label labelWindGustDisplay;
        private System.Windows.Forms.Label labelWindGust;
        private System.Windows.Forms.Label labelWindBearingDisplay;
        private System.Windows.Forms.Label labelWindBearing;
        private System.Windows.Forms.Label labelMoonPhaseDisplay;
        private System.Windows.Forms.Label labelMoonPhase;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelMoonName;
    }
}

