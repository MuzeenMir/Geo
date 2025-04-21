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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quizMode));
            this.quizModeUC1 = new Geo.quizModeUC();
            this.SuspendLayout();
            // 
            // quizModeUC1
            // 
            this.quizModeUC1.Location = new System.Drawing.Point(-1, -2);
            this.quizModeUC1.Name = "quizModeUC1";
            this.quizModeUC1.Size = new System.Drawing.Size(681, 355);
            this.quizModeUC1.TabIndex = 0;
            this.quizModeUC1.Load += new System.EventHandler(this.quizModeUC1_Load);
            // 
            // quizMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.quizModeUC1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "quizMode";
            this.Text = "quizMode";
            this.Load += new System.EventHandler(this.quizMode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private quizModeUC quizModeUC1;
    }
}