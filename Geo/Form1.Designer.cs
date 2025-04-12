namespace Geo
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainMenuTab = new System.Windows.Forms.TabPage();
            this.quickPlayPanel = new System.Windows.Forms.Panel();
            this.quickPlay_ReturnButton = new System.Windows.Forms.Button();
            this.quickPlay_PlayButton = new System.Windows.Forms.Button();
            this.quizModeRadioButton = new System.Windows.Forms.RadioButton();
            this.mapModeRadioButton = new System.Windows.Forms.RadioButton();
            this.learnPanel = new System.Windows.Forms.Panel();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.quickplayButton = new System.Windows.Forms.Button();
            this.learnButton = new System.Windows.Forms.Button();
            this.groupsTab = new System.Windows.Forms.TabPage();
            this.leaderboardTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.login_SignUpButton = new System.Windows.Forms.Button();
            this.logiin_LoginButton = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.userLoginButton = new System.Windows.Forms.Button();
            this.login_returnButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.signUpPlanel = new System.Windows.Forms.Panel();
            this.saveSignupInfoButton = new System.Windows.Forms.Button();
            this.signupReturnButton = new System.Windows.Forms.Button();
            this.signupPasswordPanel = new System.Windows.Forms.Panel();
            this.signupPasswordBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.signupUsernamePanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.signupUsernameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.mainMenuTab.SuspendLayout();
            this.quickPlayPanel.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.signUpPlanel.SuspendLayout();
            this.signupPasswordPanel.SuspendLayout();
            this.signupUsernamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.mainMenuTab);
            this.mainTabControl.Controls.Add(this.groupsTab);
            this.mainTabControl.Controls.Add(this.leaderboardTab);
            this.mainTabControl.Controls.Add(this.settingsTab);
            this.mainTabControl.Controls.Add(this.loginTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 1);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(800, 448);
            this.mainTabControl.TabIndex = 0;
            // 
            // mainMenuTab
            // 
            this.mainMenuTab.BackgroundImage = global::Geo.Properties.Resources.wrld_21;
            this.mainMenuTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuTab.Controls.Add(this.quickPlayPanel);
            this.mainMenuTab.Controls.Add(this.learnPanel);
            this.mainMenuTab.Controls.Add(this.gameNameLabel);
            this.mainMenuTab.Controls.Add(this.quitButton);
            this.mainMenuTab.Controls.Add(this.quickplayButton);
            this.mainMenuTab.Controls.Add(this.learnButton);
            this.mainMenuTab.Location = new System.Drawing.Point(4, 25);
            this.mainMenuTab.Name = "mainMenuTab";
            this.mainMenuTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainMenuTab.Size = new System.Drawing.Size(792, 419);
            this.mainMenuTab.TabIndex = 0;
            this.mainMenuTab.Text = "Main Menu";
            this.mainMenuTab.UseVisualStyleBackColor = true;
            // 
            // quickPlayPanel
            // 
            this.quickPlayPanel.BackColor = System.Drawing.Color.Transparent;
            this.quickPlayPanel.Controls.Add(this.quickPlay_ReturnButton);
            this.quickPlayPanel.Controls.Add(this.quickPlay_PlayButton);
            this.quickPlayPanel.Controls.Add(this.quizModeRadioButton);
            this.quickPlayPanel.Controls.Add(this.mapModeRadioButton);
            this.quickPlayPanel.Location = new System.Drawing.Point(463, 71);
            this.quickPlayPanel.Margin = new System.Windows.Forms.Padding(1);
            this.quickPlayPanel.Name = "quickPlayPanel";
            this.quickPlayPanel.Size = new System.Drawing.Size(328, 227);
            this.quickPlayPanel.TabIndex = 5;
            this.quickPlayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.quickPlayPanel_Paint);
            // 
            // quickPlay_ReturnButton
            // 
            this.quickPlay_ReturnButton.Location = new System.Drawing.Point(255, 2);
            this.quickPlay_ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.quickPlay_ReturnButton.Name = "quickPlay_ReturnButton";
            this.quickPlay_ReturnButton.Size = new System.Drawing.Size(71, 46);
            this.quickPlay_ReturnButton.TabIndex = 3;
            this.quickPlay_ReturnButton.Text = "Return";
            this.quickPlay_ReturnButton.UseVisualStyleBackColor = true;
            this.quickPlay_ReturnButton.Click += new System.EventHandler(this.quickPlay_ReturnButton_Click);
            // 
            // quickPlay_PlayButton
            // 
            this.quickPlay_PlayButton.Location = new System.Drawing.Point(144, 183);
            this.quickPlay_PlayButton.Margin = new System.Windows.Forms.Padding(1);
            this.quickPlay_PlayButton.Name = "quickPlay_PlayButton";
            this.quickPlay_PlayButton.Size = new System.Drawing.Size(60, 26);
            this.quickPlay_PlayButton.TabIndex = 2;
            this.quickPlay_PlayButton.Text = "Play";
            this.quickPlay_PlayButton.UseVisualStyleBackColor = true;
            this.quickPlay_PlayButton.Click += new System.EventHandler(this.quickPlay_PlayButton_Click);
            // 
            // quizModeRadioButton
            // 
            this.quizModeRadioButton.AutoSize = true;
            this.quizModeRadioButton.Location = new System.Drawing.Point(211, 108);
            this.quizModeRadioButton.Margin = new System.Windows.Forms.Padding(1);
            this.quizModeRadioButton.Name = "quizModeRadioButton";
            this.quizModeRadioButton.Size = new System.Drawing.Size(98, 20);
            this.quizModeRadioButton.TabIndex = 1;
            this.quizModeRadioButton.TabStop = true;
            this.quizModeRadioButton.Text = "Quiz Mode";
            this.quizModeRadioButton.UseVisualStyleBackColor = true;
            this.quizModeRadioButton.CheckedChanged += new System.EventHandler(this.quizModeRadioButton_CheckedChanged);
            // 
            // mapModeRadioButton
            // 
            this.mapModeRadioButton.AutoSize = true;
            this.mapModeRadioButton.Location = new System.Drawing.Point(20, 108);
            this.mapModeRadioButton.Margin = new System.Windows.Forms.Padding(1);
            this.mapModeRadioButton.Name = "mapModeRadioButton";
            this.mapModeRadioButton.Size = new System.Drawing.Size(98, 20);
            this.mapModeRadioButton.TabIndex = 0;
            this.mapModeRadioButton.TabStop = true;
            this.mapModeRadioButton.Text = "Map Mode";
            this.mapModeRadioButton.UseVisualStyleBackColor = true;
            this.mapModeRadioButton.CheckedChanged += new System.EventHandler(this.mapModeRadioButton_CheckedChanged);
            // 
            // learnPanel
            // 
            this.learnPanel.Location = new System.Drawing.Point(4, 73);
            this.learnPanel.Margin = new System.Windows.Forms.Padding(1);
            this.learnPanel.Name = "learnPanel";
            this.learnPanel.Size = new System.Drawing.Size(308, 225);
            this.learnPanel.TabIndex = 4;
            this.learnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.learnPanel_Paint);
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Font = new System.Drawing.Font("Perpetua", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.Location = new System.Drawing.Point(221, 28);
            this.gameNameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(269, 42);
            this.gameNameLabel.TabIndex = 3;
            this.gameNameLabel.Text = "Geography Game";
            this.gameNameLabel.Click += new System.EventHandler(this.gameNameLabel_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(355, 236);
            this.quitButton.Margin = new System.Windows.Forms.Padding(1);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(69, 24);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // quickplayButton
            // 
            this.quickplayButton.Location = new System.Drawing.Point(355, 156);
            this.quickplayButton.Margin = new System.Windows.Forms.Padding(1);
            this.quickplayButton.Name = "quickplayButton";
            this.quickplayButton.Size = new System.Drawing.Size(69, 43);
            this.quickplayButton.TabIndex = 1;
            this.quickplayButton.Text = "Quick Play";
            this.quickplayButton.UseVisualStyleBackColor = true;
            this.quickplayButton.Click += new System.EventHandler(this.quickplayButton_Click);
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(355, 92);
            this.learnButton.Margin = new System.Windows.Forms.Padding(1);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(69, 27);
            this.learnButton.TabIndex = 0;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = true;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // groupsTab
            // 
            this.groupsTab.Location = new System.Drawing.Point(4, 25);
            this.groupsTab.Margin = new System.Windows.Forms.Padding(2);
            this.groupsTab.Name = "groupsTab";
            this.groupsTab.Padding = new System.Windows.Forms.Padding(1);
            this.groupsTab.Size = new System.Drawing.Size(792, 419);
            this.groupsTab.TabIndex = 1;
            this.groupsTab.Text = "Groups";
            this.groupsTab.UseVisualStyleBackColor = true;
            // 
            // leaderboardTab
            // 
            this.leaderboardTab.Location = new System.Drawing.Point(4, 25);
            this.leaderboardTab.Margin = new System.Windows.Forms.Padding(2);
            this.leaderboardTab.Name = "leaderboardTab";
            this.leaderboardTab.Padding = new System.Windows.Forms.Padding(1);
            this.leaderboardTab.Size = new System.Drawing.Size(792, 419);
            this.leaderboardTab.TabIndex = 2;
            this.leaderboardTab.Text = "Leaderboard";
            this.leaderboardTab.UseVisualStyleBackColor = true;
            // 
            // settingsTab
            // 
            this.settingsTab.Location = new System.Drawing.Point(4, 25);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(2);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(1);
            this.settingsTab.Size = new System.Drawing.Size(792, 419);
            this.settingsTab.TabIndex = 3;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.login_SignUpButton);
            this.loginTab.Controls.Add(this.logiin_LoginButton);
            this.loginTab.Controls.Add(this.signUpPlanel);
            this.loginTab.Controls.Add(this.loginPanel);
            this.loginTab.Location = new System.Drawing.Point(4, 25);
            this.loginTab.Margin = new System.Windows.Forms.Padding(2);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(1);
            this.loginTab.Size = new System.Drawing.Size(792, 419);
            this.loginTab.TabIndex = 4;
            this.loginTab.Text = "Login";
            this.loginTab.UseVisualStyleBackColor = true;
            this.loginTab.Click += new System.EventHandler(this.loginTab_Click);
            // 
            // login_SignUpButton
            // 
            this.login_SignUpButton.Location = new System.Drawing.Point(347, 208);
            this.login_SignUpButton.Name = "login_SignUpButton";
            this.login_SignUpButton.Size = new System.Drawing.Size(75, 23);
            this.login_SignUpButton.TabIndex = 1;
            this.login_SignUpButton.Text = "Sign Up";
            this.login_SignUpButton.UseVisualStyleBackColor = true;
            this.login_SignUpButton.Click += new System.EventHandler(this.login_SignUpButton_Click);
            // 
            // logiin_LoginButton
            // 
            this.logiin_LoginButton.Location = new System.Drawing.Point(347, 114);
            this.logiin_LoginButton.Name = "logiin_LoginButton";
            this.logiin_LoginButton.Size = new System.Drawing.Size(75, 23);
            this.logiin_LoginButton.TabIndex = 0;
            this.logiin_LoginButton.Text = "LogIn";
            this.logiin_LoginButton.UseVisualStyleBackColor = true;
            this.logiin_LoginButton.Click += new System.EventHandler(this.logiin_LoginButton_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.userLoginButton);
            this.loginPanel.Controls.Add(this.login_returnButton);
            this.loginPanel.Controls.Add(this.panel2);
            this.loginPanel.Controls.Add(this.panel1);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(1, 1);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(790, 417);
            this.loginPanel.TabIndex = 2;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // userLoginButton
            // 
            this.userLoginButton.Location = new System.Drawing.Point(389, 345);
            this.userLoginButton.Name = "userLoginButton";
            this.userLoginButton.Size = new System.Drawing.Size(75, 23);
            this.userLoginButton.TabIndex = 7;
            this.userLoginButton.Text = "LogIn";
            this.userLoginButton.UseVisualStyleBackColor = true;
            this.userLoginButton.Click += new System.EventHandler(this.userLoginButton_Click);
            // 
            // login_returnButton
            // 
            this.login_returnButton.Location = new System.Drawing.Point(712, 3);
            this.login_returnButton.Name = "login_returnButton";
            this.login_returnButton.Size = new System.Drawing.Size(75, 23);
            this.login_returnButton.TabIndex = 6;
            this.login_returnButton.Text = "Return";
            this.login_returnButton.UseVisualStyleBackColor = true;
            this.login_returnButton.Click += new System.EventHandler(this.login_returnButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.passwordBox);
            this.panel2.Controls.Add(this.passwordLabel);
            this.panel2.Location = new System.Drawing.Point(150, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 78);
            this.panel2.TabIndex = 5;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(126, 24);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(329, 31);
            this.passwordBox.TabIndex = 8;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(41, 34);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.usernameBox);
            this.panel1.Location = new System.Drawing.Point(150, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 78);
            this.panel1.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(38, 33);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(82, 16);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(126, 23);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(329, 31);
            this.usernameBox.TabIndex = 7;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // signUpPlanel
            // 
            this.signUpPlanel.Controls.Add(this.saveSignupInfoButton);
            this.signUpPlanel.Controls.Add(this.signupReturnButton);
            this.signUpPlanel.Controls.Add(this.signupPasswordPanel);
            this.signUpPlanel.Controls.Add(this.signupUsernamePanel);
            this.signUpPlanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signUpPlanel.Location = new System.Drawing.Point(1, 1);
            this.signUpPlanel.Name = "signUpPlanel";
            this.signUpPlanel.Size = new System.Drawing.Size(790, 417);
            this.signUpPlanel.TabIndex = 3;
            this.signUpPlanel.Paint += new System.Windows.Forms.PaintEventHandler(this.signUpPlanel_Paint);
            // 
            // saveSignupInfoButton
            // 
            this.saveSignupInfoButton.Location = new System.Drawing.Point(389, 335);
            this.saveSignupInfoButton.Name = "saveSignupInfoButton";
            this.saveSignupInfoButton.Size = new System.Drawing.Size(75, 23);
            this.saveSignupInfoButton.TabIndex = 11;
            this.saveSignupInfoButton.Text = "Save";
            this.saveSignupInfoButton.UseVisualStyleBackColor = true;
            this.saveSignupInfoButton.Click += new System.EventHandler(this.saveSignupInfoButton_Click);
            // 
            // signupReturnButton
            // 
            this.signupReturnButton.Location = new System.Drawing.Point(712, 3);
            this.signupReturnButton.Name = "signupReturnButton";
            this.signupReturnButton.Size = new System.Drawing.Size(75, 23);
            this.signupReturnButton.TabIndex = 10;
            this.signupReturnButton.Text = "Return";
            this.signupReturnButton.UseVisualStyleBackColor = true;
            this.signupReturnButton.Click += new System.EventHandler(this.signupReturnButton_Click);
            // 
            // signupPasswordPanel
            // 
            this.signupPasswordPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signupPasswordPanel.Controls.Add(this.signupPasswordBox);
            this.signupPasswordPanel.Controls.Add(this.label8);
            this.signupPasswordPanel.Location = new System.Drawing.Point(150, 207);
            this.signupPasswordPanel.Name = "signupPasswordPanel";
            this.signupPasswordPanel.Size = new System.Drawing.Size(526, 78);
            this.signupPasswordPanel.TabIndex = 9;
            // 
            // signupPasswordBox
            // 
            this.signupPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPasswordBox.Location = new System.Drawing.Point(126, 24);
            this.signupPasswordBox.Name = "signupPasswordBox";
            this.signupPasswordBox.Size = new System.Drawing.Size(329, 31);
            this.signupPasswordBox.TabIndex = 8;
            this.signupPasswordBox.UseSystemPasswordChar = true;
            this.signupPasswordBox.TextChanged += new System.EventHandler(this.signupPasswordBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Password:";
            // 
            // signupUsernamePanel
            // 
            this.signupUsernamePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signupUsernamePanel.Controls.Add(this.label9);
            this.signupUsernamePanel.Controls.Add(this.signupUsernameBox);
            this.signupUsernamePanel.Location = new System.Drawing.Point(153, 70);
            this.signupUsernamePanel.Name = "signupUsernamePanel";
            this.signupUsernamePanel.Size = new System.Drawing.Size(526, 78);
            this.signupUsernamePanel.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Username:";
            // 
            // signupUsernameBox
            // 
            this.signupUsernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupUsernameBox.Location = new System.Drawing.Point(126, 23);
            this.signupUsernameBox.Name = "signupUsernameBox";
            this.signupUsernameBox.Size = new System.Drawing.Size(329, 31);
            this.signupUsernameBox.TabIndex = 7;
            this.signupUsernameBox.TextChanged += new System.EventHandler(this.signupUsernameBox_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainTabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "mainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Text = "Geography Game";
            this.mainTabControl.ResumeLayout(false);
            this.mainMenuTab.ResumeLayout(false);
            this.mainMenuTab.PerformLayout();
            this.quickPlayPanel.ResumeLayout(false);
            this.quickPlayPanel.PerformLayout();
            this.loginTab.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.signUpPlanel.ResumeLayout(false);
            this.signupPasswordPanel.ResumeLayout(false);
            this.signupPasswordPanel.PerformLayout();
            this.signupUsernamePanel.ResumeLayout(false);
            this.signupUsernamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mainMenuTab;
        private System.Windows.Forms.TabPage groupsTab;
        private System.Windows.Forms.TabPage leaderboardTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button quickplayButton;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.Panel learnPanel;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Panel quickPlayPanel;
        private System.Windows.Forms.Button quickPlay_PlayButton;
        private System.Windows.Forms.RadioButton quizModeRadioButton;
        private System.Windows.Forms.RadioButton mapModeRadioButton;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.Button quickPlay_ReturnButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button login_SignUpButton;
        private System.Windows.Forms.Button logiin_LoginButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button login_returnButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Panel signUpPlanel;
        private System.Windows.Forms.Button saveSignupInfoButton;
        private System.Windows.Forms.Button signupReturnButton;
        private System.Windows.Forms.Panel signupPasswordPanel;
        private System.Windows.Forms.TextBox signupPasswordBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel signupUsernamePanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox signupUsernameBox;
        private System.Windows.Forms.Button userLoginButton;
    }
}

