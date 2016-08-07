﻿using System;
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
        int m = 1;
        int s = 0;

        public int intPublicM;
        public int intPublicS;
        
        bool boolOvertime = false;

        public Form1()
        {
            InitializeComponent();

            progressBarTime.Maximum = m * 60;
            progressBarTime.Value = 0;
        }

        public Form2 f;

        public Screen[] sc;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sc = Screen.AllScreens;
            //var scValue = sc.Max();
            //var scIndex = sc.ToList().IndexOf(scValue);

            int scIndex = sc.GetUpperBound(0);

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
            if (boolOvertime == false)
            {
                timerDown.Start();
                f.CountDownStart();
            }
            else
            {
                timerUp.Start();
                f.CountUpStart();
            }
            
            buttonStart.Enabled = false;
            buttonStart.BackColor = SystemColors.Control;
            buttonStop.Enabled = true;
            buttonStop.BackColor = Color.Red;
            buttonPlus1.Enabled = false;
            buttonPlus1.BackColor = SystemColors.Control;
            buttonMinus1.Enabled = false;
            buttonMinus1.BackColor = SystemColors.Control;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timerDown.Stop();
            timerUp.Stop();
            f.CountDownStop();
            f.CountUpStop();
            buttonStart.Enabled = true;
            buttonStart.BackColor = Color.Lime;
            buttonStop.Enabled = false;
            buttonStop.BackColor = SystemColors.Control;
            buttonPlus1.Enabled = true;
            buttonPlus1.BackColor = Color.Orange;
            buttonMinus1.Enabled = true;
            buttonMinus1.BackColor = Color.Orange;
        }

        private void timerDown_Tick(object sender, EventArgs e)
        {
            string stringM;
            string stringS;

            s = s - 1;

            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }

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
                progressBarTime.Value = 0;
                labelTime.ForeColor = Color.Red;
                if (checkBoxSound.Checked)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Ring01.wav");
                    player.Play();
                }
            }

            if (m == 0 && s == 0)
            {
                timerDown.Stop();
                timerUp.Start();
                f.CountDownStop();
                f.CountUpStart();
                boolOvertime = true;
            }

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

            labelTime.Text = stringM + ":" + stringS;

            double doublePercent = (double)progressBarTime.Value / (double)progressBarTime.Maximum;

            if ((doublePercent <= 0.1) && (doublePercent > 0))
            {
                labelTime.ForeColor = Color.Orange;
            }
            else if (doublePercent == 0)
            {
                labelTime.ForeColor = Color.Red;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            boolOvertime = false;

            m = m + 1;
            s = 0;

            intPublicM = m;
            intPublicS = s;

            if (m > 30)
            {
                m = 30;
                intPublicM = m;
            }

            if (m < 10)
            {
                labelLength.Text = "0" + Convert.ToString(m) + ":00";
                labelTime.Text = "0" + Convert.ToString(m) + ":00";
            }
            else
            {
                labelLength.Text = Convert.ToString(m) + ":00";
                labelTime.Text = Convert.ToString(m) + ":00";
            }

            progressBarTime.Maximum = m * 60;
            progressBarTime.Value = 0;
            

            labelTime.ForeColor = Color.Lime;
            
            f.UpdateLabel(this.labelTime.Text, (m * 60),0);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            boolOvertime = false;

            m = m - 1;
            s = 0;

            intPublicM = m;
            intPublicS = s;

            if (m < 1)
            {
                m = 1;
                intPublicM = m;
            }

            if (m < 10)
            {
                labelLength.Text = "0" + Convert.ToString(m) + ":00";
                labelTime.Text = "0" + Convert.ToString(m) + ":00";
            }
            else
            {
                labelLength.Text = Convert.ToString(m) + ":00";
                labelTime.Text = Convert.ToString(m) + ":00";
            }

            progressBarTime.Maximum = m * 60;
            progressBarTime.Value = 0;

            labelTime.ForeColor = Color.Lime;

            f.UpdateLabel(this.labelTime.Text, (m * 60), 0);
        }

        private void timerUp_Tick(object sender, EventArgs e)
        {
            string stringM;
            string stringS;
            
            s = s + 1;

            if (s == 61)
            {
                m = m + 1;
                s = 1;
            }

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

            labelTime.Text = stringM + ":" + stringS;

        }

        private void checkBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSound.Checked)
            {
                pictureBoxSound.Image = Properties.Resources.SoundOn;
            }
            else
            {
                pictureBoxSound.Image = Properties.Resources.SoundOff;
            }
        }
    }
}
