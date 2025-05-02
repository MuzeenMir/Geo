using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geo.Properties;

namespace Geo
{
    public partial class mapModeUC : UserControl
    {
        public mapModeUC()
        {
            InitializeComponent();
            //this.Load += mapModeUC_Load;
            // Avoid initializing WebView2 if in design mode.
            if (!this.IsInDesignMode())
            {
                mapModeUC_Load();
            }
        }

        // Helper method to robustly detect design mode.
        private bool IsInDesignMode()
        {
            return (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) ||
                   (this.Site != null && this.Site.DesignMode);
        }

        private async void mapModeUC_Load()
        {
            try
            {
                await webView21.EnsureCoreWebView2Async(null);
                //string htmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "map.html");
                string htmlFilePath = "C:\\Users\\franc\\Source\\Repos\\Geo\\Geo\\Resources\\map.html";
                if (!File.Exists(htmlFilePath))
                {
                    MessageBox.Show("HTML file not found: " + htmlFilePath);
                    return;
                }
                string fileUri = new Uri(htmlFilePath).AbsoluteUri;

                // Optionally navigate to your HTML file.
                webView21.CoreWebView2.Navigate(fileUri);
            }
            catch(Exception ex)
            {
                MessageBox.Show("WebView2 User Control initialization failed: " + ex.Message);
            }

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Width = this.Parent?.Width / 2 ?? this.Width;
        }
    }
}
