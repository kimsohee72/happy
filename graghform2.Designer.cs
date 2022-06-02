namespace Teamproject1
{
    partial class graghform2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graghform2));
            this.graphformbutton = new System.Windows.Forms.Button();
            this.graphformcopy1 = new System.Windows.Forms.Button();
            this.graphformcopy2 = new System.Windows.Forms.Button();
            this.weatherinfo = new System.Windows.Forms.Button();
            this.malefashion = new System.Windows.Forms.Button();
            this.femalefashion = new System.Windows.Forms.Button();
            this.agespecific = new System.Windows.Forms.Button();
            this.seasonspecific = new System.Windows.Forms.Button();
            this.design1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // graphformbutton
            // 
            this.graphformbutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.graphformbutton.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.graphformbutton.Location = new System.Drawing.Point(15, 26);
            this.graphformbutton.Margin = new System.Windows.Forms.Padding(4);
            this.graphformbutton.Name = "graphformbutton";
            this.graphformbutton.Size = new System.Drawing.Size(74, 56);
            this.graphformbutton.TabIndex = 0;
            this.graphformbutton.Text = "<";
            this.graphformbutton.UseVisualStyleBackColor = false;
            this.graphformbutton.Click += new System.EventHandler(this.graphformbutton_Click);
            // 
            // graphformcopy1
            // 
            this.graphformcopy1.Enabled = false;
            this.graphformcopy1.Font = new System.Drawing.Font("카페24 써라운드", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.graphformcopy1.Location = new System.Drawing.Point(15, 385);
            this.graphformcopy1.Margin = new System.Windows.Forms.Padding(4);
            this.graphformcopy1.Name = "graphformcopy1";
            this.graphformcopy1.Size = new System.Drawing.Size(305, 83);
            this.graphformcopy1.TabIndex = 2;
            this.graphformcopy1.Text = "패션이 모였다";
            this.graphformcopy1.UseVisualStyleBackColor = true;
            // 
            // graphformcopy2
            // 
            this.graphformcopy2.Enabled = false;
            this.graphformcopy2.Font = new System.Drawing.Font("카페24 써라운드 에어 ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.graphformcopy2.Location = new System.Drawing.Point(15, 475);
            this.graphformcopy2.Margin = new System.Windows.Forms.Padding(4);
            this.graphformcopy2.Name = "graphformcopy2";
            this.graphformcopy2.Size = new System.Drawing.Size(521, 43);
            this.graphformcopy2.TabIndex = 3;
            this.graphformcopy2.Text = "날씨에 맞는 옷을 원하는 당신, 무엇을 고르시겠어요?";
            this.graphformcopy2.UseVisualStyleBackColor = true;
            // 
            // weatherinfo
            // 
            this.weatherinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.weatherinfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.weatherinfo.Location = new System.Drawing.Point(15, 526);
            this.weatherinfo.Margin = new System.Windows.Forms.Padding(4);
            this.weatherinfo.Name = "weatherinfo";
            this.weatherinfo.Size = new System.Drawing.Size(632, 44);
            this.weatherinfo.TabIndex = 4;
            this.weatherinfo.Text = "#일교차 #낮은더워 #밤에비올예정 #습해요";
            this.weatherinfo.UseVisualStyleBackColor = true;
            // 
            // malefashion
            // 
            this.malefashion.Enabled = false;
            this.malefashion.Font = new System.Drawing.Font("카페24 써라운드", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malefashion.Location = new System.Drawing.Point(34, 665);
            this.malefashion.Margin = new System.Windows.Forms.Padding(4);
            this.malefashion.Name = "malefashion";
            this.malefashion.Size = new System.Drawing.Size(119, 107);
            this.malefashion.TabIndex = 5;
            this.malefashion.Text = "남자패션";
            this.malefashion.UseVisualStyleBackColor = true;
            // 
            // femalefashion
            // 
            this.femalefashion.Enabled = false;
            this.femalefashion.Font = new System.Drawing.Font("카페24 써라운드", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalefashion.Location = new System.Drawing.Point(192, 665);
            this.femalefashion.Margin = new System.Windows.Forms.Padding(4);
            this.femalefashion.Name = "femalefashion";
            this.femalefashion.Size = new System.Drawing.Size(116, 107);
            this.femalefashion.TabIndex = 6;
            this.femalefashion.Text = "여자패션";
            this.femalefashion.UseVisualStyleBackColor = true;
            // 
            // agespecific
            // 
            this.agespecific.Enabled = false;
            this.agespecific.Font = new System.Drawing.Font("카페24 써라운드", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agespecific.Location = new System.Drawing.Point(349, 665);
            this.agespecific.Margin = new System.Windows.Forms.Padding(4);
            this.agespecific.Name = "agespecific";
            this.agespecific.Size = new System.Drawing.Size(122, 107);
            this.agespecific.TabIndex = 7;
            this.agespecific.Text = "나이별패션";
            this.agespecific.UseVisualStyleBackColor = true;
            // 
            // seasonspecific
            // 
            this.seasonspecific.Enabled = false;
            this.seasonspecific.Font = new System.Drawing.Font("카페24 써라운드", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonspecific.Location = new System.Drawing.Point(508, 665);
            this.seasonspecific.Margin = new System.Windows.Forms.Padding(4);
            this.seasonspecific.Name = "seasonspecific";
            this.seasonspecific.Size = new System.Drawing.Size(122, 107);
            this.seasonspecific.TabIndex = 8;
            this.seasonspecific.Text = "계절패션";
            this.seasonspecific.UseVisualStyleBackColor = true;
            // 
            // design1
            // 
            this.design1.Font = new System.Drawing.Font("카페24 써라운드", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.design1.Location = new System.Drawing.Point(177, 839);
            this.design1.Margin = new System.Windows.Forms.Padding(4);
            this.design1.Name = "design1";
            this.design1.Size = new System.Drawing.Size(294, 53);
            this.design1.TabIndex = 9;
            this.design1.Text = "새로운 패션 추천";
            this.design1.UseVisualStyleBackColor = true;
            this.design1.Click += new System.EventHandler(this.design1_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("카페24 써라운드", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(275, 594);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "해시태그";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 95);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(621, 273);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            title1.Name = "Title1";
            title1.Text = "기온그래프";
            this.chart1.Titles.Add(title1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("카페24 써라운드", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(96, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(189, 41);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "날씨에 맞는 옷";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // graghform2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(662, 919);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.design1);
            this.Controls.Add(this.seasonspecific);
            this.Controls.Add(this.agespecific);
            this.Controls.Add(this.femalefashion);
            this.Controls.Add(this.malefashion);
            this.Controls.Add(this.weatherinfo);
            this.Controls.Add(this.graphformcopy2);
            this.Controls.Add(this.graphformcopy1);
            this.Controls.Add(this.graphformbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "graghform2";
            this.Text = "graghform";
            this.Load += new System.EventHandler(this.graghform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button graphformbutton;
        private System.Windows.Forms.Button graphformcopy1;
        private System.Windows.Forms.Button graphformcopy2;
        private System.Windows.Forms.Button weatherinfo;
        private System.Windows.Forms.Button malefashion;
        private System.Windows.Forms.Button femalefashion;
        private System.Windows.Forms.Button agespecific;
        private System.Windows.Forms.Button seasonspecific;
        private System.Windows.Forms.Button design1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
