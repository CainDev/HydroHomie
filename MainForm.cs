using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydroHomie
{
    public partial class MainForm : Form
    {
        // 1 Tick = 1 Second
        // 60 Ticks = 1 Minute, 600 Ticks = 10 Minutes, 3600 Ticks = 1 Hour
        int oldTimerTicks = 0;
        int timerTickRate = 3600;
        int currTimerTicks = 0;
        HydroFactsClass facts = new HydroFactsClass();
        FileReadWriteClass fileClass = new FileReadWriteClass();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileClass.CreateFolder();
            label1.Text = $"Cups Consumed: {Convert.ToString(fileClass.ReadCups())}";
            HydroHomieNotifTimer.Start();
            HydroHomie.BalloonTipTitle = "Hydro Homie!";
        }

        private void SetNotifTime()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    // 30 Minutes
                    timerTickRate = 1800;
                    currTimerTicks = 0;
                    HydroHomie.BalloonTipText = "It has been 30 Minutes since your last drink of water, have a small cup now to stay hydrated!";
                    break;
                case 1:
                    // 45 Minutes
                    timerTickRate = 2700;
                    currTimerTicks = 0;
                    HydroHomie.BalloonTipText = "It has been 45 Minutes since your last drink of water, have a small cup now to stay hydrated!";
                    break;
                case 2:
                    // 1 Hour
                    timerTickRate = 3600;
                    currTimerTicks = 0;
                    HydroHomie.BalloonTipText = "It has been 1 Hour since your last drink of water, have a small cup now to stay hydrated!";
                    break;
                case 3:
                    // 1 Hour 15 Minutes
                    timerTickRate = 4500;
                    currTimerTicks = 0;
                    HydroHomie.BalloonTipText = "It has been 1 Hour 15 Minutes since your last drink of water, have a small cup now to stay hydrated!";
                    break;
                case 4:
                    // 1 Hour 30 Minutes
                    timerTickRate = 5400;
                    currTimerTicks = 0;
                    HydroHomie.BalloonTipText = "It has been 1 Hour 30 Minutes since your last drink of water, have a small cup now to stay hydrated!";
                    break;
                case 5:
                    // 1 Hour 45 Minutes
                    timerTickRate = 6300;
                    currTimerTicks = 0;
                    HydroHomie.BalloonTipText = "It has been 1 Hour 45 Minutes since your last drink of water, have a small cup now to stay hydrated!";
                    break;
                case 6:
                    // 2 Hours
                    timerTickRate = 7200;
                    currTimerTicks = 0;
                    HydroHomie.BalloonTipText = "It has been 2 Hours since your last drink of water, have a small cup now to stay hydrated!";
                    break;
                default:
                    timerTickRate = 3600;
                    currTimerTicks = 0;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currTimerTicks++;

            if(currTimerTicks > oldTimerTicks + timerTickRate)
            {
                SetNotifTime();
                oldTimerTicks = currTimerTicks;                     
                HydroHomie.ShowBalloonTip(3000);
                fileClass.cupsDrunk++;
                fileClass.WriteCups(fileClass.cupsDrunk);
                label1.Text = $"Cups Consumed: {Convert.ToString(fileClass.ReadCups())}";

                if (facts.showFacts)
                {
                    HydroHomie.BalloonTipText = facts.GenerateEitherFact();
                    HydroHomie.ShowBalloonTip(3000);
                }            
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HydroHomie_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            HydroHomie.Visible = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                HydroHomie.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                facts.showFacts = true;
                MessageBox.Show("Facts Enabled!");
            }
            else
            {
                facts.showFacts = false;
                MessageBox.Show("Facts Disabled!");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetNotifTime();
            MessageBox.Show("Current timer reset, new time saved!");
        }
    }
}
