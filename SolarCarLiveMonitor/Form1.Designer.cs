namespace SolarCarLiveMonitor
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.solarIntensityGroupBox = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.connectionStatusGroupBox = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.batteryChargeGroupBox = new System.Windows.Forms.GroupBox();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.batteryChargeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.powerGenerationGroupBox = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.powerGenChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.solarIntensityGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.connectionStatusGroupBox.SuspendLayout();
			this.batteryChargeGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.batteryChargeChart)).BeginInit();
			this.powerGenerationGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.powerGenChart)).BeginInit();
			this.SuspendLayout();
			// 
			// solarIntensityGroupBox
			// 
			this.solarIntensityGroupBox.BackColor = System.Drawing.SystemColors.Control;
			this.solarIntensityGroupBox.Controls.Add(this.label11);
			this.solarIntensityGroupBox.Controls.Add(this.label10);
			this.solarIntensityGroupBox.Controls.Add(this.label2);
			this.solarIntensityGroupBox.Controls.Add(this.label1);
			this.solarIntensityGroupBox.Controls.Add(this.chart1);
			this.solarIntensityGroupBox.Location = new System.Drawing.Point(12, 12);
			this.solarIntensityGroupBox.Name = "solarIntensityGroupBox";
			this.solarIntensityGroupBox.Size = new System.Drawing.Size(475, 325);
			this.solarIntensityGroupBox.TabIndex = 0;
			this.solarIntensityGroupBox.TabStop = false;
			this.solarIntensityGroupBox.Text = "Solar Intensity";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(368, 136);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(10);
			this.label2.Size = new System.Drawing.Size(101, 53);
			this.label2.TabIndex = 4;
			this.label2.Text = "--.- V";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(368, 52);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(10);
			this.label1.Size = new System.Drawing.Size(101, 62);
			this.label1.TabIndex = 3;
			this.label1.Text = "--.- A";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chart1
			// 
			this.chart1.BorderlineColor = System.Drawing.Color.DarkGray;
			this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea5.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea5);
			this.chart1.Location = new System.Drawing.Point(6, 19);
			this.chart1.Name = "chart1";
			series5.ChartArea = "ChartArea1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series5.Name = "Series1";
			this.chart1.Series.Add(series5);
			this.chart1.Size = new System.Drawing.Size(356, 300);
			this.chart1.TabIndex = 2;
			this.chart1.Text = "chart2";
			// 
			// connectionStatusGroupBox
			// 
			this.connectionStatusGroupBox.Controls.Add(this.label9);
			this.connectionStatusGroupBox.Controls.Add(this.label8);
			this.connectionStatusGroupBox.Controls.Add(this.label7);
			this.connectionStatusGroupBox.Controls.Add(this.label6);
			this.connectionStatusGroupBox.Location = new System.Drawing.Point(493, 12);
			this.connectionStatusGroupBox.Name = "connectionStatusGroupBox";
			this.connectionStatusGroupBox.Size = new System.Drawing.Size(475, 325);
			this.connectionStatusGroupBox.TabIndex = 1;
			this.connectionStatusGroupBox.TabStop = false;
			this.connectionStatusGroupBox.Text = "Connection Status";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(236, 174);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(10);
			this.label9.Size = new System.Drawing.Size(206, 139);
			this.label9.TabIndex = 8;
			this.label9.Text = "Signal Stregth\r\nSTRONG";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(24, 174);
			this.label8.Name = "label8";
			this.label8.Padding = new System.Windows.Forms.Padding(10);
			this.label8.Size = new System.Drawing.Size(206, 139);
			this.label8.TabIndex = 7;
			this.label8.Text = "Approx. Distance\r\n18.7m";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(236, 27);
			this.label7.Name = "label7";
			this.label7.Padding = new System.Windows.Forms.Padding(10);
			this.label7.Size = new System.Drawing.Size(206, 139);
			this.label7.TabIndex = 6;
			this.label7.Text = "Last Connection\r\n0:00";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(24, 27);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(10);
			this.label6.Size = new System.Drawing.Size(206, 139);
			this.label6.TabIndex = 5;
			this.label6.Text = "Bluetooth\r\nCONNECTED";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// batteryChargeGroupBox
			// 
			this.batteryChargeGroupBox.Controls.Add(this.chart2);
			this.batteryChargeGroupBox.Controls.Add(this.batteryChargeChart);
			this.batteryChargeGroupBox.Location = new System.Drawing.Point(12, 343);
			this.batteryChargeGroupBox.Name = "batteryChargeGroupBox";
			this.batteryChargeGroupBox.Size = new System.Drawing.Size(475, 325);
			this.batteryChargeGroupBox.TabIndex = 1;
			this.batteryChargeGroupBox.TabStop = false;
			this.batteryChargeGroupBox.Text = "Battery Charge";
			// 
			// chart2
			// 
			this.chart2.BorderlineColor = System.Drawing.Color.DarkGray;
			this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea6.Area3DStyle.Enable3D = true;
			chartArea6.Area3DStyle.Inclination = 5;
			chartArea6.Area3DStyle.PointDepth = 25;
			chartArea6.Area3DStyle.Rotation = 25;
			chartArea6.AxisX.LabelStyle.Enabled = false;
			chartArea6.AxisX.MajorGrid.Enabled = false;
			chartArea6.AxisX.MajorTickMark.Enabled = false;
			chartArea6.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
			chartArea6.AxisX2.MajorGrid.Enabled = false;
			chartArea6.AxisX2.MajorTickMark.Enabled = false;
			chartArea6.AxisY.Maximum = 100D;
			chartArea6.AxisY.Minimum = 0D;
			chartArea6.AxisY.Title = "Battery Charge Percentage";
			chartArea6.AxisY2.MajorGrid.Enabled = false;
			chartArea6.AxisY2.MajorTickMark.Enabled = false;
			chartArea6.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea6);
			this.chart2.Location = new System.Drawing.Point(368, 74);
			this.chart2.Name = "chart2";
			this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			series6.ChartArea = "ChartArea1";
			series6.Name = "Series1";
			dataPoint2.BorderWidth = 1;
			dataPoint2.IsValueShownAsLabel = true;
			dataPoint2.Label = "#VAL%";
			series6.Points.Add(dataPoint2);
			this.chart2.Series.Add(series6);
			this.chart2.Size = new System.Drawing.Size(101, 186);
			this.chart2.TabIndex = 2;
			this.chart2.Text = "chart2";
			// 
			// batteryChargeChart
			// 
			this.batteryChargeChart.BorderlineColor = System.Drawing.Color.DarkGray;
			this.batteryChargeChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea7.Name = "ChartArea1";
			this.batteryChargeChart.ChartAreas.Add(chartArea7);
			this.batteryChargeChart.Location = new System.Drawing.Point(6, 25);
			this.batteryChargeChart.Name = "batteryChargeChart";
			series7.ChartArea = "ChartArea1";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series7.Name = "Series1";
			this.batteryChargeChart.Series.Add(series7);
			this.batteryChargeChart.Size = new System.Drawing.Size(356, 300);
			this.batteryChargeChart.TabIndex = 1;
			this.batteryChargeChart.Text = "chart2";
			// 
			// powerGenerationGroupBox
			// 
			this.powerGenerationGroupBox.Controls.Add(this.label5);
			this.powerGenerationGroupBox.Controls.Add(this.label4);
			this.powerGenerationGroupBox.Controls.Add(this.label3);
			this.powerGenerationGroupBox.Controls.Add(this.powerGenChart);
			this.powerGenerationGroupBox.Location = new System.Drawing.Point(493, 343);
			this.powerGenerationGroupBox.Name = "powerGenerationGroupBox";
			this.powerGenerationGroupBox.Size = new System.Drawing.Size(475, 325);
			this.powerGenerationGroupBox.TabIndex = 2;
			this.powerGenerationGroupBox.TabStop = false;
			this.powerGenerationGroupBox.Text = "Power Generation";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 191);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(10);
			this.label5.Size = new System.Drawing.Size(101, 53);
			this.label5.TabIndex = 7;
			this.label5.Text = "Solar";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(26, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Source";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 92);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(10);
			this.label3.Size = new System.Drawing.Size(101, 53);
			this.label3.TabIndex = 5;
			this.label3.Text = "--.- V";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// powerGenChart
			// 
			this.powerGenChart.BorderlineColor = System.Drawing.Color.DarkGray;
			this.powerGenChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea8.Name = "ChartArea1";
			this.powerGenChart.ChartAreas.Add(chartArea8);
			this.powerGenChart.Location = new System.Drawing.Point(113, 25);
			this.powerGenChart.Name = "powerGenChart";
			series8.ChartArea = "ChartArea1";
			series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series8.Name = "Series1";
			this.powerGenChart.Series.Add(series8);
			this.powerGenChart.Size = new System.Drawing.Size(356, 300);
			this.powerGenChart.TabIndex = 2;
			this.powerGenChart.Text = "chart3";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(368, 236);
			this.label10.Name = "label10";
			this.label10.Padding = new System.Windows.Forms.Padding(10);
			this.label10.Size = new System.Drawing.Size(101, 53);
			this.label10.TabIndex = 5;
			this.label10.Text = "33%";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(376, 216);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 20);
			this.label11.TabIndex = 8;
			this.label11.Text = "Duty Cycle";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(981, 680);
			this.Controls.Add(this.powerGenerationGroupBox);
			this.Controls.Add(this.batteryChargeGroupBox);
			this.Controls.Add(this.connectionStatusGroupBox);
			this.Controls.Add(this.solarIntensityGroupBox);
			this.Name = "Form1";
			this.Text = "Solar Car Live Monitor";
			this.solarIntensityGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.connectionStatusGroupBox.ResumeLayout(false);
			this.batteryChargeGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.batteryChargeChart)).EndInit();
			this.powerGenerationGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.powerGenChart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox solarIntensityGroupBox;
		private System.Windows.Forms.GroupBox connectionStatusGroupBox;
		private System.Windows.Forms.GroupBox batteryChargeGroupBox;
		private System.Windows.Forms.GroupBox powerGenerationGroupBox;
		private System.Windows.Forms.DataVisualization.Charting.Chart batteryChargeChart;
		private System.Windows.Forms.DataVisualization.Charting.Chart powerGenChart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
	}
}

