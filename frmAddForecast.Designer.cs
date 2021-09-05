namespace WeatherApp
{
    partial class frmAddForecast
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
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPrecip = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.nudMinTemp = new System.Windows.Forms.NumericUpDown();
            this.nudMaxTemp = new System.Windows.Forms.NumericUpDown();
            this.nudPrecip = new System.Windows.Forms.NumericUpDown();
            this.nudHumidity = new System.Windows.Forms.NumericUpDown();
            this.nudWindSpeed = new System.Windows.Forms.NumericUpDown();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.ForeColor = System.Drawing.Color.White;
            this.lblWindSpeed.Location = new System.Drawing.Point(81, 358);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(132, 23);
            this.lblWindSpeed.TabIndex = 24;
            this.lblWindSpeed.Text = "Wind Speed:";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.Color.White;
            this.lblHumidity.Location = new System.Drawing.Point(81, 306);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(106, 23);
            this.lblHumidity.TabIndex = 23;
            this.lblHumidity.Text = "Humidity:";
            // 
            // lblPrecip
            // 
            this.lblPrecip.AutoSize = true;
            this.lblPrecip.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecip.ForeColor = System.Drawing.Color.White;
            this.lblPrecip.Location = new System.Drawing.Point(81, 254);
            this.lblPrecip.Name = "lblPrecip";
            this.lblPrecip.Size = new System.Drawing.Size(140, 23);
            this.lblPrecip.TabIndex = 22;
            this.lblPrecip.Text = "Precipitation:";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.ForeColor = System.Drawing.Color.White;
            this.lblMaxTemp.Location = new System.Drawing.Point(81, 202);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(245, 23);
            this.lblMaxTemp.TabIndex = 21;
            this.lblMaxTemp.Text = "Maximum Temperature:";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.ForeColor = System.Drawing.Color.White;
            this.lblMinTemp.Location = new System.Drawing.Point(81, 150);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(240, 23);
            this.lblMinTemp.TabIndex = 20;
            this.lblMinTemp.Text = "Minimum Temperature:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(81, 98);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 23);
            this.lblDate.TabIndex = 26;
            this.lblDate.Text = "Date:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(81, 46);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(55, 23);
            this.lblCity.TabIndex = 31;
            this.lblCity.Text = "City:";
            // 
            // txbCity
            // 
            this.txbCity.BackColor = System.Drawing.SystemColors.Highlight;
            this.txbCity.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCity.ForeColor = System.Drawing.Color.White;
            this.txbCity.Location = new System.Drawing.Point(403, 46);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(233, 31);
            this.txbCity.TabIndex = 32;
            // 
            // nudMinTemp
            // 
            this.nudMinTemp.BackColor = System.Drawing.SystemColors.Highlight;
            this.nudMinTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudMinTemp.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinTemp.ForeColor = System.Drawing.Color.White;
            this.nudMinTemp.Location = new System.Drawing.Point(403, 148);
            this.nudMinTemp.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinTemp.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudMinTemp.Name = "nudMinTemp";
            this.nudMinTemp.Size = new System.Drawing.Size(233, 31);
            this.nudMinTemp.TabIndex = 34;
            // 
            // nudMaxTemp
            // 
            this.nudMaxTemp.BackColor = System.Drawing.SystemColors.Highlight;
            this.nudMaxTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudMaxTemp.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxTemp.ForeColor = System.Drawing.Color.White;
            this.nudMaxTemp.Location = new System.Drawing.Point(403, 199);
            this.nudMaxTemp.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMaxTemp.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudMaxTemp.Name = "nudMaxTemp";
            this.nudMaxTemp.Size = new System.Drawing.Size(233, 31);
            this.nudMaxTemp.TabIndex = 35;
            // 
            // nudPrecip
            // 
            this.nudPrecip.BackColor = System.Drawing.SystemColors.Highlight;
            this.nudPrecip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudPrecip.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecip.ForeColor = System.Drawing.Color.White;
            this.nudPrecip.Location = new System.Drawing.Point(403, 250);
            this.nudPrecip.Name = "nudPrecip";
            this.nudPrecip.Size = new System.Drawing.Size(233, 31);
            this.nudPrecip.TabIndex = 36;
            // 
            // nudHumidity
            // 
            this.nudHumidity.BackColor = System.Drawing.SystemColors.Highlight;
            this.nudHumidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudHumidity.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHumidity.ForeColor = System.Drawing.Color.White;
            this.nudHumidity.Location = new System.Drawing.Point(403, 301);
            this.nudHumidity.Name = "nudHumidity";
            this.nudHumidity.Size = new System.Drawing.Size(233, 31);
            this.nudHumidity.TabIndex = 37;
            // 
            // nudWindSpeed
            // 
            this.nudWindSpeed.BackColor = System.Drawing.SystemColors.Highlight;
            this.nudWindSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudWindSpeed.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWindSpeed.ForeColor = System.Drawing.Color.White;
            this.nudWindSpeed.Location = new System.Drawing.Point(403, 352);
            this.nudWindSpeed.Maximum = new decimal(new int[] {
            380,
            0,
            0,
            0});
            this.nudWindSpeed.Name = "nudWindSpeed";
            this.nudWindSpeed.Size = new System.Drawing.Size(233, 31);
            this.nudWindSpeed.TabIndex = 38;
            // 
            // cmbCondition
            // 
            this.cmbCondition.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmbCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondition.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCondition.ForeColor = System.Drawing.Color.White;
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "Sunny",
            "Few Clouds",
            "Scattered Clouds",
            "Broken Clouds",
            "Cloudy",
            "Misty",
            "Rain",
            "Thundershower",
            "Hail",
            "Snow"});
            this.cmbCondition.Location = new System.Drawing.Point(403, 403);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(233, 31);
            this.cmbCondition.TabIndex = 39;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.Color.White;
            this.lblCondition.Location = new System.Drawing.Point(81, 410);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(113, 23);
            this.lblCondition.TabIndex = 40;
            this.lblCondition.Text = "Condition:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(85, 505);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(210, 37);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(415, 505);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(210, 37);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(403, 97);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(233, 31);
            this.dtpDate.TabIndex = 43;
            // 
            // frmAddForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(71)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(753, 624);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.cmbCondition);
            this.Controls.Add(this.nudWindSpeed);
            this.Controls.Add(this.nudHumidity);
            this.Controls.Add(this.nudPrecip);
            this.Controls.Add(this.nudMaxTemp);
            this.Controls.Add(this.nudMinTemp);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblPrecip);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblMinTemp);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmAddForecast";
            this.Text = "Add Forecast";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddForecast_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPrecip;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.NumericUpDown nudMinTemp;
        private System.Windows.Forms.NumericUpDown nudMaxTemp;
        private System.Windows.Forms.NumericUpDown nudPrecip;
        private System.Windows.Forms.NumericUpDown nudHumidity;
        private System.Windows.Forms.NumericUpDown nudWindSpeed;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}