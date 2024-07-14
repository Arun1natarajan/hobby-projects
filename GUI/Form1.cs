using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace UartDataViewer
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private StringBuilder dataBuffer = new StringBuilder();

        public Form1()
        {
            InitializeComponent();

            // Initialize SerialPort
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600; // Adjust baud rate according to your device
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            // Initialize ComboBoxes and other controls
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            // Populate the ComboBox with available COM ports
            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxPorts.Items.Count > 0)
            {
                comboBoxPorts.SelectedIndex = 0; // Select the first available port by default
            }

            // Populate the ComboBox with common baud rates
            comboBoxBaudRates.Items.AddRange(new object[] {
                300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200
            });
            comboBoxBaudRates.SelectedIndex = 5; // Default to 9600 baud rate
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                if (comboBoxPorts.SelectedItem != null && comboBoxBaudRates.SelectedItem != null)
                {
                    serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialPort.BaudRate = (int)comboBoxBaudRates.SelectedItem;
                    serialPort.Open();

                    // Disable Connect button and enable Disconnect button
                    connectButton.Enabled = false;
                    disconnectButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please select a COM port and a baud rate first.");
                }
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();

                // Enable Connect button and disable Disconnect button
                connectButton.Enabled = true;
                disconnectButton.Enabled = false;
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string data = sp.ReadExisting();

            // Append received data to buffer
            dataBuffer.Append(data);

            // Process data buffer
            ProcessDataBuffer();
        }

        private void ProcessDataBuffer()
        {
            string buffer = dataBuffer.ToString();
            string[] lines = buffer.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                UpdateSensorData(line);
            }

            // Remove processed data from buffer
            int lastIndex = buffer.LastIndexOf(Environment.NewLine);
            if (lastIndex >= 0)
            {
                dataBuffer.Remove(0, lastIndex + Environment.NewLine.Length);
            }
        }

        private void UpdateSensorData(string data)
        {
            this.BeginInvoke(new MethodInvoker(delegate {
                string[] sensorData = data.Trim().Split(',');
                if (sensorData.Length >= 5)
                {
                    textBoxSensor1.Text = sensorData[0];
                    textBoxSensor2.Text = sensorData[1];
                    textBoxSensor3.Text = sensorData[2];
                    textBoxSensor4.Text = sensorData[3];
                    textBoxSensor5.Text = sensorData[4];
                }
            }));
        }
    }
}
