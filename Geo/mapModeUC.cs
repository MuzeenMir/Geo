using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geo.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Geo
{
    public partial class mapModeUC : UserControl
    {
        private List<Question> questionPool;
        private int initialQuestionCount;

        public mapModeUC()
        {

            InitializeComponent();
            LoadQuestions();
            this.mapMode10CheckBox.CheckedChanged += QuestionCheckBox_CheckedChanged;
            this.mapMode20CheckBox.CheckedChanged += QuestionCheckBox_CheckedChanged;
            this.mapMode30CheckBox.CheckedChanged += QuestionCheckBox_CheckedChanged;
            this.mapModeMaxCheckBox.CheckedChanged += QuestionCheckBox_CheckedChanged;
            //quickPlayMapModeTimeLabel.Visible = false;
            //quickPlayMapModeScoreLabel.Visible = false;
            //quickPlayMapModeProgressBar.Visible = false;
            //progress_label.Visible = false;

            mapModeStartButton.Enabled = false;
            webView21.Dock = DockStyle.Left;
            webView21.Width = this.Width / 2;
            //this.Load += mapModeUC_Load;
            // Avoid initializing WebView2 if in design mode.
            if (!this.IsInDesignMode())
            {
                mapModeUC_Load();
            }
        }

        private void LoadQuestions()
        {
            try
            {
                string jsonFilePath = "..\\..\\Resources\\geoQuestions.json";
                string jsonData = File.ReadAllText(jsonFilePath);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var questionData = JsonSerializer.Deserialize<QuestionData>(jsonData, options);
                questionPool = questionData?.QuestionList ?? new List<Question>();
                initialQuestionCount = questionPool.Count;
                quickPlayMapModeProgressBar.Maximum = initialQuestionCount;
            }
            catch (Exception ex)
            {
                // MessageBox.Show($"Error loading questions: {ex.Message}");

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

            if (webView21 != null)
            {
                webView21.Width = this.Width / 2;
            }
            select_difficulty_lbl.Left = (int)(this.Width * 0.65);
            mapMode10CheckBox.Left = (int)(this.Width * 0.65);
            mapMode20CheckBox.Left = (int)(this.Width * 0.65);
            mapMode30CheckBox.Left = (int)(this.Width * 0.65);
            mapModeMaxCheckBox.Left = (int)(this.Width * 0.65);
            mapModeStartButton.Left = (int)(this.Width * 0.65);

            quickPlayMapModeTimeLabel.Left = this.Width - quickPlayMapModeTimeLabel.Width - 10;
            quickPlayMapModeTimeLabel.Top = 10;
            quickPlayMapModeScoreLabel.Left = this.Width - quickPlayMapModeScoreLabel.Width - 10;
            quickPlayMapModeScoreLabel.Top = this.Height - quickPlayMapModeScoreLabel.Height - 50;

            quickPlayMapModeProgressBar.Left = (int)(this.Width * 0.65);
            progress_label.Left = (int)(quickPlayMapModeProgressBar.Left + (quickPlayMapModeProgressBar.Width / 2) - (progress_label.Width / 2));
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void QuestionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkedBox = sender as CheckBox;

            if (!checkedBox.Checked)
            {
                // Check if at least one checkbox is still checked
                bool anyChecked = false;
                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox cb && cb.Checked)
                    {
                        anyChecked = true;
                        break;
                    }
                }

                // If none are checked, prevent unchecking this one
                if (!anyChecked)
                {
                    checkedBox.Checked = true;
                }

                
            }
            else
            {
                mapModeStartButton.Enabled = true;
                // Uncheck all other checkboxes when one is checked
                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox cb && cb != checkedBox)
                    {
                        cb.Checked = false;
                    }
                }
            }
            
            switch (checkedBox.Name)
            {
                case "mapMode10CheckBox":
                    initialQuestionCount = 10;
                    break;
                case "mapMode20CheckBox":
                    initialQuestionCount = 20;
                    break;
                case "mapMode30CheckBox":
                    initialQuestionCount = 30;
                    break;
                case "mapModeMaxCheckBox":
                    initialQuestionCount = 50;
                    break;
                default:
                    break;

            }
            
        }

        private void progress_label_Click(object sender, EventArgs e)
        {

        }
    }
}
