using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GetFlixSwitcher
{
    public partial class Form1 : Form
    {
        private DnsEditor _dnsEditor;
        private NotificationService _notificationService;

        private HttpClient _client;
        private DnsLocation _dnsLocation;

        private const string Url = "http://catfacts-api.appspot.com/api/facts";

        public delegate void FormLoadedHandler(object source, EventArgs args);

        public event EventHandler<EventArgs> FormLoaded;



        public Form1()
        {
            InitializeComponent();

            _dnsLocation = new DnsLocation();
            FormLoaded += _dnsLocation.OnMajorAction;

            _dnsEditor = new DnsEditor();
            _notificationService = new NotificationService();
            _dnsEditor.DnsChanged += _notificationService.OnDnsChanged;
            _dnsEditor.DnsChanged += _dnsLocation.OnMajorAction;
            NetworkConfigurator.GetAdapters();
            _client = new HttpClient();

            GetQuote();
            OnFormLoaded();
        }
        protected virtual void OnFormLoaded()
        {
            if (FormLoaded != null) //Check to see if there are any subscribers
                FormLoaded(this, EventArgs.Empty);
        }

        public async void GetQuote()
        {
            var content =await _client.GetStringAsync(Url);
            var facts = JsonConvert.DeserializeObject<Fact>(content);
            if (facts.Success)
                txtFact.Text = facts.Facts.First();
            //var facts = JsonConvert.DeserializeObject<List<Fact>>(content);

        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            _dnsEditor.UpdateDns(new Location { Name = "Australia", Local = true });
            var btn = (ToolStripButton)(sender);
            btn.Checked = true;
            btnOverseas.Checked = false;
        }

        private void btnOverseas_Click(object sender, EventArgs e)
        {
            _dnsEditor.UpdateDns(new Location { Name = "Overseas", Local = false, DnsServer = "168.1.79.229" });
            var btn = (ToolStripButton) (sender);
            btn.Checked = true;
            btnLocal.Checked = false;
        }

        private void txtFact_DoubleClick(object sender, EventArgs e)
        {
            GetQuote();
        }
    }

    public class DnsLocation
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private HttpClient _client;
        private const string Url = "https://www.getflix.com.au/api/locations.json";


        public async void OnMajorAction(object sender, EventArgs e)
        {
            _client = new HttpClient();
            var content = await _client.GetStringAsync(Url);
            var dnsLocations = JsonConvert.DeserializeObject<List<DnsLocation>>(content);
            foreach (var location in dnsLocations)
            {
                Console.WriteLine(location.Name);
            }
        }
    }
    
}
