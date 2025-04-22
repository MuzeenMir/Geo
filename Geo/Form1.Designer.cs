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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainMenuTab = new System.Windows.Forms.TabPage();
            this.startButtonsPanel = new System.Windows.Forms.Panel();
            this.quickPlayPanel = new System.Windows.Forms.Panel();
            this.quickPlay_ReturnButton = new System.Windows.Forms.Button();
            this.quickPlay_PlayButton = new System.Windows.Forms.Button();
            this.quizModeRadioButton = new System.Windows.Forms.RadioButton();
            this.mapModeRadioButton = new System.Windows.Forms.RadioButton();
            this.learnPanel = new System.Windows.Forms.Panel();
            this.learn_ReturnButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupsTab = new System.Windows.Forms.TabPage();
            this.leaderboardTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.login_SignUpButton = new System.Windows.Forms.Button();
            this.logiin_LoginButton = new System.Windows.Forms.Button();
            this.signUpPlanel = new System.Windows.Forms.Panel();
            this.signupLabel = new System.Windows.Forms.Label();
            this.saveSignupInfoButton = new System.Windows.Forms.Button();
            this.signupReturnButton = new System.Windows.Forms.Button();
            this.signupPasswordPanel = new System.Windows.Forms.Panel();
            this.signupPasswordBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.signupUsernamePanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.signupUsernameBox = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.userLoginButton = new System.Windows.Forms.Button();
            this.login_returnButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.quickplayButton = new System.Windows.Forms.Button();
            this.learnButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.learnModeButton = new System.Windows.Forms.Button();
            this.quickPlayModeButton = new System.Windows.Forms.Button();
            this.quitGameButton = new System.Windows.Forms.Button();
            this.geoGameNameLabel = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.mainMenuTab.SuspendLayout();
            this.startButtonsPanel.SuspendLayout();
            this.quickPlayPanel.SuspendLayout();
            this.learnPanel.SuspendLayout();
            this.leaderboardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.loginTab.SuspendLayout();
            this.signUpPlanel.SuspendLayout();
            this.signupPasswordPanel.SuspendLayout();
            this.signupUsernamePanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.mainMenuTab.Controls.Add(this.startButtonsPanel);
            this.mainMenuTab.Controls.Add(this.quickPlayPanel);
            this.mainMenuTab.Controls.Add(this.learnPanel);
            this.mainMenuTab.Location = new System.Drawing.Point(4, 25);
            this.mainMenuTab.Name = "mainMenuTab";
            this.mainMenuTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainMenuTab.Size = new System.Drawing.Size(792, 419);
            this.mainMenuTab.TabIndex = 0;
            this.mainMenuTab.Text = "Main Menu";
            this.mainMenuTab.UseVisualStyleBackColor = true;
            // 
            // startButtonsPanel
            // 
            this.startButtonsPanel.Controls.Add(this.geoGameNameLabel);
            this.startButtonsPanel.Controls.Add(this.quitGameButton);
            this.startButtonsPanel.Controls.Add(this.quickPlayModeButton);
            this.startButtonsPanel.Controls.Add(this.learnModeButton);
            this.startButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButtonsPanel.Location = new System.Drawing.Point(3, 3);
            this.startButtonsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.startButtonsPanel.Name = "startButtonsPanel";
            this.startButtonsPanel.Size = new System.Drawing.Size(786, 413);
            this.startButtonsPanel.TabIndex = 0;
            // 
            // quickPlayPanel
            // 
            this.quickPlayPanel.BackColor = System.Drawing.Color.Transparent;
            this.quickPlayPanel.Controls.Add(this.quickPlay_ReturnButton);
            this.quickPlayPanel.Controls.Add(this.quickPlay_PlayButton);
            this.quickPlayPanel.Controls.Add(this.quizModeRadioButton);
            this.quickPlayPanel.Controls.Add(this.mapModeRadioButton);
            this.quickPlayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickPlayPanel.Location = new System.Drawing.Point(3, 3);
            this.quickPlayPanel.Margin = new System.Windows.Forms.Padding(1);
            this.quickPlayPanel.Name = "quickPlayPanel";
            this.quickPlayPanel.Size = new System.Drawing.Size(786, 413);
            this.quickPlayPanel.TabIndex = 5;
            this.quickPlayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.quickPlayPanel_Paint);
            // 
            // quickPlay_ReturnButton
            // 
            this.quickPlay_ReturnButton.Location = new System.Drawing.Point(712, 2);
            this.quickPlay_ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.quickPlay_ReturnButton.Name = "quickPlay_ReturnButton";
            this.quickPlay_ReturnButton.Size = new System.Drawing.Size(71, 23);
            this.quickPlay_ReturnButton.TabIndex = 3;
            this.quickPlay_ReturnButton.Text = "Return";
            this.quickPlay_ReturnButton.UseVisualStyleBackColor = true;
            this.quickPlay_ReturnButton.Click += new System.EventHandler(this.quickPlay_ReturnButton_Click);
            // 
            // quickPlay_PlayButton
            // 
            this.quickPlay_PlayButton.Location = new System.Drawing.Point(361, 282);
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
            this.quizModeRadioButton.Location = new System.Drawing.Point(574, 89);
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
            this.mapModeRadioButton.Location = new System.Drawing.Point(119, 89);
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
            this.learnPanel.Controls.Add(this.learn_ReturnButton);
            this.learnPanel.Controls.Add(this.label10);
            this.learnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learnPanel.Location = new System.Drawing.Point(3, 3);
            this.learnPanel.Margin = new System.Windows.Forms.Padding(1);
            this.learnPanel.Name = "learnPanel";
            this.learnPanel.Size = new System.Drawing.Size(786, 413);
            this.learnPanel.TabIndex = 4;
            this.learnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.learnPanel_Paint);
            // 
            // learn_ReturnButton
            // 
            this.learn_ReturnButton.Location = new System.Drawing.Point(708, 3);
            this.learn_ReturnButton.Name = "learn_ReturnButton";
            this.learn_ReturnButton.Size = new System.Drawing.Size(75, 23);
            this.learn_ReturnButton.TabIndex = 1;
            this.learn_ReturnButton.Text = "Return";
            this.learn_ReturnButton.UseVisualStyleBackColor = true;
            this.learn_ReturnButton.Click += new System.EventHandler(this.learn_ReturnButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "learn panel";
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
            this.leaderboardTab.Controls.Add(this.dataGridView1);
            this.leaderboardTab.Controls.Add(this.button1);
            this.leaderboardTab.Location = new System.Drawing.Point(4, 25);
            this.leaderboardTab.Margin = new System.Windows.Forms.Padding(2);
            this.leaderboardTab.Name = "leaderboardTab";
            this.leaderboardTab.Padding = new System.Windows.Forms.Padding(1);
            this.leaderboardTab.Size = new System.Drawing.Size(792, 419);
            this.leaderboardTab.TabIndex = 2;
            this.leaderboardTab.Text = "Leaderboard";
            this.leaderboardTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.Score});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(790, 417);
            this.dataGridView1.TabIndex = 1;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 10;
            this.NameColumn.Name = "NameColumn";
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 10;
            this.Score.Name = "Score";
            this.Score.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.loginTab.BackgroundImage = global::Geo.Properties.Resources.wrld_21;
            this.loginTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // signUpPlanel
            // 
            this.signUpPlanel.Controls.Add(this.signupLabel);
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
            // signupLabel
            // 
            this.signupLabel.AutoSize = true;
            this.signupLabel.Location = new System.Drawing.Point(346, 28);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(62, 16);
            this.signupLabel.TabIndex = 12;
            this.signupLabel.Text = "Sign Up";
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
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.loginLabel);
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
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(346, 28);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(86, 16);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "LogIn Page";
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
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(0, 0);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 0;
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.Location = new System.Drawing.Point(0, 0);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(100, 23);
            this.gameNameLabel.TabIndex = 0;
            // 
            // quickplayButton
            // 
            this.quickplayButton.Location = new System.Drawing.Point(0, 0);
            this.quickplayButton.Name = "quickplayButton";
            this.quickplayButton.Size = new System.Drawing.Size(75, 23);
            this.quickplayButton.TabIndex = 0;
            // 
            // learnButton
            // 
            this.learnButton.Location = new System.Drawing.Point(0, 0);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(75, 23);
            this.learnButton.TabIndex = 0;
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
            // learnModeButton
            // 
            this.learnModeButton.AutoSize = true;
            this.learnModeButton.Location = new System.Drawing.Point(385, 145);
            this.learnModeButton.Name = "learnModeButton";
            this.learnModeButton.Size = new System.Drawing.Size(99, 26);
            this.learnModeButton.TabIndex = 0;
            this.learnModeButton.Text = "Learn Mode";
            this.learnModeButton.UseVisualStyleBackColor = true;
            this.learnModeButton.Click += new System.EventHandler(this.learnModeButton_Click);
            // 
            // quickPlayModeButton
            // 
            this.quickPlayModeButton.AutoSize = true;
            this.quickPlayModeButton.Location = new System.Drawing.Point(387, 228);
            this.quickPlayModeButton.Name = "quickPlayModeButton";
            this.quickPlayModeButton.Size = new System.Drawing.Size(91, 26);
            this.quickPlayModeButton.TabIndex = 1;
            this.quickPlayModeButton.Text = "Quick Play";
            this.quickPlayModeButton.UseVisualStyleBackColor = true;
            this.quickPlayModeButton.Click += new System.EventHandler(this.quickPlayModeButton_Click);
            // 
            // quitGameButton
            // 
            this.quitGameButton.AutoSize = true;
            this.quitGameButton.Location = new System.Drawing.Point(397, 326);
            this.quitGameButton.Name = "quitGameButton";
            this.quitGameButton.Size = new System.Drawing.Size(75, 26);
            this.quitGameButton.TabIndex = 2;
            this.quitGameButton.Text = "Quit";
            this.quitGameButton.UseVisualStyleBackColor = true;
            this.quitGameButton.Click += new System.EventHandler(this.quitGameButton_Click);
            // 
            // geoGameNameLabel
            // 
            this.geoGameNameLabel.AutoSize = true;
            this.geoGameNameLabel.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geoGameNameLabel.Location = new System.Drawing.Point(246, 67);
            this.geoGameNameLabel.Name = "geoGameNameLabel";
            this.geoGameNameLabel.Size = new System.Drawing.Size(363, 57);
            this.geoGameNameLabel.TabIndex = 3;
            this.geoGameNameLabel.Text = "Geography game";
            this.geoGameNameLabel.Click += new System.EventHandler(this.geoGameNameLabel_Click);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Text = "Geography Game";
            this.mainTabControl.ResumeLayout(false);
            this.mainMenuTab.ResumeLayout(false);
            this.startButtonsPanel.ResumeLayout(false);
            this.startButtonsPanel.PerformLayout();
            this.quickPlayPanel.ResumeLayout(false);
            this.quickPlayPanel.PerformLayout();
            this.learnPanel.ResumeLayout(false);
            this.learnPanel.PerformLayout();
            this.leaderboardTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.loginTab.ResumeLayout(false);
            this.signUpPlanel.ResumeLayout(false);
            this.signUpPlanel.PerformLayout();
            this.signupPasswordPanel.ResumeLayout(false);
            this.signupPasswordPanel.PerformLayout();
            this.signupUsernamePanel.ResumeLayout(false);
            this.signupUsernamePanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button learn_ReturnButton;
        private System.Windows.Forms.Panel startButtonsPanel;
        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Label geoGameNameLabel;
        private System.Windows.Forms.Button quitGameButton;
        private System.Windows.Forms.Button quickPlayModeButton;
        private System.Windows.Forms.Button learnModeButton;
    }
}

