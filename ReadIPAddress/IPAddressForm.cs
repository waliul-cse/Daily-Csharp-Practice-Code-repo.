using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadIPAddress
{
    public partial class IPAddressForm : Form
    {
        public IPAddressForm()
        {
            InitializeComponent();
        }
        private void btnIPAdress1_Click(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName();
            string ip = ReadIPAddress.GetIPAddress();
            txtIPAddress.Text = ip.ToString();
        }

        private void btnIPAddress2_Click(object sender, EventArgs e)
        {
            string clientIP = ReadIPAddress.GetClientIPAddress();
            txtIPAddress.Text = clientIP;

            //Get machineName/hostName from IP Address
            //string machineName = ReadIPAddress.GetMachineNameFromIPAddress(clientIP);
            //txtIPAddress.Text = machineName;

            //Get IPAddress from MachineName 
            //string ipAddress = ReadIPAddress.GetIPAddressFromMachineName(machineName);

        }

        private void btnIPAddress3_Click(object sender, EventArgs e)
        {
            //Get machineName or hostName
            string machineName = Dns.GetHostName();

            //Get IPAddress simple
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            txtIPAddress.Text = machineName + "  " + IPHost.AddressList[0].ToString();

        }
    }
}
