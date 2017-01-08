using System;
using System.Linq;

namespace GetFlixSwitcher
{
    public class DnsEditor
    {
        public delegate void DnsUpdatedEnventHandler(object source, DnsEventArgs args);

        public event EventHandler<DnsEventArgs> DnsChanged;
        public void UpdateDns(Location location)
        {
            
            
            if (location.Local)
            {
                NetworkConfigurator.AutoDns("Wi-Fi");                
            }
            else
            {
                NetworkConfigurator.SetDns(location.DnsServer, "Wi-Fi");
            }
                
            OnDnsChanged(location);
        }

        protected virtual void OnDnsChanged(Location location)
        {
            if (DnsChanged != null) //Check to see if there are any subscribers
                DnsChanged(this, new DnsEventArgs {Location = location});
        }
    }
}