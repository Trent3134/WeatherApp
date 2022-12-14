namespace WeatherApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.tbcity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_conditions = new System.Windows.Forms.Label();
            this.lab_sunrisee = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.lab_details = new System.Windows.Forms.Label();
            this.lab_sunsett = new System.Windows.Forms.Label();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.label_windspeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_close.Location = new System.Drawing.Point(766, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 27);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "x";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // tbcity
            // 
            this.tbcity.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcity.Location = new System.Drawing.Point(192, 72);
            this.tbcity.Name = "tbcity";
            this.tbcity.Size = new System.Drawing.Size(224, 26);
            this.tbcity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "city:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(433, 68);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 33);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.search_Click);
            // 
            // lab_conditions
            // 
            this.lab_conditions.AutoSize = true;
            this.lab_conditions.BackColor = System.Drawing.Color.Transparent;
            this.lab_conditions.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_conditions.ForeColor = System.Drawing.Color.White;
            this.lab_conditions.Location = new System.Drawing.Point(122, 176);
            this.lab_conditions.Name = "lab_conditions";
            this.lab_conditions.Size = new System.Drawing.Size(130, 19);
            this.lab_conditions.TabIndex = 4;
            this.lab_conditions.Text = "Conditions:";
            // 
            // lab_sunrisee
            // 
            this.lab_sunrisee.AutoSize = true;
            this.lab_sunrisee.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunrisee.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunrisee.ForeColor = System.Drawing.Color.White;
            this.lab_sunrisee.Location = new System.Drawing.Point(122, 276);
            this.lab_sunrisee.Name = "lab_sunrisee";
            this.lab_sunrisee.Size = new System.Drawing.Size(97, 19);
            this.lab_sunrisee.TabIndex = 5;
            this.lab_sunrisee.Text = "Sunrise:";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunrise.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunrise.ForeColor = System.Drawing.Color.White;
            this.lab_sunrise.Location = new System.Drawing.Point(214, 276);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(42, 19);
            this.lab_sunrise.TabIndex = 6;
            this.lab_sunrise.Text = "N/A";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunset.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunset.ForeColor = System.Drawing.Color.White;
            this.lab_sunset.Location = new System.Drawing.Point(214, 328);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(42, 19);
            this.lab_sunset.TabIndex = 7;
            this.lab_sunset.Text = "N/A";
            // 
            // lab_details
            // 
            this.lab_details.AutoSize = true;
            this.lab_details.BackColor = System.Drawing.Color.Transparent;
            this.lab_details.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_details.ForeColor = System.Drawing.Color.White;
            this.lab_details.Location = new System.Drawing.Point(122, 232);
            this.lab_details.Name = "lab_details";
            this.lab_details.Size = new System.Drawing.Size(86, 19);
            this.lab_details.TabIndex = 9;
            this.lab_details.Text = "Detail:";
            // 
            // lab_sunsett
            // 
            this.lab_sunsett.AutoSize = true;
            this.lab_sunsett.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunsett.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunsett.ForeColor = System.Drawing.Color.White;
            this.lab_sunsett.Location = new System.Drawing.Point(122, 328);
            this.lab_sunsett.Name = "lab_sunsett";
            this.lab_sunsett.Size = new System.Drawing.Size(86, 19);
            this.lab_sunsett.TabIndex = 10;
            this.lab_sunsett.Text = "Sunset:";
            // 
            // pic_icon
            // 
            this.pic_icon.BackColor = System.Drawing.Color.Transparent;
            this.pic_icon.ErrorImage = null;
            this.pic_icon.Location = new System.Drawing.Point(126, 111);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(100, 50);
            this.pic_icon.TabIndex = 11;
            this.pic_icon.TabStop = false;
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.BackColor = System.Drawing.Color.Transparent;
            this.lab_pressure.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pressure.ForeColor = System.Drawing.Color.White;
            this.lab_pressure.Location = new System.Drawing.Point(492, 232);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(42, 19);
            this.lab_pressure.TabIndex = 12;
            this.lab_pressure.Text = "N/A";
            this.lab_pressure.Click += new System.EventHandler(this.lab_pressure_Click);
            // 
            // label_windspeed
            // 
            this.label_windspeed.AutoSize = true;
            this.label_windspeed.BackColor = System.Drawing.Color.Transparent;
            this.label_windspeed.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_windspeed.ForeColor = System.Drawing.Color.White;
            this.label_windspeed.Location = new System.Drawing.Point(511, 176);
            this.label_windspeed.Name = "label_windspeed";
            this.label_windspeed.Size = new System.Drawing.Size(42, 19);
            this.label_windspeed.TabIndex = 13;
            this.label_windspeed.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(378, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pressure:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(378, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Wind Speed:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_windspeed);
            this.Controls.Add(this.lab_pressure);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.lab_sunsett);
            this.Controls.Add(this.lab_details);
            this.Controls.Add(this.lab_sunset);
            this.Controls.Add(this.lab_sunrise);
            this.Controls.Add(this.lab_sunrisee);
            this.Controls.Add(this.lab_conditions);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcity);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox tbcity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lab_conditions;
        private System.Windows.Forms.Label lab_sunrisee;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label lab_details;
        private System.Windows.Forms.Label lab_sunsett;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Label lab_pressure;
        private System.Windows.Forms.Label label_windspeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

