using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Geo
{


    public partial class mainForm : Form
    {
        private readonly string csvFilePath = "..\\..\\Resources\\userCreds.csv";
        private bool loggedOn = false;
        private Timer colorChangeTimer;
        private Random random;

        DB userInfo = new DB();

        public mainForm()

        {
            InitializeComponent();
            InitializeUI();
            InitializeColorChangeTimer();
            mainTabControl.SelectedTab = mainMenuTab;
            this.DoubleBuffered = true; 
        }

        private void InitializeUI()
        {
            quickPlayPanel.Visible = false;
            loginPanel.Visible = false;
            signUpPlanel.Visible = false;
            learnPanel.Visible = false;
            userLoginButton.Visible = false;
            saveSignupInfoButton.Visible = false;

            // Center startButtonsPanel immediately
            CenterPanel(startButtonsPanel);

            // Add form resize handler only once
            this.Resize += Form_Resize;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            // Re-center the panel when the form is resized
            if (startButtonsPanel.Visible)
            {
                startButtonsPanel.Left = (this.ClientSize.Width - startButtonsPanel.Width) / 2;
                startButtonsPanel.Top = (this.ClientSize.Height - startButtonsPanel.Height) / 2;
            }
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
            try
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
            finally
            {
                this.ResumeLayout(true);
            }
        }

        private void quickplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                quickPlayPanel.Visible = true;
                startButtonsPanel.Visible = false;
            }
            finally
            {
                this.ResumeLayout(true);
            }
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
            learnPanel.BackColor = Color.FromArgb(128, 128, 128, 128);
        }

        private void mapModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void quizMode_Load(object sender, EventArgs e)
        {
            // This method centers the startButtonsPanel horizontally and vertically
            CenterPanel(startButtonsPanel);
        }

        private void CenterPanel(Panel panel)
        {
            // Calculate the center position
            panel.Left = (this.ClientSize.Width - panel.Width) / 2;
            panel.Top = (this.ClientSize.Height - panel.Height) / 2;

            // Handle form resize to keep the panel centered
            this.Resize += (sender, e) =>
            {
                panel.Left = (this.ClientSize.Width - panel.Width) / 2;
                panel.Top = (this.ClientSize.Height - panel.Height) / 2;
            };
        }


        private void quizModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void quickPlay_PlayButton_Click(object sender, EventArgs e)
        {
            quizMode quizModeForm = new quizMode();
            quizModeForm.Show();
        }

        private void quickPlay_ReturnButton_Click(object sender, EventArgs e)
        {
            try
            {
                quickPlayPanel.Visible = false;
                startButtonsPanel.Visible = true;
            }
            finally
            {
                this.ResumeLayout(true);
            }
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logiin_LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                loginPanel.Visible = true;
                logiin_LoginButton.Visible = false;
                login_SignUpButton.Visible = false;
                userLoginButton.Visible = true;
            }
            finally
            {
                this.ResumeLayout(true);
            }
        }

        private void login_SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                logiin_LoginButton.Visible = false;
                login_SignUpButton.Visible = false;
                signUpPlanel.Visible = true;
                saveSignupInfoButton.Visible = true;
            }
            finally
            {
                this.ResumeLayout(true);
            }
        }

        private void signUpPlanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_returnButton_Click(object sender, EventArgs e)
        {
            try
            {
                loginPanel.Visible = false;
                logiin_LoginButton.Visible = true;
                login_SignUpButton.Visible = true;
                userLoginButton.Visible = false;
            }
            finally
            {
                this.ResumeLayout(true);
            }
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupReturnButton_Click(object sender, EventArgs e)
        {
            try
            {
                signUpPlanel.Visible = false;
                loginPanel.Visible = true;
                logiin_LoginButton.Visible = false;
                login_SignUpButton.Visible = false;
                userLoginButton.Visible = true;
            }
            finally
            {
                this.ResumeLayout(true);
            }
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
                MessageBox.Show("Username already exists.");
                return;
            }


            string csvLine = $"{signupUsernameBox.Text},{signupPasswordBox.Text}";

            try
            {
                userInfo.Add_user(username, password);

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
                //MessageBox.Show(userInfo.get_Urank(usernameBox.Text));
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
                    mainTabControl.SelectedTab = mainMenuTab;
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