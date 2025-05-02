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
            this.quickPlayQuizModeScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = false;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Left;
            this.webView21.Location = new System.Drawing.Point(2, 2);
            this.webView21.Name = "webView21";
            this.webView21.Padding = new System.Windows.Forms.Padding(1);
            this.webView21.Size = new System.Drawing.Size(765, 921);
            this.webView21.TabIndex = 0;
            this.webView21.Visible = false;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // select_difficulty_lbl
            // 
            this.select_difficulty_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.select_difficulty_lbl.AutoSize = true;
            this.select_difficulty_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_difficulty_lbl.Location = new System.Drawing.Point(1000, 150);
            this.select_difficulty_lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.select_difficulty_lbl.Name = "select_difficulty_lbl";
            this.select_difficulty_lbl.Size = new System.Drawing.Size(416, 63);
            this.select_difficulty_lbl.TabIndex = 16;
            this.select_difficulty_lbl.Text = "Select Difficulty";
            // 
            // mapMode10CheckBox
            // 
            this.mapMode10CheckBox.AutoSize = true;
            this.mapMode10CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapMode10CheckBox.Location = new System.Drawing.Point(1011, 240);
            this.mapMode10CheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.mapMode10CheckBox.Name = "mapMode10CheckBox";
            this.mapMode10CheckBox.Size = new System.Drawing.Size(270, 41);
            this.mapMode10CheckBox.TabIndex = 17;
            this.mapMode10CheckBox.Text = "Ten Questions";
            this.mapMode10CheckBox.UseVisualStyleBackColor = true;
            // 
            // mapMode20CheckBox
            // 
            this.mapMode20CheckBox.AutoSize = true;
            this.mapMode20CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapMode20CheckBox.Location = new System.Drawing.Point(1011, 293);
            this.mapMode20CheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.mapMode20CheckBox.Name = "mapMode20CheckBox";
            this.mapMode20CheckBox.Size = new System.Drawing.Size(320, 41);
            this.mapMode20CheckBox.TabIndex = 18;
            this.mapMode20CheckBox.Text = "Twenty Questions";
            this.mapMode20CheckBox.UseVisualStyleBackColor = true;
            // 
            // mapMode30CheckBox
            // 
            this.mapMode30CheckBox.AutoSize = true;
            this.mapMode30CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapMode30CheckBox.Location = new System.Drawing.Point(1011, 346);
            this.mapMode30CheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.mapMode30CheckBox.Name = "mapMode30CheckBox";
            this.mapMode30CheckBox.Size = new System.Drawing.Size(298, 41);
            this.mapMode30CheckBox.TabIndex = 19;
            this.mapMode30CheckBox.Text = "Thirty Questions";
            this.mapMode30CheckBox.UseVisualStyleBackColor = true;
            // 
            // mapModeMaxCheckBox
            // 
            this.mapModeMaxCheckBox.AutoSize = true;
            this.mapModeMaxCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapModeMaxCheckBox.Location = new System.Drawing.Point(1011, 399);
            this.mapModeMaxCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.mapModeMaxCheckBox.Name = "mapModeMaxCheckBox";
            this.mapModeMaxCheckBox.Size = new System.Drawing.Size(267, 41);
            this.mapModeMaxCheckBox.TabIndex = 20;
            this.mapModeMaxCheckBox.Text = "Max questions";
            this.mapModeMaxCheckBox.UseVisualStyleBackColor = true;
            // 
            // mapModeStartButton
            // 
            this.mapModeStartButton.Location = new System.Drawing.Point(1011, 488);
            this.mapModeStartButton.Margin = new System.Windows.Forms.Padding(6);
            this.mapModeStartButton.Name = "mapModeStartButton";
            this.mapModeStartButton.Size = new System.Drawing.Size(405, 82);
            this.mapModeStartButton.TabIndex = 21;
            this.mapModeStartButton.Text = "Start";
            this.mapModeStartButton.UseVisualStyleBackColor = true;
            // 
            // quickPlayQuizModeScoreLabel
            // 
            this.quickPlayQuizModeScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quickPlayQuizModeScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickPlayQuizModeScoreLabel.Location = new System.Drawing.Point(1380, 754);
            this.quickPlayQuizModeScoreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.quickPlayQuizModeScoreLabel.Name = "quickPlayQuizModeScoreLabel";
            this.quickPlayQuizModeScoreLabel.Size = new System.Drawing.Size(238, 75);
            this.quickPlayQuizModeScoreLabel.TabIndex = 22;
            this.quickPlayQuizModeScoreLabel.Text = "Score:";
            this.quickPlayQuizModeScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mapModeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quickPlayQuizModeScoreLabel);
            this.Controls.Add(this.mapModeStartButton);
            this.Controls.Add(this.mapModeMaxCheckBox);
            this.Controls.Add(this.mapMode30CheckBox);
            this.Controls.Add(this.mapMode20CheckBox);
            this.Controls.Add(this.mapMode10CheckBox);
            this.Controls.Add(this.select_difficulty_lbl);
            this.Controls.Add(this.webView21);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "mapModeUC";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(1642, 925);
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
        private System.Windows.Forms.Label quickPlayQuizModeScoreLabel;
    }
}
