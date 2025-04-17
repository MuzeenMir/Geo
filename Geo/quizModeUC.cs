using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Geo
{
    public partial class quizModeUC : UserControl
    {
        private List<Question> questionPool;
        private Question currentQuestion;
        private int initialQuestionCount;
        private int score = 0;

        public quizModeUC()
        {
            InitializeComponent();
            LoadQuestions();
            // Wire up option button click events
            quickPlayQuicModeOptionOneButton.Click += OptionButton_Click;
            quickPlayQuicModeOptionTwoButton.Click += OptionButton_Click;
            quickPlayQuicModeOptionThreeButton.Click += OptionButton_Click;
            quickPlayQuicModeOptionFourButton.Click += OptionButton_Click;
            // Load first question
            LoadNextQuestion();
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
                quickPlayQuizModeProgressBar.Maximum = initialQuestionCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading questions: {ex.Message}");
            }
        }

        private void LoadNextQuestion()
        {
            if (questionPool == null || questionPool.Count == 0)
            {
                MessageBox.Show("Quiz completed! Final score: " + score);
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(0, questionPool.Count);
            currentQuestion = questionPool[randomIndex];
            DisplayQuestion(currentQuestion);
        }

        private void DisplayQuestion(Question question)
        {
            quickPlayQuizModeQuestionBox.Text = question.QuestionText;
            quickPlayQuicModeOptionOneButton.Text = question.Opt1;
            quickPlayQuicModeOptionTwoButton.Text = question.Opt2;
            quickPlayQuicModeOptionThreeButton.Text = question.Opt3;
            quickPlayQuicModeOptionFourButton.Text = question.Opt4;
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            if (currentQuestion == null) return;

            Button selectedButton = (Button)sender;
            string selectedAnswer = selectedButton.Text.Trim();
            string correctAnswer = currentQuestion.Answer.Trim();

            if (selectedAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                score++;
                quickPlayQuizModeScoreLabel.Text = $"Score: {score}";
            }

            questionPool.Remove(currentQuestion);

            quickPlayQuizModeProgressBar.Value = initialQuestionCount - questionPool.Count;

            LoadNextQuestion();
        }

        private void quickPlayQuizModeQuestionBox_Click(object sender, EventArgs e)
        {
            LoadNextQuestion();
        }
    }

    public class QuestionData
    {
        [JsonPropertyName("questionList")]
        public List<Question> QuestionList { get; set; }
    }

    public class Question
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("question")]
        public string QuestionText { get; set; }

        [JsonPropertyName("opt1")]
        public string Opt1 { get; set; }

        [JsonPropertyName("opt2")]
        public string Opt2 { get; set; }

        [JsonPropertyName("opt3")]
        public string Opt3 { get; set; }

        [JsonPropertyName("opt4")]
        public string Opt4 { get; set; }

        [JsonPropertyName("answer")]
        public string Answer { get; set; }
    }
}