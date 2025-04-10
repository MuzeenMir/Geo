﻿namespace Geo
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
            this.mainMenuTab.BackgroundImage = global::Geo.Properties.Resources.Screenshot_2025_04_08_130130;
            this.mainMenuTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuTab.Controls.Add(this.quickPlayPanel);
            this.mainMenuTab.Controls.Add(this.learnPanel);
            this.mainMenuTab.Controls.Add(this.gameNameLabel);
            this.mainMenuTab.Controls.Add(this.quitButton);
            this.mainMenuTab.Controls.Add(this.quickplayButton);
            this.mainMenuTab.Controls.Add(this.learnButton);
            this.mainMenuTab.Location = new System.Drawing.Point(4, 25);
            this.mainMenuTab.Name = "mainMenuTab";
            this.mainMenuTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.mainMenuTab.Size = new System.Drawing.Size(792, 419);
            this.mainMenuTab.TabIndex = 0;
            this.mainMenuTab.Text = "Main Menu";
            this.mainMenuTab.UseVisualStyleBackColor = true;
            // 
            // quickPlayPanel
            // 
            this.quickPlayPanel.Controls.Add(this.quickPlay_ReturnButton);
            this.quickPlayPanel.Controls.Add(this.quickPlay_PlayButton);
            this.quickPlayPanel.Controls.Add(this.quizModeRadioButton);
            this.quickPlayPanel.Controls.Add(this.mapModeRadioButton);
            this.quickPlayPanel.Location = new System.Drawing.Point(463, 71);
            this.quickPlayPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.quickPlayPanel.Name = "quickPlayPanel";
            this.quickPlayPanel.Size = new System.Drawing.Size(328, 227);
            this.quickPlayPanel.TabIndex = 5;
            this.quickPlayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.quickPlayPanel_Paint);
            // 
            // quickPlay_ReturnButton
            // 
            this.quickPlay_ReturnButton.Location = new System.Drawing.Point(255, 2);
            this.quickPlay_ReturnButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.quickPlay_PlayButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.quizModeRadioButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.mapModeRadioButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.learnPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.quitButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.quickplayButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.learnButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
            this.groupsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupsTab.Name = "groupsTab";
            this.groupsTab.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupsTab.Size = new System.Drawing.Size(792, 419);
            this.groupsTab.TabIndex = 1;
            this.groupsTab.Text = "Groups";
            this.groupsTab.UseVisualStyleBackColor = true;
            // 
            // leaderboardTab
            // 
            this.leaderboardTab.Location = new System.Drawing.Point(4, 25);
            this.leaderboardTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leaderboardTab.Name = "leaderboardTab";
            this.leaderboardTab.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.leaderboardTab.Size = new System.Drawing.Size(792, 419);
            this.leaderboardTab.TabIndex = 2;
            this.leaderboardTab.Text = "Leaderboard";
            this.leaderboardTab.UseVisualStyleBackColor = true;
            // 
            // settingsTab
            // 
            this.settingsTab.Location = new System.Drawing.Point(4, 25);
            this.settingsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.settingsTab.Size = new System.Drawing.Size(792, 419);
            this.settingsTab.TabIndex = 3;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // loginTab
            // 
            this.loginTab.Location = new System.Drawing.Point(4, 25);
            this.loginTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.loginTab.Size = new System.Drawing.Size(792, 419);
            this.loginTab.TabIndex = 4;
            this.loginTab.Text = "Login";
            this.loginTab.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
    }
}

