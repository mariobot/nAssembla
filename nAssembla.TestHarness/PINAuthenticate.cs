using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nAssembla.TestHarness
{
    public partial class PINAuthenticate : Form
    {
        public PINAuthenticate()
        {
            InitializeComponent();
            Load += Authenticate_Load;
        }

        void Authenticate_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = nAssembla.Proxy.AuthenticationProxy.PinAuthorizationUrl;            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var pinCode = 0;
            if (int.TryParse(textBox1.Text, out pinCode))
                ContinueLogon(pinCode);
        }

        private async void ContinueLogon(int pinCode)
        {
            textBox1.Enabled = false;
            button1.Enabled = false;
            try
            {
                var ret = await new nAssembla.Proxy.AuthenticationProxy().AuthenticateWithPin(pinCode);

                if (ret)
                    this.DialogResult = DialogResult.OK;

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Logon error");
            }           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var browser = sender as WebBrowser;

            if (browser != null)
            {
                var html = browser.DocumentText;

                var regEx = new System.Text.RegularExpressions.Regex(@"<H1>(\d+)</H1>", System.Text.RegularExpressions.RegexOptions.Multiline | System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                                
                var match = regEx.Match(html);
                if (match.Success && match.Groups.Count == 2)
                {
                    var pinCode = 0;
                    if (int.TryParse(match.Groups[1].Value, out pinCode))
                        ContinueLogon(pinCode);
                }                
            }
        }
    }
}
