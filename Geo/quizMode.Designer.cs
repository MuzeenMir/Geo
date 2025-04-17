namespace Geo
{
    partial class quizMode
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
            this.quizModeUC1 = new Geo.quizModeUC();
            this.SuspendLayout();
            // 
            // quizModeUC1
            // 
            this.quizModeUC1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.quizModeUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizModeUC1.Location = new System.Drawing.Point(0, 0);
            this.quizModeUC1.Name = "quizModeUC1";
            this.quizModeUC1.Padding = new System.Windows.Forms.Padding(1);
            this.quizModeUC1.Size = new System.Drawing.Size(800, 450);
            this.quizModeUC1.TabIndex = 0;
            this.quizModeUC1.Load += new System.EventHandler(this.quizModeUC1_Load);
            // 
            // quizMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quizModeUC1);
            this.Name = "quizMode";
            this.Text = "quizMode";
            this.Load += new System.EventHandler(this.quizMode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private quizModeUC quizModeUC1;
    }
}