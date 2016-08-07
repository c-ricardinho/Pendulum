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
        int m;
        int s;

        Form1 originalForm;
        public Form2(Form1 incomingForm)
        {
            originalForm = incomingForm;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelTime.Font = new Font(labelTime.Font.FontFamily.Name, 50);
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

        

    }
}
