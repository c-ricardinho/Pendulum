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
    public partial class Form2 : Form
    {
        int m = 1;
        int s = 0;
        
        public Form1 originalForm;

        public Form2(Form1 incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();

            progressBarTime.Maximum = m * 60;
            progressBarTime.Value = 0;

            timerClock.Start();
        }

        public void UpdateLabel(string stringTime, int pbMax, int pbValue)
        {
            labelTime.Text = stringTime;

            m = originalForm.intPublicM;
            s = originalForm.intPublicS;

            progressBarTime.Maximum = pbMax;
            progressBarTime.Value = pbValue;

            labelText.Text = "Time Remaining:";
            labelText.ForeColor = Color.Lime;
            labelTime.ForeColor = Color.Lime;
        }

        public void CountDownStart()
        {
            timerDown.Start();
        }

        public void CountDownStop()
        {
            timerDown.Stop();
        }

        public void CountUpStart()
        {
            timerUp.Start();
        }

        public void CountUpStop()
        {
            timerUp.Stop();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelText.Font = new Font(labelTime.Font.FontFamily.Name, 100);
            labelTime.Font = new Font(labelTime.Font.FontFamily.Name, 350);
            m = originalForm.intPublicM;
            s = originalForm.intPublicS;

            if (m < 10)
            {
                labelTime.Text = "0" + Convert.ToString(m) + ":00";
            }
            else
            {
                labelTime.Text = Convert.ToString(m) + ":00";
            }
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
                labelText.Text = "TIME IS UP!";
                labelText.ForeColor = Color.Red;
                labelTime.ForeColor = Color.Red;
            }

            if (m == 0 && s == 0)
            {
                timerDown.Stop();
                timerUp.Start();
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
                labelText.ForeColor = Color.Orange;
                labelTime.ForeColor = Color.Orange;
            }
            else if (doublePercent == 0)
            {
                //labelText.Text = "TIME IS UP";
                //labelText.ForeColor = Color.Red;
                //labelTime.ForeColor = Color.Red;
            }
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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.labelClock.Text = dateTime.ToString("dddd MMMM dd, yyyy - HH:mm:ss");
        }
    }
}
