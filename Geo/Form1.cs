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
            EnableDoubleBufferingForAll(this);
        }

        // Enable double buffering for all controls in the form to prevent flickering 
        private void EnableDoubleBufferingForAll(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                // Enable double buffering using reflection for each control
                typeof(Control).InvokeMember("DoubleBuffered",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.SetProperty,
                    null, childControl, new object[] { true });

                // Recursively apply to child controls
                EnableDoubleBufferingForAll(childControl);
            }
        }

        private void InitializeUI()
        {
            quickPlayPanel.Visible = false;
            loginPanel.Visible = false;
            signUpPlanel.Visible = false;
            learnPanel.Visible = false;
            userLoginButton.Visible = false;
            saveSignupInfoButton.Visible = false;

            // Center startButtonsPanel on page load
            CenterPanel(startButtonsPanel);

            // Adds form resize handler only once
            this.Resize += Form_Resize;

            // Load leaderboard data into dataGridView1
            LoadLeaderboardData();

            Form_Resize(this, EventArgs.Empty);
        }

        // This loads leaderboard data and display sit in the Leaderboard
        private void LoadLeaderboardData()
        {
            try
            {
                // Clear any existing columns and rows
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                // Configure DataGridView columns
                dataGridView1.Columns.Add("Rank", "Rank");
                dataGridView1.Columns.Add("Username", "Username");
                dataGridView1.Columns.Add("Points", "Points");
                dataGridView1.Columns.Add("Level", "Level");
               



                // Get leaderboard data from database
                string[,] leaderboardData = userInfo.Get_Leaderboard();
                if (leaderboardData == null)
                {
                    MessageBox.Show("No leaderboard data available.");
                    return;
                }

                Console.Write(leaderboardData);

                // Add data to DataGridView
                for (int i = 0; i < 10; i++)
                {
                    // Check if we have data for this row
                    if (leaderboardData[i, 0] != null)
                    {
                        // Create row with rank (i+1), username, points, and level
                        dataGridView1.Rows.Add(
                            (i + 1).ToString(),
                            leaderboardData[i, 0], // Username
                            leaderboardData[i, 1], // Points
                            leaderboardData[i, 2]  // Rank
                        );
                    }
                }

                // Adjust column widths for better display
                dataGridView1.AutoResizeColumns();
                dataGridView1.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                // Log the error but don't show a message box during initialization
                Console.WriteLine($"Error loading leaderboard: {ex.Message}");
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            // Iterate through all controls in the form
            foreach (Control control in this.Controls)
            {
                // Check if the control is a Panel and is visible
                if (control is Panel panel && panel.Visible)
                {
                    CenterPanel(panel);
                }
            }

            // Keep the return buttons at the top-right corner
            const int padding = 10;
            const int verticalSpacing = 15; // Space between stacked elements

            if (quickPlayPanel.Visible && quickPlay_ReturnButton != null)
            {
                // Return button always at top-right
                quickPlay_ReturnButton.Left = quickPlayPanel.Width - quickPlay_ReturnButton.Width - padding;
                quickPlay_ReturnButton.Top = padding;

                // Calculate vertical center point for the stacked menu
                int centerY = quickPlayPanel.Height / 2;
                int totalStackHeight = 0;

                // Calculate total height of stacked elements
                if (mapModeRadioButton != null) totalStackHeight += mapModeRadioButton.Height;
                if (quizModeRadioButton != null) totalStackHeight += quizModeRadioButton.Height + verticalSpacing;
                if (quickPlay_PlayButton != null) totalStackHeight += quickPlay_PlayButton.Height + verticalSpacing;

                // Start Y position for the first element in stack
                int currentY = centerY - (totalStackHeight / 2);

                // Position radio buttons in a stacked menu
                if (mapModeRadioButton != null)
                {
                    mapModeRadioButton.Left = (quickPlayPanel.Width - mapModeRadioButton.Width) / 2;
                    mapModeRadioButton.Top = currentY;
                    currentY += mapModeRadioButton.Height + verticalSpacing;
                }

                if (quizModeRadioButton != null)
                {
                    quizModeRadioButton.Left = (quickPlayPanel.Width - quizModeRadioButton.Width) / 2;
                    quizModeRadioButton.Top = currentY;
                    currentY += quizModeRadioButton.Height + verticalSpacing;
                }

                // Position the Play button at the bottom of the stack
                if (quickPlay_PlayButton != null)
                {
                    quickPlay_PlayButton.Left = (quickPlayPanel.Width - quickPlay_PlayButton.Width) / 2;
                    quickPlay_PlayButton.Top = currentY;
                }
            }

            if (loginPanel.Visible && login_returnButton != null)
            {
                login_returnButton.Left = loginPanel.Width - login_returnButton.Width - padding;
                login_returnButton.Top = padding;
            }

            if (signUpPlanel.Visible && signupReturnButton != null)
            {
                signupReturnButton.Left = signUpPlanel.Width - signupReturnButton.Width - padding;
                signupReturnButton.Top = padding;
            }
        }



        private void CenterPanel(Panel panel)
        {
            // Calculate the center position
            panel.Left = (this.ClientSize.Width - panel.Width) / 2;
            panel.Top = (this.ClientSize.Height - panel.Height) / 2;

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
            geoGameNameLabel.ForeColor = Color.FromArgb(random.Next(192), random.Next(192), random.Next(192));
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            // unused and not needed
        }

        private void quickplayButton_Click(object sender, EventArgs e)
        {
            // unused and not needed
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            // unused and not needed
        }

        private void gameNameLabel_Click(object sender, EventArgs e)
        {
            // unused and not needed
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

        private void quizModeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void quickPlay_PlayButton_Click(object sender, EventArgs e)
        {
            quickQuizMode quizModeForm = new quickQuizMode();
            if (quizModeRadioButton.Checked)
            {
                quizModeForm.Show();
            }
            else if (mapModeRadioButton.Checked)
            {
                // Add logic for map mode if needed
            }
            else
            {
                MessageBox.Show("Please select a game mode.");
                return;
            }
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

                const int padding = 10; // You can change this value
                login_returnButton.Left = loginPanel.Width - login_returnButton.Width - padding;
                login_returnButton.Top = padding;
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

                const int padding = 10; // You can change this value
                signupReturnButton.Left = signUpPlanel.Width - signupReturnButton.Width - padding;
                signupReturnButton.Top = padding;
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

            string username = signupUsernameBox.Text.Trim().ToLower();
            string password = signupPasswordBox.Text.Trim().ToLower();

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
                userFound = userInfo.Check_Password(usernameBox.Text.Trim().ToLower(), passwordBox.Text);

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

        private void geoGameNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void learnModeButton_Click(object sender, EventArgs e)
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

        private void quickPlayModeButton_Click(object sender, EventArgs e)
        {
            try
            {
                quickPlayPanel.Visible = true;
                startButtonsPanel.Visible = false;

                // Call Form_Resize to position all controls properly
                Form_Resize(this, EventArgs.Empty);
            }
            finally
            {
                this.ResumeLayout(true);
            }
        }

        private void quitGameButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void welcomeMessageLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}