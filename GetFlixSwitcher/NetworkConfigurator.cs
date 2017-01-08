using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;

namespace GetFlixSwitcher
{
    /// <summary>
    /// Helper class to set networking configuration like IP address, DNS servers, etc.
    /// </summary>
    public class NetworkConfigurator
    {
        public static void SetDns(string dnsServer, string adapter = "")
        {
            ExecuteInCmd($@"/C netsh interface ipv4 add dnsserver ""{adapter}"" address={dnsServer} index=1");
        }

        public static void AutoDns(string adapter)
        {
            ExecuteInCmd($@"/K netsh interface ip set dns name=""{adapter}"" dhcp");
        }

        public static void ExecuteInCmd(string line)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                Verb = "runas",
                Arguments = line
            };
            process.StartInfo = startInfo;
            process.Start();
        }

        /// <PARAM name="dnses">Array of DNS IP</PARAM>
        public static List<string> GetAdapters()
        {
            List<string> adapters = new List<string>();
            var nics = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
            foreach (var nic in nics)
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    adapters.Add(nic.Name);
                    Console.WriteLine(nic.Name);
                }

            }

            

            return adapters;
        }

    }


}