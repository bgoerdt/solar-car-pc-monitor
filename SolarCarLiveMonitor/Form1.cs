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

			//connect to Bluetooth device
			connected = true; // while testing

			//obtain a value from Bluetooth device
			getTestData(); // while testing

			while (connected)
			{
				while (dataQueue.Count != 0)
				{
					string data = dataQueue.Dequeue();

					try
					{
						string field = data.Substring(0, 3);
						double value = Convert.ToDouble(data.Substring(4));

						switch (field)
						{
							// solar intensity voltage
							case "SIV":
								if (value < 0.0 || value > 16.0)
									continue;
								
								break;
							// solar intensity amplitude
							case "SIA":
								if (value < 0.0 || value > 2.0)
									continue;
								break;
							// duty cycle
							case "DCY":
								if (value < 33.0 || value > 100.0)
									continue;
								break;
							// battery charge
							case "BAT":
								if (value < 0.0 || value > 100.0)
									continue;
								break;
							// power generated
							case "PWR":
								if (value < 0.0 || value > 16.0)
									continue;
								break;
							// power source
							case "SRC":
								string src = value.ToString();
								if (src != "S" || src != "B")
									continue;
								break;
							// bluetooth device distance
							case "DIS":
								if (value < 0.0 || value > 150.0)
									continue;
								break;
							default:
								break;
						}

						// while testing
						System.Threading.Thread.Sleep(1000);
					}
					catch (Exception e)
					{
						continue;
					}
				}
			}


		}

		// get test data from txt file and place in data queue
		public void getTestData()
		{

		}




	}
}
