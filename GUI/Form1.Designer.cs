namespace UartDataViewer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.ComboBox comboBoxBaudRates;
        private System.Windows.Forms.TextBox textBoxSensor1;
        private System.Windows.Forms.TextBox textBoxSensor2;
        private System.Windows.Forms.TextBox textBoxSensor3;
        private System.Windows.Forms.TextBox textBoxSensor4;
        private System.Windows.Forms.TextBox textBoxSensor5;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRates = new System.Windows.Forms.ComboBox();
            this.textBoxSensor1 = new System.Windows.Forms.TextBox();
            this.textBoxSensor2 = new System.Windows.Forms.TextBox();
            this.textBoxSensor3 = new System.Windows.Forms.TextBox();
            this.textBoxSensor4 = new System.Windows.Forms.TextBox();
            this.textBoxSensor5 = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();

            // Initialize other controls as needed

            this.SuspendLayout();

            // Setup properties and positions for each control

            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(10, 10);
            this.comboBoxPorts.Name = "comboBoxPorts";
            // Other properties...

            this.comboBoxBaudRates.FormattingEnabled = true;
            this.comboBoxBaudRates.Location = new System.Drawing.Point(10, 40);
            this.comboBoxBaudRates.Name = "comboBoxBaudRates";
            // Other properties...

            this.textBoxSensor1.Location = new System.Drawing.Point(10, 70);
            this.textBoxSensor1.Name = "textBoxSensor1";
            // Other properties...

            this.textBoxSensor2.Location = new System.Drawing.Point(10, 100);
            this.textBoxSensor2.Name = "textBoxSensor2";
            // Other properties...

            this.textBoxSensor3.Location = new System.Drawing.Point(10, 130);
            this.textBoxSensor3.Name = "textBoxSensor3";
            // Other properties...

            this.textBoxSensor4.Location = new System.Drawing.Point(10, 160);
            this.textBoxSensor4.Name = "textBoxSensor4";
            // Other properties...

            this.textBoxSensor5.Location = new System.Drawing.Point(10, 190);
            this.textBoxSensor5.Name = "textBoxSensor5";
            // Other properties...

            // Connect Button
            this.connectButton.Location = new System.Drawing.Point(10, 220);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.Text = "Connect";
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);

            // Disconnect Button
            this.disconnectButton.Location = new System.Drawing.Point(100, 220);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.Enabled = false; // Initially disabled
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);

            // Add controls to the form
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.comboBoxBaudRates);
            this.Controls.Add(this.textBoxSensor1);
            this.Controls.Add(this.textBoxSensor2);
            this.Controls.Add(this.textBoxSensor3);
            this.Controls.Add(this.textBoxSensor4);
            this.Controls.Add(this.textBoxSensor5);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.disconnectButton);

            // Other controls initialization...

            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Name = "Form1";
            this.Text = "Sensor Data Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
