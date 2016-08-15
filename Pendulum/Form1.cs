using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendulum
{
    public partial class Form1 : Form
    {
        //Declare and set minutes and seconds integers
        int m = 1;
        int s = 0;

        //Declare minutes and seconds public integers
        public int intPublicM;
        public int intPublicS;
        
        //Declare and set overtime boolean to false
        bool boolOvertime = false;

        //Delcare and initalise Form1
        public Form1()
        {
            InitializeComponent();

            //Set progress bar maximum and current value
            progressBarTime.Maximum = m * 60;
            progressBarTime.Value = 0;
        }

        //Declare Form2 class
        public Form2 f;

        //Declare Screen class
        public Screen[] sc;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Start Clock timer
            timerClock.Start();

            //Set tooltips for forms
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.buttonStart, "Start timer"
                + Environment.NewLine
                + "Shortcut: CTRL + Enter");
            ToolTip1.SetToolTip(this.buttonStop, "Stop timer"
                + Environment.NewLine
                + "Shortcut: CTRL + Enter");
            ToolTip1.SetToolTip(this.buttonMinus1, "Minus 1 minute from timer" 
                + Environment.NewLine  
                + "Shortcut: CTRL + [");
            ToolTip1.SetToolTip(this.buttonPlus1, "Plus 1 minute to timer" 
                + Environment.NewLine 
                + "Shortcut: CTRL + ]");
            ToolTip1.SetToolTip(this.buttonSound, "Enable or disable 'Time is up!' sound"
                + Environment.NewLine
                + "Shortcut: CTRL + S");

            //Get all the screen widths and heights
            sc = Screen.AllScreens;
            //var scValue = sc.Max();
            //var scIndex = sc.ToList().IndexOf(scValue);

            //Get the highest numbered screen
            int scIndex = sc.GetUpperBound(0);

            //Run the showOnMontor function based on highest screen number
            if (scIndex == 0)
            {
                showOnMonitor1();
            }
            else if (scIndex == 1)
            {
                showOnMonitor2();
            }
            else if (scIndex == 2)
            {
                showOnMonitor3();
            }
        }

        //Run Form2 on the 1st monitor
        private void showOnMonitor1()
        {
            intPublicM = m;
            intPublicS = s;

            //Screen[] sc;
            //sc = Screen.AllScreens;
            //get all the screen width and heights
            f = new Form2(this);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Left = sc[0].Bounds.Width;
            f.Top = sc[0].Bounds.Height;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = sc[0].Bounds.Location;
            Point p = new Point(sc[0].Bounds.Location.X, sc[0].Bounds.Location.Y);
            f.Location = p;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        //Run Form2 on the 2nd monitor
        private void showOnMonitor2()
        {
            intPublicM = m;
            intPublicS = s;

            //Screen[] sc;
            //sc = Screen.AllScreens;
            //get all the screen width and heights 
            f = new Form2(this);
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Left = sc[1].Bounds.Width;
            f.Top = sc[1].Bounds.Height;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = sc[1].Bounds.Location;
            Point p = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
            f.Location = p;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        //Run Form2 on the 3rd monitor
        private void showOnMonitor3()
        {
            intPublicM = m;
            intPublicS = s;

            //Screen[] sc;
            //sc = Screen.AllScreens;
            //get all the screen width and heights 
            f = new Form2(this);
            //f.FormBorderStyle = FormBorderStyle.None;
            f.Left = sc[2].Bounds.Width;
            f.Top = sc[2].Bounds.Height;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = sc[2].Bounds.Location;
            Point p = new Point(sc[2].Bounds.Location.X, sc[2].Bounds.Location.Y);
            f.Location = p;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //Check if Overtime
            if (boolOvertime == false)
            {
                //If false, start countdown timer
                timerDown.Start();
                f.CountDownStart();
            }
            else if (boolOvertime == true)
            {
                //if true, start countup timer
                timerUp.Start();
                f.CountUpStart();
            }
            
            //Enable stop button and disable all other controls
            //Change button colors
            buttonStart.Enabled = false;
            buttonStart.BackColor = SystemColors.Control;
            buttonStop.Enabled = true;
            buttonStop.BackColor = Color.Red;
            buttonPlus1.Enabled = false;
            buttonPlus1.BackColor = SystemColors.Control;
            buttonMinus1.Enabled = false;
            buttonMinus1.BackColor = SystemColors.Control;
            groupBoxPresets.Enabled = false;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            //Stop timers on Form1
            timerDown.Stop();
            timerUp.Stop();

            //Stop timers on Form2
            f.CountDownStop();
            f.CountUpStop();

            //Disable stop button and enable all other controls
            //Change button colors
            buttonStart.Enabled = true;
            buttonStart.BackColor = Color.Lime;
            buttonStop.Enabled = false;
            buttonStop.BackColor = SystemColors.Control;
            buttonPlus1.Enabled = true;
            buttonPlus1.BackColor = Color.Orange;
            buttonMinus1.Enabled = true;
            buttonMinus1.BackColor = Color.Orange;
            groupBoxPresets.Enabled = true;
        }

        private void timerDown_Tick(object sender, EventArgs e)
        {
            //Delcare minute and second strings
            string stringM;
            string stringS;

            //Second integer minus 1
            s = s - 1;

            //If second integer equals -1
            //Minute integer minus 1
            //Second integer equals 59
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }

            //Set progress bar value based on remaining time left
            if (m > 0 || s > 0)
            {
                progressBarTime.Value = (m * 60) + s;
            }
            else if (m == 0 && s > 0)
            {
                progressBarTime.Value = s;
            }
            else if (m > 0 && s == 0)
            {
                progressBarTime.Value = m * 60;
            }
            else if (m == 0 && s == 0)
            {
                //If time left is 0, set color to red and play sound
                progressBarTime.Value = 0;
                labelTime.ForeColor = Color.Red;
                labelLength.ForeColor = Color.Red;
                labelClock.ForeColor = Color.Red;
                if (buttonSound.BackColor == Color.Lime)
                {
                    System.Media.SoundPlayer player = 
                        new System.Media.SoundPlayer(@"C:\Windows\Media\Ring01.wav");
                    player.Play();
                }
            }

            //If time left is 0
            //Stop countdown timer
            //Start countup timer
            //Set overtime boolean to true
            if (m == 0 && s == 0)
            {
                timerDown.Stop();
                timerUp.Start();
                f.CountDownStop();
                f.CountUpStart();
                boolOvertime = true;
            }

            //Format time text based on remaining time left
            if (m < 10)
            {
                stringM = "0" + Convert.ToString(m);
                stringM = "0" + Convert.ToString(m);
            }
            else
            {
                stringM = Convert.ToString(m);
                stringM = Convert.ToString(m);
            }

            if (s < 10)
            {
                stringS = "0" + Convert.ToString(s);
                stringS = "0" + Convert.ToString(s);
            }
            else
            {
                stringS = Convert.ToString(s);
                stringS = Convert.ToString(s);
            }

            //Concatenate minutes and seconds string
            labelTime.Text = stringM + ":" + stringS;

            //Decalre and set percentage time remaining
            double doublePercent = (double)progressBarTime.Value / (double)progressBarTime.Maximum;

            //Format display based on percentage time left
            if ((doublePercent <= 0.1) && (doublePercent > 0))
            {
                labelTime.ForeColor = Color.Orange;
                labelLength.ForeColor = Color.Orange;
                labelClock.ForeColor = Color.Orange;
            }
            else if (doublePercent == 0)
            {
                labelTime.ForeColor = Color.Red;
                labelLength.ForeColor = Color.Red;
                labelClock.ForeColor = Color.Red;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //Set overtime boolean to false
            boolOvertime = false;

            //Minute integer + 1
            //Second integer = 0
            m = m + 1;
            s = 0;

            //Set public minute integer to minute integer
            //Set public second integer to second integer
            intPublicM = m;
            intPublicS = s;

            //If minute integer is greater than 30, set to 30
            if (m > 30)
            {
                m = 30;
                intPublicM = m;
            }

            //If minute integer is less than 10, format timer text
            if (m < 10)
            {
                labelLength.Text = "Talk Length: 0" + Convert.ToString(m) + ":00";
                labelTime.Text = "0" + Convert.ToString(m) + ":00";
            }
            else
            {
                labelLength.Text = "Talk Length: " + Convert.ToString(m) + ":00";
                labelTime.Text = Convert.ToString(m) + ":00";
            }

            //Set progressbar maximum and value to 0
            progressBarTime.Maximum = m * 60;
            progressBarTime.Value = 0;
            
            //Format timer color
            labelTime.ForeColor = Color.Lime;
            labelLength.ForeColor = Color.Lime;
            labelClock.ForeColor = Color.Lime;

            //Call update label function in Form2
            //Pass time text, progressbar maximum and value
            f.UpdateLabel(this.labelTime.Text, (m * 60),0);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            //Set overtime boolean to false
            boolOvertime = false;

            //Minute integer - 1
            //Second integer = 0
            m = m - 1;
            s = 0;

            //Set public minute integer to minute integer
            //Set public second integer to second integer
            intPublicM = m;
            intPublicS = s;

            //If minute integer is less than 1, set to 1
            if (m < 1)
            {
                m = 1;
                intPublicM = m;
            }
            
            //If minute integer is less than 10, format timer text
            if (m < 10)
            {
                labelLength.Text = "Talk Length: 0" + Convert.ToString(m) + ":00";
                labelTime.Text = "0" + Convert.ToString(m) + ":00";
            }
            else
            {
                labelLength.Text = "Talk Length: " + Convert.ToString(m) + ":00";
                labelTime.Text = Convert.ToString(m) + ":00";
            }

            //Set progressbar maximum and value to 0
            progressBarTime.Maximum = m * 60;
            progressBarTime.Value = 0;

            //Format timer color
            labelTime.ForeColor = Color.Lime;
            labelLength.ForeColor = Color.Lime;
            labelClock.ForeColor = Color.Lime;

            //Call update label function in Form2
            //Pass time text, progressbar maximum and value
            f.UpdateLabel(this.labelTime.Text, (m * 60), 0);
        }

        private void timerUp_Tick(object sender, EventArgs e)
        {
            //Declare minute and second strings
            string stringM;
            string stringS;
            
            //Second integer +1
            s = s + 1;

            //If second integer = 61
            //+ 1 to minute integer
            //Set second integer to 1 
            if (s == 61)
            {
                m = m + 1;
                s = 1;
            }

            //Format minute string based on value
            if (m < 10)
            {
                stringM = "0" + Convert.ToString(m);
                stringM = "0" + Convert.ToString(m);
            }
            else
            {
                stringM = Convert.ToString(m);
                stringM = Convert.ToString(m);
            }

            //Format second string based on value
            if (s < 10)
            {
                stringS = "0" + Convert.ToString(s);
                stringS = "0" + Convert.ToString(s);
            }
            else
            {
                stringS = Convert.ToString(s);
                stringS = Convert.ToString(s);
            }

            //Concatenate minute and second strings
            labelTime.Text = stringM + ":" + stringS;

        }

        //Declare shortcut key functions
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.OemOpenBrackets)
            {
                buttonMinus1.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.OemCloseBrackets)
            {
                buttonPlus1.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.Enter && buttonStart.Enabled == true)
            {
                buttonStart.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.Enter && buttonStop.Enabled == true)
            {
                buttonStop.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                buttonSound.PerformClick();
            }
        }

        private void buttonSound_Click(object sender, EventArgs e)
        {
            //Enable sound
            if (buttonSound.BackColor == Color.Red)
            {
                buttonSound.BackgroundImage = Properties.Resources.SoundOn;
                buttonSound.BackColor = Color.Lime;
            }
            //Disable sound
            else if (buttonSound.BackColor == Color.Lime)
            {
                buttonSound.BackgroundImage = Properties.Resources.SoundOff;
                buttonSound.BackColor = Color.Red;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Set overtime boolean to false
            boolOvertime = false;

            //Check which radio button was selected
            //Set the minute integer
            RadioButton btn = (RadioButton)sender;
            if (btn != null && btn.Checked)
            {
                switch (btn.Name)
                {
                    case "radioButtonTreasures" :
                        m = 10;
                        break;
                    case "radioButtonDigging":
                        m = 8;
                        break;
                    case "radioButtonBibleReading":
                        m = 4;
                        break;
                    case "radioButtonInitialCall":
                        m = 2;
                        break;
                    case "radioButtonReturnVisit":
                        m = 4;
                        break;
                    case "radioButtonBibleStudy":
                        m = 6;
                        break;
                    case "radioButtonPublicTalk":
                        m = 30;
                        break;
                }
            }

            //Set second integer to 0
            s = 0;

            //Set public minute integer to minute integer
            //Set public second integer to second integer
            intPublicM = m;
            intPublicS = s;

            if (m < 1)
            {
                m = 1;
                intPublicM = m;
            }

            //If minute integer is less than 10, format timer text
            if (m < 10)
            {
                labelLength.Text = "Talk Length: 0" + Convert.ToString(m) + ":00";
                labelTime.Text = "0" + Convert.ToString(m) + ":00";
            }
            else
            {
                labelLength.Text = "Talk Length: " + Convert.ToString(m) + ":00";
                labelTime.Text = Convert.ToString(m) + ":00";
            }

            //Set progressbar maximum and value
            progressBarTime.Maximum = m * 60;
            progressBarTime.Value = 0;

            //Format timer color
            labelTime.ForeColor = Color.Lime;
            labelLength.ForeColor = Color.Lime;
            labelClock.ForeColor = Color.Lime;

            //Call update label function in Form2
            //Pass time text, progressbar maximum and value
            f.UpdateLabel(this.labelTime.Text, (m * 60), 0);
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.labelClock.Text = "Current Time: " + dateTime.ToString("HH:mm:ss");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you would like to quit Pendulum?", 
                "Quit Pendulum?", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }
    }
}