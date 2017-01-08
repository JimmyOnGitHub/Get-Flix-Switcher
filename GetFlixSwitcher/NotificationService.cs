using System;

namespace GetFlixSwitcher
{
    public class NotificationService
    {
        public void OnDnsChanged(object source, DnsEventArgs args)
        {
            WriteMessage(args.Location);
        }
        public void WriteMessage(Location location)
        {
            Console.WriteLine($"Location updated to  {location.Name}");
        }

    }
}