namespace Geo
{
    partial class TestingForm
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
            this.mapModeUC1 = new Geo.mapModeUC();
            this.SuspendLayout();
            // 
            // mapModeUC1
            // 
            this.mapModeUC1.Location = new System.Drawing.Point(15, 25);
            this.mapModeUC1.Margin = new System.Windows.Forms.Padding(6);
            this.mapModeUC1.Name = "mapModeUC1";
            this.mapModeUC1.Padding = new System.Windows.Forms.Padding(2);
            this.mapModeUC1.Size = new System.Drawing.Size(1642, 925);
            this.mapModeUC1.TabIndex = 0;
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1945, 1058);
            this.Controls.Add(this.mapModeUC1);
            this.Name = "TestingForm";
            this.Text = "TestingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private mapModeUC mapModeUC1;
    }
}