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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.solarIntensityGroupBox = new System.Windows.Forms.GroupBox();
			this.SIVoltLabel = new System.Windows.Forms.Label();
			this.SICurrLabel = new System.Windows.Forms.Label();
			this.SIChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label11 = new System.Windows.Forms.Label();
			this.dutyCycleLabel = new System.Windows.Forms.Label();
			this.connectionStatusGroupBox = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.distLabel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.batteryChargeGroupBox = new System.Windows.Forms.GroupBox();
			this.batteryVisChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.batteryChargeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.powerGenerationGroupBox = new System.Windows.Forms.GroupBox();
			this.powGenSrcLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.powGenVoltLabel = new System.Windows.Forms.Label();
			this.powerGenChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label1 = new System.Windows.Forms.Label();
			this.solarIntensityGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SIChart)).BeginInit();
			this.connectionStatusGroupBox.SuspendLayout();
			this.batteryChargeGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.batteryVisChart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.batteryChargeChart)).BeginInit();
			this.powerGenerationGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.powerGenChart)).BeginInit();
			this.SuspendLayout();
			// 
			// solarIntensityGroupBox
			// 
			this.solarIntensityGroupBox.BackColor = System.Drawing.SystemColors.Control;
			this.solarIntensityGroupBox.Controls.Add(this.SIVoltLabel);
			this.solarIntensityGroupBox.Controls.Add(this.SICurrLabel);
			this.solarIntensityGroupBox.Controls.Add(this.SIChart);
			this.solarIntensityGroupBox.Location = new System.Drawing.Point(12, 12);
			this.solarIntensityGroupBox.Name = "solarIntensityGroupBox";
			this.solarIntensityGroupBox.Size = new System.Drawing.Size(475, 325);
			this.solarIntensityGroupBox.TabIndex = 0;
			this.solarIntensityGroupBox.TabStop = false;
			this.solarIntensityGroupBox.Text = "Solar Intensity";
			// 
			// SIVoltLabel
			// 
			this.SIVoltLabel.BackColor = System.Drawing.Color.CornflowerBlue;
			this.SIVoltLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SIVoltLabel.Location = new System.Drawing.Point(368, 83);
			this.SIVoltLabel.Name = "SIVoltLabel";
			this.SIVoltLabel.Padding = new System.Windows.Forms.Padding(10);
			this.SIVoltLabel.Size = new System.Drawing.Size(101, 62);
			this.SIVoltLabel.TabIndex = 4;
			this.SIVoltLabel.Text = "00.0 V";
			this.SIVoltLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SICurrLabel
			// 
			this.SICurrLabel.BackColor = System.Drawing.Color.Khaki;
			this.SICurrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SICurrLabel.Location = new System.Drawing.Point(368, 185);
			this.SICurrLabel.Name = "SICurrLabel";
			this.SICurrLabel.Padding = new System.Windows.Forms.Padding(10);
			this.SICurrLabel.Size = new System.Drawing.Size(101, 62);
			this.SICurrLabel.TabIndex = 3;
			this.SICurrLabel.Text = "00.0 A";
			this.SICurrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SIChart
			// 
			this.SIChart.BorderlineColor = System.Drawing.Color.DarkGray;
			this.SIChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.AxisX.IsReversed = true;
			chartArea1.AxisX.Maximum = 50D;
			chartArea1.AxisX.Minimum = 0D;
			chartArea1.AxisY.Maximum = 16D;
			chartArea1.AxisY.Minimum = 0D;
			chartArea1.AxisY.Title = "Voltage (V)";
			chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea1.AxisY2.Maximum = 2D;
			chartArea1.AxisY2.Minimum = 0D;
			chartArea1.AxisY2.Title = "Current (A)";
			chartArea1.Name = "ChartArea1";
			this.SIChart.ChartAreas.Add(chartArea1);
			this.SIChart.Location = new System.Drawing.Point(6, 19);
			this.SIChart.Name = "SIChart";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Name = "SIVoltageSeries";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Name = "SICurrentSeries";
			series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
			this.SIChart.Series.Add(series1);
			this.SIChart.Series.Add(series2);
			this.SIChart.Size = new System.Drawing.Size(356, 300);
			this.SIChart.TabIndex = 2;
			this.SIChart.Text = "chart2";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(14, 128);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 20);
			this.label11.TabIndex = 8;
			this.label11.Text = "Duty Cycle";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dutyCycleLabel
			// 
			this.dutyCycleLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.dutyCycleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dutyCycleLabel.Location = new System.Drawing.Point(6, 148);
			this.dutyCycleLabel.Name = "dutyCycleLabel";
			this.dutyCycleLabel.Padding = new System.Windows.Forms.Padding(10);
			this.dutyCycleLabel.Size = new System.Drawing.Size(101, 53);
			this.dutyCycleLabel.TabIndex = 5;
			this.dutyCycleLabel.Text = "XX.X%";
			this.dutyCycleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// connectionStatusGroupBox
			// 
			this.connectionStatusGroupBox.Controls.Add(this.label9);
			this.connectionStatusGroupBox.Controls.Add(this.distLabel);
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
			// distLabel
			// 
			this.distLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.distLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.distLabel.Location = new System.Drawing.Point(24, 174);
			this.distLabel.Name = "distLabel";
			this.distLabel.Padding = new System.Windows.Forms.Padding(10);
			this.distLabel.Size = new System.Drawing.Size(206, 139);
			this.distLabel.TabIndex = 7;
			this.distLabel.Text = "Approx. Distance\r\n18.7m";
			this.distLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.batteryChargeGroupBox.Controls.Add(this.batteryVisChart);
			this.batteryChargeGroupBox.Controls.Add(this.batteryChargeChart);
			this.batteryChargeGroupBox.Location = new System.Drawing.Point(12, 343);
			this.batteryChargeGroupBox.Name = "batteryChargeGroupBox";
			this.batteryChargeGroupBox.Size = new System.Drawing.Size(475, 325);
			this.batteryChargeGroupBox.TabIndex = 1;
			this.batteryChargeGroupBox.TabStop = false;
			this.batteryChargeGroupBox.Text = "Battery Charge";
			// 
			// batteryVisChart
			// 
			this.batteryVisChart.BorderlineColor = System.Drawing.Color.DarkGray;
			this.batteryVisChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea2.Area3DStyle.Enable3D = true;
			chartArea2.Area3DStyle.Inclination = 5;
			chartArea2.Area3DStyle.PointDepth = 25;
			chartArea2.Area3DStyle.Rotation = 25;
			chartArea2.AxisX.LabelStyle.Enabled = false;
			chartArea2.AxisX.MajorGrid.Enabled = false;
			chartArea2.AxisX.MajorTickMark.Enabled = false;
			chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
			chartArea2.AxisX2.MajorGrid.Enabled = false;
			chartArea2.AxisX2.MajorTickMark.Enabled = false;
			chartArea2.AxisY.Maximum = 100D;
			chartArea2.AxisY.Minimum = 0D;
			chartArea2.AxisY.Title = "Battery Charge Percentage";
			chartArea2.AxisY2.MajorGrid.Enabled = false;
			chartArea2.AxisY2.MajorTickMark.Enabled = false;
			chartArea2.Name = "ChartArea1";
			this.batteryVisChart.ChartAreas.Add(chartArea2);
			this.batteryVisChart.Location = new System.Drawing.Point(368, 74);
			this.batteryVisChart.Name = "batteryVisChart";
			this.batteryVisChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			series3.ChartArea = "ChartArea1";
			series3.Name = "Series1";
			dataPoint1.BorderWidth = 1;
			dataPoint1.IsValueShownAsLabel = true;
			dataPoint1.Label = "#VAL%";
			series3.Points.Add(dataPoint1);
			this.batteryVisChart.Series.Add(series3);
			this.batteryVisChart.Size = new System.Drawing.Size(101, 186);
			this.batteryVisChart.TabIndex = 2;
			this.batteryVisChart.Text = "chart2";
			// 
			// batteryChargeChart
			// 
			this.batteryChargeChart.BorderlineColor = System.Drawing.Color.DarkGray;
			this.batteryChargeChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea3.AxisX.IsReversed = true;
			chartArea3.AxisX.Maximum = 50D;
			chartArea3.AxisX.Minimum = 0D;
			chartArea3.AxisY.Maximum = 100D;
			chartArea3.AxisY.Minimum = 0D;
			chartArea3.AxisY.Title = "Battery Charge (%)";
			chartArea3.Name = "ChartArea1";
			this.batteryChargeChart.ChartAreas.Add(chartArea3);
			this.batteryChargeChart.Location = new System.Drawing.Point(6, 19);
			this.batteryChargeChart.Name = "batteryChargeChart";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series4.Color = System.Drawing.Color.DarkGreen;
			series4.Name = "batteryChargeSeries";
			this.batteryChargeChart.Series.Add(series4);
			this.batteryChargeChart.Size = new System.Drawing.Size(356, 300);
			this.batteryChargeChart.TabIndex = 1;
			this.batteryChargeChart.Text = "chart2";
			// 
			// powerGenerationGroupBox
			// 
			this.powerGenerationGroupBox.Controls.Add(this.label1);
			this.powerGenerationGroupBox.Controls.Add(this.label11);
			this.powerGenerationGroupBox.Controls.Add(this.powGenSrcLabel);
			this.powerGenerationGroupBox.Controls.Add(this.dutyCycleLabel);
			this.powerGenerationGroupBox.Controls.Add(this.label4);
			this.powerGenerationGroupBox.Controls.Add(this.powGenVoltLabel);
			this.powerGenerationGroupBox.Controls.Add(this.powerGenChart);
			this.powerGenerationGroupBox.Location = new System.Drawing.Point(493, 343);
			this.powerGenerationGroupBox.Name = "powerGenerationGroupBox";
			this.powerGenerationGroupBox.Size = new System.Drawing.Size(475, 325);
			this.powerGenerationGroupBox.TabIndex = 2;
			this.powerGenerationGroupBox.TabStop = false;
			this.powerGenerationGroupBox.Text = "Power Generation";
			// 
			// powGenSrcLabel
			// 
			this.powGenSrcLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.powGenSrcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.powGenSrcLabel.Location = new System.Drawing.Point(6, 248);
			this.powGenSrcLabel.Name = "powGenSrcLabel";
			this.powGenSrcLabel.Padding = new System.Windows.Forms.Padding(10);
			this.powGenSrcLabel.Size = new System.Drawing.Size(101, 53);
			this.powGenSrcLabel.TabIndex = 7;
			this.powGenSrcLabel.Text = "Solar";
			this.powGenSrcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(26, 228);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Source";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// powGenVoltLabel
			// 
			this.powGenVoltLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.powGenVoltLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.powGenVoltLabel.Location = new System.Drawing.Point(6, 48);
			this.powGenVoltLabel.Name = "powGenVoltLabel";
			this.powGenVoltLabel.Padding = new System.Windows.Forms.Padding(10);
			this.powGenVoltLabel.Size = new System.Drawing.Size(101, 53);
			this.powGenVoltLabel.TabIndex = 5;
			this.powGenVoltLabel.Text = "00.0 W";
			this.powGenVoltLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// powerGenChart
			// 
			this.powerGenChart.BorderlineColor = System.Drawing.Color.DarkGray;
			this.powerGenChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea4.AxisX.IsReversed = true;
			chartArea4.AxisX.Maximum = 50D;
			chartArea4.AxisX.Minimum = 0D;
			chartArea4.AxisY.Maximum = 6D;
			chartArea4.AxisY.Minimum = 0D;
			chartArea4.AxisY.Title = "Power (W)";
			chartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea4.AxisY2.Maximum = 100D;
			chartArea4.AxisY2.Minimum = 0D;
			chartArea4.AxisY2.Title = "Duty Cycle (%)";
			chartArea4.Name = "ChartArea1";
			this.powerGenChart.ChartAreas.Add(chartArea4);
			this.powerGenChart.Location = new System.Drawing.Point(113, 19);
			this.powerGenChart.Name = "powerGenChart";
			this.powerGenChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
			series5.ChartArea = "ChartArea1";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series5.Color = System.Drawing.Color.Firebrick;
			series5.Name = "powerGenPowSeries";
			this.powerGenChart.Series.Add(series5);
			this.powerGenChart.Size = new System.Drawing.Size(356, 300);
			this.powerGenChart.TabIndex = 2;
			this.powerGenChart.Text = "chart3";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Power";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			((System.ComponentModel.ISupportInitialize)(this.SIChart)).EndInit();
			this.connectionStatusGroupBox.ResumeLayout(false);
			this.batteryChargeGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.batteryVisChart)).EndInit();
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
		private System.Windows.Forms.Label SIVoltLabel;
		private System.Windows.Forms.Label SICurrLabel;
		private System.Windows.Forms.DataVisualization.Charting.Chart SIChart;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label distLabel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataVisualization.Charting.Chart batteryVisChart;
		private System.Windows.Forms.Label powGenSrcLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label powGenVoltLabel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label dutyCycleLabel;
		private System.Windows.Forms.Label label1;
	}
}

