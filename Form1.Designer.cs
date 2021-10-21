
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWeatherCon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimeZ = new System.Windows.Forms.TextBox();
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min Temp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max Temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Region";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Longitude";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(192, 47);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(234, 20);
            this.txtCity.TabIndex = 6;
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(192, 193);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(234, 20);
            this.txtMaxTemp.TabIndex = 7;
            this.txtMaxTemp.TextChanged += new System.EventHandler(this.txtMaxTemp_TextChanged);
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(192, 234);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(234, 20);
            this.txtMinTemp.TabIndex = 8;
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(192, 274);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(234, 20);
            this.txtRegion.TabIndex = 9;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(192, 318);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(234, 20);
            this.txtLat.TabIndex = 10;
            // 
            // txtLon
            // 
            this.txtLon.Location = new System.Drawing.Point(192, 356);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(234, 20);
            this.txtLon.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(585, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 163);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblWeatherCon
            // 
            this.lblWeatherCon.AutoSize = true;
            this.lblWeatherCon.Location = new System.Drawing.Point(582, 54);
            this.lblWeatherCon.Name = "lblWeatherCon";
            this.lblWeatherCon.Size = new System.Drawing.Size(95, 13);
            this.lblWeatherCon.TabIndex = 13;
            this.lblWeatherCon.Text = "Weahter Condition";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 425);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 224);
            this.dataGridView1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(354, 667);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 39);
            this.button3.TabIndex = 17;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(192, 12);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(234, 20);
            this.txtCountry.TabIndex = 18;
            this.txtCountry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(83, 15);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 19;
            this.lblCountry.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Time Zone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Current Time";
            // 
            // txtTimeZ
            // 
            this.txtTimeZ.Location = new System.Drawing.Point(192, 106);
            this.txtTimeZ.Name = "txtTimeZ";
            this.txtTimeZ.Size = new System.Drawing.Size(234, 20);
            this.txtTimeZ.TabIndex = 22;
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.Location = new System.Drawing.Point(192, 149);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.Size = new System.Drawing.Size(234, 20);
            this.txtCurrentTime.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 797);
            this.Controls.Add(this.txtCurrentTime);
            this.Controls.Add(this.txtTimeZ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWeatherCon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLon);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.txtMinTemp);
            this.Controls.Add(this.txtMaxTemp);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather API";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWeatherCon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimeZ;
        private System.Windows.Forms.TextBox txtCurrentTime;
    }
}

