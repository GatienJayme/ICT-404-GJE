﻿// Program: Ex_Déductions
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
            if (txtBrut.Text == "" || txtCoeff.Text == "")
                {
                MessageBox.Show("faut remplir les deux !!!");
                return;
            }
            float res;
            float brut = float.Parse(txtBrut.Text);
            float coef = float.Parse(txtCoeff.Text);
            float dedje = float.Parse(txtDeducjeune.Text);
            float dedtr = float.Parse(txtDeducTrsp.Text);
            float raba = float.Parse(txtRabais.Text);
            res = brut / coef;
            if (rab.Checked == true)
            {
                res -= (raba * brut / 100);
            }
            if (dedj.Checked == true)
            {
                res -= dedje;
            }
            if (dedt.Checked == true)
            {
                res -= dedtr;
            }
            revenui.Visible = true;
            revenui.Text = "Revenu imposable: fr. " + res.ToString();
            

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void revenui_Click(object sender, EventArgs e)
        {
            
        }
    }
}
