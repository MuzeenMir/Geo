using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}