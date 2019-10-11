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

namespace serialConnection
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            PortRefresh();
        }

        private void PortRefresh()
        {
            cboPorts.Items.Clear();
            cboPorts.Items.AddRange(SerialPort.GetPortNames());
        }

        private void cmdExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            if(cboPorts.SelectedIndex == -1)  // Nothing selected
            {
                lblStatus.Text = "No Port selected";
            }
            else
            {
                serialPort1.PortName = cboPorts.SelectedItem.ToString();
                if(!serialPort1.IsOpen)
                {
                    serialPort1.Open(); //Open serial port connection
                    lblStatus.Text = "Serial Connection Established";
                }
                else
                {
                    lblStatus.Text = "Serial Connection Open";
                    MessageBox.Show("Attention serial Port is open");
                }
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            lblStatus.Text = "Serial Port Closed";
        }
    }
}
