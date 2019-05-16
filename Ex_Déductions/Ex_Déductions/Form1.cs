// Program: Ex_Déductions
// Author: Gatien Jayme 
// Date: 13.05.2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Déductions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float res;
            float brut = float.Parse(revenuea.Text);
            float coef = float.Parse(coeff.Text);
            float dedje = float.Parse(dedj.Text);
            float dedtr = float.Parse(dedt.Text);
            float raba = float.Parse(rab.Text);

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
