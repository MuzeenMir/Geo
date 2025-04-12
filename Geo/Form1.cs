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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Geo
{


    public partial class mainForm : Form
    {
        private Timer colorChangeTimer;
        private Random random;
        public mainForm()
        {
            InitializeComponent();
            InitializeUI();
            InitializeColorChangeTimer();
        }

        private void InitializeUI()
        {
            quickPlayPanel.Visible = false;
            loginPanel.Visible = false;
            signUpPlanel.Visible = false;
            loginPanel.Visible = false;
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
            mainTabControl.SelectedTab = loginTab;
        }

        private void quickplayButton_Click(object sender, EventArgs e)
        {
            quickPlayPanel.Visible = true;
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
            quickPlayPanel.BackColor = Color.FromArgb(128, 128 , 128 , 128);
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
            string filePath = "C:\\Users\\MirMu\\source\\repos\\Geo\\Geo\\Resources\\userCreds.csv";
            if (string.IsNullOrWhiteSpace(signupUsernameBox.Text) || string.IsNullOrWhiteSpace(signupPasswordBox.Text))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }
            string csvLine = $"{signupUsernameBox.Text},{signupPasswordBox.Text}";

            try
            {
                File.AppendAllText(filePath, csvLine + Environment.NewLine);
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
            string filePath = "C:\\Users\\MirMu\\source\\repos\\Geo\\Geo\\Resources\\userCreds.csv";
            if (string.IsNullOrWhiteSpace(usernameBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            string enteredCredentials = $"{usernameBox.Text},{passwordBox.Text}";
            bool userFound = false;

            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);
                    userFound = lines.Any(line => line.Trim() == enteredCredentials);
                }

                if (userFound)
                {
                    MessageBox.Show("Login successful!");
                    usernameBox.Clear();
                    passwordBox.Clear();
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
    }
}