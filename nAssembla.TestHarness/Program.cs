using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using nAssembla.TestHarness.Properties;

namespace nAssembla.TestHarness
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var canContinue = !string.IsNullOrEmpty(Settings.Default.ApiKey) && !string.IsNullOrEmpty(Settings.Default.ApiSecret)
                && !string.IsNullOrEmpty(Settings.Default.ClientKey) && !string.IsNullOrEmpty(Settings.Default.ClientSecret);

            if (!canContinue)
            {
                var auth = new ApiKeyAuthenticate();
                canContinue = auth.ShowDialog() == DialogResult.OK;
            }


            if (canContinue && !string.IsNullOrEmpty(Settings.Default.ApiKey) && !string.IsNullOrEmpty(Settings.Default.ApiSecret))
            {
                nAssembla.Configuration.ApiKey = Settings.Default.ApiKey;
                nAssembla.Configuration.ApiSecret = Settings.Default.ApiSecret;
                Application.Run(new MainForm()); 
            }
            else if (canContinue && !string.IsNullOrEmpty(Settings.Default.ClientKey) && !string.IsNullOrEmpty(Settings.Default.ClientSecret))
            {
                nAssembla.Configuration.ClientId = Settings.Default.ClientKey;
                nAssembla.Configuration.ClientSecret = Settings.Default.ClientSecret;

                var f1 = new PINAuthenticate();
                DialogResult dr = f1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Application.Run(new MainForm()); 
                }
                else
                {
                    Application.Exit();
                } 
            }
            else
                Application.Exit();           
        }
    }
}
