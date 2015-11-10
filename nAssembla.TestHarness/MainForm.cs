using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nAssembla.DTO.Interfaces;
using nAssembla.TestHarness.Properties;

namespace nAssembla.TestHarness
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //var serialized = Settings.Default.SerializedCache;
            //var dataCache = new DTO.DataCache();
            //if (!string.IsNullOrEmpty(serialized))
            //    dataCache = Newtonsoft.Json.JsonConvert.DeserializeObject<DTO.DataCache>(serialized);

            //if (dataCache != null)
            //{
            //    foreach (var s in dataCache.Spaces)
            //    {
            //        spacesCombo.Items.Add(s.Value.Space);
            //    }
            //}
            //else
            //{

            statusLabel.Text = "Retrieving spaces...";

            var currentUser = await NAssembla.UserProxy.GetCurrentUserAsync(true);

            this.Text = this.Text + ": " + currentUser.Name;

            var spaces = await NAssembla.SpaceProxy.GetListAsync();
            foreach (var item in spaces)
            {
                spacesCombo.Items.Add(item);
            }
            //}

            statusLabel.Text = "Listo";
        }

        private async void spacesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var thisSpace = (DTO.Space)spacesCombo.SelectedItem;

            nAssembla.Configuration.SpaceName = thisSpace.Name;

            var serialized = Settings.Default.SerializedCache;
            var dataCache = new nAssembla.Cache.DataCache();
            
	  if (!string.IsNullOrEmpty(serialized))
                dataCache = Newtonsoft.Json.JsonConvert.DeserializeObject<nAssembla.Cache.DataCache>(serialized);

            var spacecache = default(nAssembla.Cache.SpaceDataCache);

            if (!dataCache.Spaces.TryGetValue(thisSpace.Id, out spacecache))
            {
                statusLabel.Text = "LLenando cache data...";
                spacecache = await NAssembla.GetSpaceDataCache(thisSpace.Id);
                dataCache.Spaces.Add(thisSpace.Id, spacecache);
                serialized = await Newtonsoft.Json.JsonConvert.SerializeObjectAsync(dataCache);
                Settings.Default.SerializedCache = serialized;
                Settings.Default.Save();
            }
            else
            {
                NAssembla.SetSpaceDataCache(spacecache);
            }

            statusLabel.Text = "Getting activity for space...";

            streamPanel.Controls.Clear();
            var stream = await NAssembla.ActivityProxy.Space(thisSpace.Id).DateFrom(DateTime.Today.AddDays(-2)).GetListAsync();
            stream.ToList().ForEach(s =>
            {
                var ctl = new TestHarness.Controls.StreamEvent();
                ctl.DataSource = s;
                streamPanel.Controls.Add(ctl);
            });

            reportsCombo.SelectedItem = null;
            reportsCombo.Items.Clear();
            reportsCombo.Enabled = false;

            var customReports = await NAssembla.CustomReportProxy.GetListAsync();

            reportsCombo.Items.AddRange(nAssembla.DTO.StandardReports.AllStandardReports.ToArray());
            if (customReports != null)
                reportsCombo.Items.AddRange(customReports.ToArray());
             
            reportsCombo.Enabled = true;
            statusLabel.Text = "Ready";
        }

        private async void reportsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportsGrid.DataSource = null;
            statusLabel.Text = "Retrieving tickets...";
            var report = ((ComboBox)sender).SelectedItem as IReport;

            if (report != null)
            {
                try
                {
                    var tickets = await NAssembla.TicketProxy.GetListByReportIdAsync(report.Id);
                    foreach (var t in tickets)
                    {
                        if (!string.IsNullOrEmpty(t.ReporterId))
                            t.Reporter = await NAssembla.UserProxy.GetAsync(t.ReporterId);
                        if (!string.IsNullOrEmpty(t.AssignedTo))
                            t.Assignee = await NAssembla.UserProxy.GetAsync(t.AssignedTo);
                        if (t.MilestoneId.HasValue)
                            t.Milestone = await NAssembla.MilestoneProxy.GetAsync(t.MilestoneId.Value);
                        if (t.ComponentId.HasValue)
                            t.Component = await NAssembla.TicketComponentProxy.GetAsync(t.ComponentId.Value);

                    }

                    var data = tickets.Select(t => new ViewModel.TicketDetail(t)).ToList();

                    reportsGrid.DataSource = data;
                }
                catch (Exception)
                {

                }

            }

            statusLabel.Text = "Listo calixto";
        }

        private void reportsGrid_DataSourceChanged(object sender, EventArgs e)
        {
            ((DataGridView)sender).Enabled = ((DataGridView)sender).DataSource != null;
        }

        private void ticketDetailBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private async void refreshCache_Click(object sender, EventArgs e)
        {
            var thisSpace = (DTO.Space)spacesCombo.SelectedItem;
            var serialized = Settings.Default.SerializedCache;
            var dataCache = new nAssembla.Cache.DataCache();
            if (!string.IsNullOrEmpty(serialized))
                dataCache = Newtonsoft.Json.JsonConvert.DeserializeObject<nAssembla.Cache.DataCache>(serialized);

            var spacecache = default(nAssembla.Cache.SpaceDataCache);
            statusLabel.Text = "Populating data cache...";
            spacecache = await NAssembla.GetSpaceDataCache(thisSpace.Id);

            if (!dataCache.Spaces.ContainsKey(thisSpace.Id))
                dataCache.Spaces.Add(thisSpace.Id, spacecache);
            else
                dataCache.Spaces[thisSpace.Id] = spacecache;
           
            serialized = await Newtonsoft.Json.JsonConvert.SerializeObjectAsync(dataCache);

            Settings.Default.SerializedCache = serialized;
            Settings.Default.Save();

            statusLabel.Text = "Ready";
        }

        private void reportsGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid != null)
            {
                var data = grid.DataSource as IEnumerable<ViewModel.TicketDetail>;
                var ticket = data.Skip(e.RowIndex).First();
                var ticketEdit = new EditTicket();
                ticketEdit.DataSource = ticket;
                ticketEdit.Show();
            }
        }
    }
}
