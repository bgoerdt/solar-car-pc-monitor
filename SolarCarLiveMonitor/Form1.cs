using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace SolarCarLiveMonitor
{
	public partial class Form1 : Form
	{
		//globals
		SerialPort serialPort = new SerialPort();
		Queue<string> dataQueue = new Queue<string>();
		bool connected = false;

		public Form1()
		{
			InitializeComponent();

			processBluetooth();

		}

		private void processBluetooth()
		{
			//connect to Bluetooth device
			connected = true; // while testing

			//obtain a value from Bluetooth device
			getTestData(); // while testing

			while (connected)
			{
				while (dataQueue.Count != 0)
				{
					string data = dataQueue.Dequeue();
					string field = "";
					string value = "";
					double dVal = 0.0;

					try
					{
						field = data.Substring(0, 3);
						value = data.Substring(4);
					}
					catch (ArgumentOutOfRangeException exception)
					{
						Console.WriteLine(exception);
						//MessageBox.Show(exception.ToString());
						continue;
					}
						switch (field)
						{
							// solar intensity voltage
							case "SIV":
								dVal = Convert.ToDouble(value);
								if (dVal < 0.0 || dVal > 16.0)
									continue;
								SIChart.Series["SIVoltageSeries"].Points.AddXY(0,dVal);
								SIVoltLabel.Text = value + " V";
								break;
							// solar intensity amplitude
							case "SIA":
								dVal = Convert.ToDouble(value);
								if (dVal < 0.0 || dVal > 2.0)
									continue;
								SIChart.Series["SICurrentSeries"].Points.AddXY(0, dVal);
								SICurrLabel.Text = value + " C";
								break;
							// duty cycle
							case "DCY":
								dVal = Convert.ToDouble(value);
								if (dVal < 33.0 || dVal > 100.0)
									continue;
								dutyCycleLabel.Text = value + "%";
								break;
							// battery charge
							case "BAT":
								dVal = Convert.ToDouble(value);
								if (dVal < 0.0 || dVal > 100.0)
									continue;
								batteryChargeChart.Series[0].Points.AddXY(0, dVal);
								batteryVisChart.Series[0].Points[0].Equals(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, dVal));
								break;
							// power generated
							case "PWR":
								dVal = Convert.ToDouble(value);
								if (dVal < 0.0 || dVal > 16.0)
									continue;
								powerGenChart.Series[0].Points.AddXY(0, dVal);
								powGenVoltLabel.Text = value + " V";
								break;
							// power source
							case "SRC":
								if (!(value == "S" || value == "B"))
									continue;
								else if (value.Equals("S"))
									powGenSrcLabel.Text = "Solar";
								else if (value.Equals("B"))
									powGenSrcLabel.Text = "Battery";
								break;
							// bluetooth device distance
							case "DIS":
								dVal = Convert.ToDouble(value);
								if (dVal < 0.0 || dVal > 150.0)
									continue;
								distLabel.Text = value + "m";
								// while testing
								System.Threading.Thread.Sleep(1000);
								Console.WriteLine(dataQueue.Count.ToString());
								break;
							default:
								break;
						}
				}
			}
		}


		// get test data from txt file and place in data queue
		public void getTestData()
		{
			StreamReader reader = new StreamReader("..//..//bluetoothTestData.txt");
			string line = "";
			while ((line = reader.ReadLine()) != null)
			{
				if(!line.Equals(""))
					dataQueue.Enqueue(line);
			}
		}




	}
}
