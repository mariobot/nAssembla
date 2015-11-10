using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nAssembla.TestHarness.Properties;

namespace nAssembla.TestHarness
{
    public partial class ApiKeyAuthenticate : Form
    {
        public ApiKeyAuthenticate()
        {
            InitializeComponent();
            Load += ApiKeyAuthenticate_Load;
            
        }

        void ApiKeyAuthenticate_Load(object sender, EventArgs e)
        {
            apiKey.Text = Settings.Default.ApiKey;
            apiSecret.Text = Settings.Default.ApiSecret;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.assembla.com/user/edit/manage_clients");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(apiKey, null);
            errorProvider1.SetError(apiSecret, null);

            if (string.IsNullOrWhiteSpace(apiKey.Text))
                errorProvider1.SetError(apiKey, "API Key is required");
            if (string.IsNullOrWhiteSpace(apiSecret.Text))               
                errorProvider1.SetError(apiSecret, "API Secret is required");

            if (!string.IsNullOrWhiteSpace(apiKey.Text) && !string.IsNullOrWhiteSpace(apiSecret.Text))
            {
                Settings.Default.ApiKey = apiKey.Text;
                Settings.Default.ApiSecret = apiSecret.Text;
                Settings.Default.Save();
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
