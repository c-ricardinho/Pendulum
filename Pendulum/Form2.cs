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
        private Form1 formForm1;

        private void getTimerInfo()
        {
            //string mm = Convert.ToString(formForm1.intM);
            //string ss = Convert.ToString(formForm1.intS);

            //TimerLabel.Text = mm + ":" + ss;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TimerLabel.Font = new Font(TimerLabel.Font.FontFamily.Name, 400);
            getTimerInfo();

            //string mm = Convert.ToString(formForm1.intM);
            //string ss = Convert.ToString(formForm1.intS);

            //TimerLabel.Text = mm + ":" + ss;

            
        }

        

    }
}
