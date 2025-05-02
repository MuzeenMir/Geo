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
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geo.Properties;
using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Mysqlx.Notice.Frame.Types;

namespace Geo
{
    public partial class mapModeUC : UserControl
    {
        private List<Question> questionPool;
        private int initialQuestionCount;
        private int score = 0;
        private Question currentQuestion;
        private int answeredQuestionCount;

        public mapModeUC()
        {

            InitializeComponent();
            LoadQuestions();
            this.mapMode10CheckBox.CheckedChanged += QuestionCheckBox_CheckedChanged;
            this.mapMode20CheckBox.CheckedChanged += QuestionCheckBox_CheckedChanged;
            this.mapMode30CheckBox.CheckedChanged += QuestionCheckBox_CheckedChanged;
            this.mapModeMaxCheckBox.CheckedChanged += QuestionCheckBox_CheckedChanged;
            quickPlayMapModeTimeLabel.Visible = false;
            quickPlayMapModeScoreLabel.Visible = false;
            quickPlayMapModeProgressBar.Visible = false;
            quickPlayMapModeQuestionBox.Visible = false;
            quickPlayMapModeQuestionLabel.Visible = false;
            progress_label.Visible = false;
            click_result_btn.Visible = false;

            mapModeStartButton.Enabled = false;

            // Only load the first question if the question pool is not empty
            if (questionPool != null && questionPool.Count > 0)
            {
                LoadNextQuestion();
            }
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
                var questionData = System.Text.Json.JsonSerializer.Deserialize<QuestionData>(jsonData, options);
                questionPool = questionData?.QuestionList ?? new List<Question>();
                initialQuestionCount = questionPool.Count;
                quickPlayMapModeProgressBar.Maximum = initialQuestionCount;
            }
            catch (Exception ex)
            {
                // MessageBox.Show($"Error loading questions: {ex.Message}");

            }
        }

        private void LoadNextQuestion()
        {
            if (answeredQuestionCount >= initialQuestionCount)
            {
                //quizTimer.Stop();
                MessageBox.Show("Quiz completed! Final score: " + score + "\n");
                return;
            }
            if (questionPool == null || questionPool.Count == 0)
            {
                //quizTimer.Stop();
                //MessageBox.Show("Quiz completed! Final score: " + score + "\n" + $"Time Taken: {(300 - timelimit) / 60}m {(300 - timelimit) % 60}s");
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(0, questionPool.Count);
            currentQuestion = questionPool[randomIndex];
            //DisplayQuestion(currentQuestion);
            quickPlayMapModeQuestionBox.Text = currentQuestion.QuestionText;
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
                // Subscribe to the WebMessageReceived event.
                webView21.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
                //string htmlFilePath = "C:\\Users\\franc\\Source\\Repos\\Geo\\Geo\\Resources\\map.html";
                string htmlFilePath = null;
                string[] possiblePaths = new string[]
                {
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "map.html"),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..","..", "Resources", "map.html"),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..","..","..", "Resources", "map.html"),
                };

                foreach (string path in possiblePaths)
                {
                    if (File.Exists(path))
                    {
                        htmlFilePath = path;
                        break;
                    }
                }
                if (htmlFilePath == null)
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
            click_result_btn.Left = (int)(this.Width * 0.65);
            quickPlayMapModeQuestionLabel.Left = (int)(this.Width * 0.65);
            quickPlayMapModeQuestionBox.Left = (int)(this.Width * 0.65);

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

        private void CoreWebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            // Retrieve the JSON message sent from the JavaScript code.
            string myjson = e.WebMessageAsJson;

            // Deserialize the JSON to extract the coordinates (using Newtonsoft.Json).
            dynamic data = JsonConvert.DeserializeObject(myjson);
            string s = data.n;

            // Now you have the click coordinates; for example, you can update your UI or display them.
            //MessageBox.Show($"Got the message: " + s);
            click_result_btn.Text = s;
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
            quickPlayMapModeProgressBar.Maximum = initialQuestionCount;

        }

        private void progress_label_Click(object sender, EventArgs e)
        {

        }

        private void mapModeStartButton_Click(object sender, EventArgs e)
        {
            mapMode10CheckBox.Visible = false;
            mapMode20CheckBox.Visible = false;
            mapMode30CheckBox.Visible = false;
            mapModeMaxCheckBox.Visible = false;
            mapModeStartButton.Visible = false;
            select_difficulty_lbl.Visible = false;
            quickPlayMapModeTimeLabel.Visible = true;
            quickPlayMapModeScoreLabel.Visible = true;
            quickPlayMapModeProgressBar.Visible = true;
            progress_label.Visible = true;
            click_result_btn.Visible = true;
            quickPlayMapModeQuestionBox.Visible = true;
            quickPlayMapModeQuestionLabel.Visible = true;
        }

        private void click_result_btn_Click(object sender, EventArgs e)
        {
            if (currentQuestion == null) return;

            string selectedAnswer = click_result_btn.Text.Trim();
            string correctAnswer = currentQuestion.Answer.Trim();

            if (selectedAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                score++;
                quickPlayMapModeScoreLabel.Text = $"Score: {score}";
            }

            questionPool.Remove(currentQuestion);

            //quickPlayQuizModeProgressBar.Value = initialQuestionCount - questionPool.Count;
            answeredQuestionCount++;
            quickPlayMapModeProgressBar.Value = Math.Min(answeredQuestionCount, quickPlayMapModeProgressBar.Maximum);

            LoadNextQuestion();
        }
    }
}
