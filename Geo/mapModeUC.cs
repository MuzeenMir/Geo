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

namespace Geo
{
    public partial class mapModeUC : UserControl
    {
        public mapModeUC()
        {
            InitializeComponent();
            this.Load += mapModeUC_Load;
        }

        private async void mapModeUC_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            //string htmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "map.html");
            string htmlFilePath = "..\\..\\Resources\\map.html";
            if (!File.Exists(htmlFilePath))
            {
                MessageBox.Show("HTML file not found: " + htmlFilePath);
                return;
            }
            string fileUri = new Uri(htmlFilePath).AbsoluteUri;

            // Optionally navigate to your HTML file.
            webView21.CoreWebView2.Navigate(fileUri);

        }
    }
}
