using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace TestCommsApp
{
    public partial class CommsTestForm : Form
    {
        SerialPort port;

        public CommsTestForm()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(CommsTestForm_FormClosed);
            if (port == null)
            {
                port = new SerialPort("COM3", 9600);//Set board COM
                port.Open();
            }
        }

        void CommsTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }

        private void btnLedOn_Click(object sender, EventArgs e)
        {
            PortWrite("1");
        }

        private void btnLedOff_Click(object sender, EventArgs e)
        {
            PortWrite("0");
        }

        private void PortWrite(string message)
        {
            port.Write(message);
        }
    }
}
