using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ReadIPAddress
{
    public class ReadIPAddress
    {
        //To Find IPAddress
        public static string GetIPAddress()
        {
            string ipAddress = string.Empty;
            string Hostname = string.Empty;
            try
            {
                IPHostEntry Host = default(IPHostEntry);
                Hostname = System.Environment.MachineName;
                Host = Dns.GetHostEntry(Hostname);
                foreach (IPAddress IP in Host.AddressList)
                {
                    if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        ipAddress = Convert.ToString(IP);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ipAddress;

        }

        public static string GetClientIPAddress()
        {
            string ipAddress = string.Empty;
            try
            {
                ipAddress = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

                if (string.IsNullOrEmpty(ipAddress))
                {
                    ipAddress = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }
                else if (!String.IsNullOrWhiteSpace(HttpContext.Current.Request.UserHostAddress))
                {
                    ipAddress = HttpContext.Current.Request.UserHostAddress;
                }

            }
            catch (Exception ex)
            {
                throw ex;
                
            }

            return ipAddress;
        }


        // Get IPAddress from Machine name(Hostname)
        public static string GetIPAddressFromMachineName(string machineName)
        {
            string ipAdress = string.Empty;
            try
            {
                IPAddress[] ipAddresses = Dns.GetHostAddresses(machineName);
                IPAddress ip = ipAddresses[1];
                ipAdress = ip.ToString();
            }

            catch (Exception ex)
            {
                // Machine not found...
            }
            return ipAdress;
        }

        //Get Machine name from IP Address 
        public static string GetMachineNameFromIPAddress(string ipAdress)
        {
            string machineName = string.Empty;
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(ipAdress);
                machineName = hostEntry.HostName;
            }
            catch (Exception ex)
            {
                // Machine not found...
            }
            return machineName;
        }

        // Get MacAddress using this method
        public static string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }
    }
}
