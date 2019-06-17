using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        int count = 1000;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblsecondes.Text = count.ToString();
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            count++;
            int secondes = count % 60;
            int minutes = count / 60;
            lblminutes.Text = minutes.ToString("D2");
            lblsecondes.Text = secondes.ToString("D2");
        }

        private void cmdStartStop_Click(object sender, EventArgs e)
        {
            if (tmrTick.Enabled)
            {
                tmrTick.Enabled = false;
                cmdStartStop.Text = "Start";
            }
            else
            {
                tmrTick.Enabled = true;
                cmdStartStop.Text = "Stop";
            }
        }
    }
}
