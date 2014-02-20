using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace SolarCarLiveMonitor
{
	public partial class Form1 : Form
	{
		//globals
		SerialPort serialPort = new SerialPort();

		public Form1()
		{
			InitializeComponent();

			serialPort.PortName = "COM6";
			serialPort.BaudRate = 9600;
			serialPort.DtrEnable = true;
			try
			{
				serialPort.Open();
			}
			catch
			{
				MessageBox.Show("Unable to connect to serial port");
			}

			serialPort.DataReceived += serialPort_DataReceived;

			powerGenChart.Series[0].Color.Equals(System.Drawing.Color.OrangeRed);
		}

		// shift every x value in the graph over by 1, store only 300 points
		private void graphShift(System.Windows.Forms.DataVisualization.Charting.Chart chart, int seriesIndex)
		{
			for (int i = 0; i < chart.Series[seriesIndex].Points.Count(); i++)
			{
				double x = chart.Series[seriesIndex].Points[i].XValue;
				if (x < 300)
					chart.Series[seriesIndex].Points[i].XValue++;
				else
					chart.Series[seriesIndex].Points.RemoveAt(i);
			}
		}

		delegate void DataReceivedEvent(string data);
		private void DataReceived(string data)
		{
			if (this.SIChart.InvokeRequired || this.batteryChargeChart.InvokeRequired)// || this.batteryVisChart.InvokeRequired || this.powerGenChart.InvokeRequired)
			{
				DataReceivedEvent d = new DataReceivedEvent(DataReceived);
				this.BeginInvoke(d, new object[] { data });
			}
			else
			{
				processData(data);
			}
		}

		private void processData(string data)
		{
			char[] separators = {' ','\r'};
			string[] dataSplit = data.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);
			string field = "";
			string value = "";
			double dVal = 0.0;
			double recentVoltage = 0.0;

			try
			{
				field = dataSplit[0];
				value = dataSplit[1];
			}
			catch (ArgumentOutOfRangeException exception)
			{
				Console.WriteLine(exception);
				//MessageBox.Show(exception.ToString());
				return;
			}
				switch (field)
				{
					// solar intensity voltage
					case "SIV":
						dVal = Convert.ToDouble(value);
						if (dVal < 0.0 || dVal > 16.0)
							return;
						graphShift(SIChart, 0);
						SIChart.Series[0].Points.AddXY(0,dVal);
						SIVoltLabel.Text = value + " V";
						break;
					// solar intensity amplitude
					case "SIC":
						dVal = Convert.ToDouble(value);
						if (dVal < 0.0 || dVal > 200.0)
							return;
						graphShift(SIChart, 1);
						SIChart.Series[1].Points.AddXY(0, dVal);
						SICurrLabel.Text = value + " mA";
						break;
					// duty cycle
					case "DCY":
						dVal = Convert.ToDouble(value);
						if (dVal < 0.0 || dVal > 100.0)
							return;
						dutyCycleLabel.Text = value + "%";
						break;
					// battery charge
					case "BAT":
						dVal = Convert.ToDouble(value);
						if (dVal < 0.0 || dVal > 100.0)
							return;
						graphShift(batteryChargeChart, 0);
						batteryChargeChart.Series[0].Points.AddXY(0, dVal);
						batteryVisChart.Series[0].Points[0].Equals(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, dVal));
						break;
					// power generated
					case "PWR":
						dVal = Convert.ToDouble(value);
						if (dVal < 0.0 || dVal > 16.0)
							return;
						graphShift(powerGenChart, 0);
						powerGenChart.Series[0].Points.AddXY(0, dVal);
						powGenVoltLabel.Text = value + " W";
						break;
					// power source
					case "SRC":
						if (!(value == "S" || value == "B"))
							return;
						else if (value.Equals("S"))
							powGenSrcLabel.Text = "Solar";
						else if (value.Equals("B"))
							powGenSrcLabel.Text = "Battery";
						break;
					// bluetooth device distance
					case "DIS":
						dVal = Convert.ToDouble(value);
						if (dVal < 0.0 || dVal > 150.0)
							return;
						distLabel.Text = value + "m";
						break;
					default:
						break;
				}
		}

		private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			try
			{
				DataReceived(serialPort.ReadLine());
			}
			catch (Exception ex)
			{
				DataReceived("error");
			}
		}

	}
}
