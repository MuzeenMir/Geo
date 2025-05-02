using System;

namespace Geo
{
    partial class mapModeUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.select_difficulty_lbl = new System.Windows.Forms.Label();
            this.mapMode10CheckBox = new System.Windows.Forms.CheckBox();
            this.mapMode20CheckBox = new System.Windows.Forms.CheckBox();
            this.mapMode30CheckBox = new System.Windows.Forms.CheckBox();
            this.mapModeMaxCheckBox = new System.Windows.Forms.CheckBox();
            this.mapModeStartButton = new System.Windows.Forms.Button();
            this.quickPlayMapModeScoreLabel = new System.Windows.Forms.Label();
            this.quickPlayMapModeTimeLabel = new System.Windows.Forms.Label();
            this.progress_label = new System.Windows.Forms.Label();
            this.quickPlayMapModeProgressBar = new System.Windows.Forms.ProgressBar();
            this.click_result_btn = new System.Windows.Forms.Button();
            this.quickPlayMapModeQuestionLabel = new System.Windows.Forms.Label();
            this.quickPlayMapModeQuestionBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = false;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Left;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.webView21.Name = "webView21";
            this.webView21.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.webView21.Size = new System.Drawing.Size(382, 437);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // select_difficulty_lbl
            // 
            this.select_difficulty_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.select_difficulty_lbl.AutoSize = true;
            this.select_difficulty_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_difficulty_lbl.Location = new System.Drawing.Point(495, 77);
            this.select_difficulty_lbl.Name = "select_difficulty_lbl";
            this.select_difficulty_lbl.Size = new System.Drawing.Size(219, 31);
            this.select_difficulty_lbl.TabIndex = 16;
            this.select_difficulty_lbl.Text = "Select Difficulty";
            // 
            // mapMode10CheckBox
            // 
            this.mapMode10CheckBox.AutoSize = true;
            this.mapMode10CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapMode10CheckBox.Location = new System.Drawing.Point(504, 124);
            this.mapMode10CheckBox.Name = "mapMode10CheckBox";
            this.mapMode10CheckBox.Size = new System.Drawing.Size(144, 24);
            this.mapMode10CheckBox.TabIndex = 17;
            this.mapMode10CheckBox.Text = "Ten Questions";
            this.mapMode10CheckBox.UseVisualStyleBackColor = true;
            // 
            // mapMode20CheckBox
            // 
            this.mapMode20CheckBox.AutoSize = true;
            this.mapMode20CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapMode20CheckBox.Location = new System.Drawing.Point(504, 151);
            this.mapMode20CheckBox.Name = "mapMode20CheckBox";
            this.mapMode20CheckBox.Size = new System.Drawing.Size(170, 24);
            this.mapMode20CheckBox.TabIndex = 18;
            this.mapMode20CheckBox.Text = "Twenty Questions";
            this.mapMode20CheckBox.UseVisualStyleBackColor = true;
            // 
            // mapMode30CheckBox
            // 
            this.mapMode30CheckBox.AutoSize = true;
            this.mapMode30CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapMode30CheckBox.Location = new System.Drawing.Point(504, 179);
            this.mapMode30CheckBox.Name = "mapMode30CheckBox";
            this.mapMode30CheckBox.Size = new System.Drawing.Size(158, 24);
            this.mapMode30CheckBox.TabIndex = 19;
            this.mapMode30CheckBox.Text = "Thirty Questions";
            this.mapMode30CheckBox.UseVisualStyleBackColor = true;
            // 
            // mapModeMaxCheckBox
            // 
            this.mapModeMaxCheckBox.AutoSize = true;
            this.mapModeMaxCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapModeMaxCheckBox.Location = new System.Drawing.Point(504, 206);
            this.mapModeMaxCheckBox.Name = "mapModeMaxCheckBox";
            this.mapModeMaxCheckBox.Size = new System.Drawing.Size(143, 24);
            this.mapModeMaxCheckBox.TabIndex = 20;
            this.mapModeMaxCheckBox.Text = "Max questions";
            this.mapModeMaxCheckBox.UseVisualStyleBackColor = true;
            // 
            // mapModeStartButton
            // 
            this.mapModeStartButton.Location = new System.Drawing.Point(506, 254);
            this.mapModeStartButton.Name = "mapModeStartButton";
            this.mapModeStartButton.Size = new System.Drawing.Size(202, 43);
            this.mapModeStartButton.TabIndex = 21;
            this.mapModeStartButton.Text = "Start";
            this.mapModeStartButton.UseVisualStyleBackColor = true;
            this.mapModeStartButton.Click += new System.EventHandler(this.mapModeStartButton_Click);
            // 
            // quickPlayMapModeScoreLabel
            // 
            this.quickPlayMapModeScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quickPlayMapModeScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickPlayMapModeScoreLabel.Location = new System.Drawing.Point(636, 363);
            this.quickPlayMapModeScoreLabel.Name = "quickPlayMapModeScoreLabel";
            this.quickPlayMapModeScoreLabel.Size = new System.Drawing.Size(119, 39);
            this.quickPlayMapModeScoreLabel.TabIndex = 22;
            this.quickPlayMapModeScoreLabel.Text = "Score:";
            this.quickPlayMapModeScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quickPlayMapModeTimeLabel
            // 
            this.quickPlayMapModeTimeLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quickPlayMapModeTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickPlayMapModeTimeLabel.Location = new System.Drawing.Point(552, 1);
            this.quickPlayMapModeTimeLabel.Name = "quickPlayMapModeTimeLabel";
            this.quickPlayMapModeTimeLabel.Size = new System.Drawing.Size(203, 38);
            this.quickPlayMapModeTimeLabel.TabIndex = 23;
            this.quickPlayMapModeTimeLabel.Text = "Time Left:";
            this.quickPlayMapModeTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_label.Location = new System.Drawing.Point(553, 344);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(72, 20);
            this.progress_label.TabIndex = 25;
            this.progress_label.Text = "Progress";
            this.progress_label.Click += new System.EventHandler(this.progress_label_Click);
            // 
            // quickPlayMapModeProgressBar
            // 
            this.quickPlayMapModeProgressBar.Location = new System.Drawing.Point(436, 411);
            this.quickPlayMapModeProgressBar.Name = "quickPlayMapModeProgressBar";
            this.quickPlayMapModeProgressBar.Size = new System.Drawing.Size(320, 23);
            this.quickPlayMapModeProgressBar.TabIndex = 24;
            // 
            // click_result_btn
            // 
            this.click_result_btn.Location = new System.Drawing.Point(506, 263);
            this.click_result_btn.Name = "click_result_btn";
            this.click_result_btn.Size = new System.Drawing.Size(202, 43);
            this.click_result_btn.TabIndex = 26;
            this.click_result_btn.Text = "Click on the map to pick an answer!";
            this.click_result_btn.UseVisualStyleBackColor = true;
            this.click_result_btn.Click += new System.EventHandler(this.click_result_btn_Click);
            // 
            // quickPlayMapModeQuestionLabel
            // 
            this.quickPlayMapModeQuestionLabel.AutoSize = true;
            this.quickPlayMapModeQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickPlayMapModeQuestionLabel.Location = new System.Drawing.Point(495, 77);
            this.quickPlayMapModeQuestionLabel.Name = "quickPlayMapModeQuestionLabel";
            this.quickPlayMapModeQuestionLabel.Size = new System.Drawing.Size(131, 31);
            this.quickPlayMapModeQuestionLabel.TabIndex = 27;
            this.quickPlayMapModeQuestionLabel.Text = "Question";
            // 
            // quickPlayMapModeQuestionBox
            // 
            this.quickPlayMapModeQuestionBox.AutoSize = true;
            this.quickPlayMapModeQuestionBox.BackColor = System.Drawing.Color.White;
            this.quickPlayMapModeQuestionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickPlayMapModeQuestionBox.Location = new System.Drawing.Point(501, 124);
            this.quickPlayMapModeQuestionBox.MaximumSize = new System.Drawing.Size(600, 52);
            this.quickPlayMapModeQuestionBox.MinimumSize = new System.Drawing.Size(47, 26);
            this.quickPlayMapModeQuestionBox.Name = "quickPlayMapModeQuestionBox";
            this.quickPlayMapModeQuestionBox.Size = new System.Drawing.Size(47, 26);
            this.quickPlayMapModeQuestionBox.TabIndex = 28;
            this.quickPlayMapModeQuestionBox.Text = "test";
            this.quickPlayMapModeQuestionBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapModeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.quickPlayMapModeQuestionBox);
            this.Controls.Add(this.quickPlayMapModeQuestionLabel);
            this.Controls.Add(this.click_result_btn);
            this.Controls.Add(this.progress_label);
            this.Controls.Add(this.quickPlayMapModeProgressBar);
            this.Controls.Add(this.quickPlayMapModeTimeLabel);
            this.Controls.Add(this.quickPlayMapModeScoreLabel);
            this.Controls.Add(this.mapModeStartButton);
            this.Controls.Add(this.mapModeMaxCheckBox);
            this.Controls.Add(this.mapMode30CheckBox);
            this.Controls.Add(this.mapMode20CheckBox);
            this.Controls.Add(this.mapMode10CheckBox);
            this.Controls.Add(this.select_difficulty_lbl);
            this.Controls.Add(this.webView21);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Name = "mapModeUC";
            this.Size = new System.Drawing.Size(1630, 437);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     
        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label select_difficulty_lbl;
        private System.Windows.Forms.CheckBox mapMode10CheckBox;
        private System.Windows.Forms.CheckBox mapMode20CheckBox;
        private System.Windows.Forms.CheckBox mapMode30CheckBox;
        private System.Windows.Forms.CheckBox mapModeMaxCheckBox;
        private System.Windows.Forms.Button mapModeStartButton;
        private System.Windows.Forms.Label quickPlayMapModeScoreLabel;
        private System.Windows.Forms.Label quickPlayMapModeTimeLabel;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.ProgressBar quickPlayMapModeProgressBar;
        private System.Windows.Forms.Button click_result_btn;
        private System.Windows.Forms.Label quickPlayMapModeQuestionLabel;
        private System.Windows.Forms.Label quickPlayMapModeQuestionBox;
    }
}
