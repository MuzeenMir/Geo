using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Geo
{


    public partial class mainForm : Form
    {
        private readonly string csvFilePath = "C:\\Users\\MirMu\\source\\repos\\Geo\\Geo\\Resources\\userCreds.csv";
        private bool loggedOn = false;
        private Timer colorChangeTimer;
        private Random random;

        DB usersDB = new DB();

        public mainForm()
        {
            InitializeComponent();
            InitializeUI();
            InitializeColorChangeTimer();
            mainTabControl.SelectedTab = mainMenuTab;
        }

        private void InitializeUI()
        {
            quickPlayPanel.Visible = false;
            loginPanel.Visible = false;
            signUpPlanel.Visible = false;
            learnPanel.Visible = false;
            userLoginButton.Visible = false;
            saveSignupInfoButton.Visible = false;
        }

        private void InitializeColorChangeTimer()
        {
            random = new Random();
            colorChangeTimer = new Timer();
            colorChangeTimer.Interval = 1000; // 1 second
            colorChangeTimer.Tick += ColorChangeTimer_Tick;
            colorChangeTimer.Start();
        }
        private void ColorChangeTimer_Tick(object sender, EventArgs e)
        {
            gameNameLabel.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            if (loggedOn == true)
            {
                learnPanel.Visible = true;
                startButtonsPanel.Visible = false;
            }
            else
            {
                mainTabControl.SelectedTab = loginTab;
            }
        }

        private void quickplayButton_Click(object sender, EventArgs e)
        {
            quickPlayPanel.Visible = true;
            startButtonsPanel.Visible = false;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void gameNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void quickPlayPanel_Paint(object sender, PaintEventArgs e)
        {
            quickPlayPanel.BackColor = Color.FromArgb(128, 128, 128, 128);
        }

        private void learnPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mapModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void quizModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void quickPlay_PlayButton_Click(object sender, EventArgs e)
        {


        }

        private void quickPlay_ReturnButton_Click(object sender, EventArgs e)
        {
            quickPlayPanel.Visible = false;
            startButtonsPanel.Visible = true;
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logiin_LoginButton_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            logiin_LoginButton.Visible = false;
            login_SignUpButton.Visible = false;
            userLoginButton.Visible = true;
        }

        private void login_SignUpButton_Click(object sender, EventArgs e)
        {
            logiin_LoginButton.Visible = false;
            login_SignUpButton.Visible = false;
            signUpPlanel.Visible = true;
            saveSignupInfoButton.Visible = true;
        }

        private void signUpPlanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_returnButton_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            logiin_LoginButton.Visible = true;
            login_SignUpButton.Visible = true;
            userLoginButton.Visible = false;
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupReturnButton_Click(object sender, EventArgs e)
        {
            signUpPlanel.Visible = false;
            logiin_LoginButton.Visible = true;
            login_SignUpButton.Visible = true;
            saveSignupInfoButton.Visible = false;
        }

        private void signupUsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveSignupInfoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signupUsernameBox.Text) || string.IsNullOrWhiteSpace(signupPasswordBox.Text))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            string username = signupUsernameBox.Text.Trim();
            string password = signupPasswordBox.Text.Trim();

            bool isDuplicate = CheckForDuplicates(username);
            if (isDuplicate)
            {
                MessageBox.Show("Username or email already exists.");
                return;
            }

            try
            {
                usersDB.Add_user(username, password);

                MessageBox.Show("User information saved successfully.");
                signupUsernameBox.Clear();
                signupPasswordBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user information: {ex.Message}");
            }
        }

        private void userLoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            string enteredCredentials = $"{usernameBox.Text},{passwordBox.Text}";
            bool userFound = false;

            try
            {
                if (File.Exists(csvFilePath))
                {
                    var lines = File.ReadAllLines(csvFilePath);
                    userFound = lines.Any(line => line.Trim() == enteredCredentials);
                }

                if (userFound)
                {
                    MessageBox.Show("Login successful!");
                    usernameBox.Clear();
                    passwordBox.Clear();
                    loggedOn = true;
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading user information: {ex.Message}");
            }
        }

        private void loginTab_Click(object sender, EventArgs e)
        {

        }

        private bool CheckForDuplicates(string username)
        {
            if (!File.Exists(csvFilePath))
            {
                // No existing users, so no duplicates
                return false;
            }

            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                // Skip header line
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    if (fields.Length >= 2)
                    {
                        string existingUsername = fields[0].Trim();

                        // Case-insensitive comparison
                        if (existingUsername.Equals(username, StringComparison.OrdinalIgnoreCase))
                        {
                            return true; // Duplicate found
                        }
                    }
                }
            }

            return false; // No duplicates
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leaderboard leaderboardForm = new leaderboard();
            leaderboardForm.Show();
        }

        private void learn_ReturnButton_Click(object sender, EventArgs e)
        {
            learnPanel.Visible = false;
            startButtonsPanel.Visible = true;
        }

        private void startButtonsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}