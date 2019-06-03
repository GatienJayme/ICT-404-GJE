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
            if (txtBrut.Text == "" || txtCoeff.Text == "")
                {
                MessageBox.Show("faut remplir les deux !!!");
                return;
            }
            float res;
            float brut ;
            float coef ;
            float dedje ;
            float dedtr ;
            float raba ;
            if (!float.TryParse(txtBrut.Text, out brut))
            {
                MessageBox.Show("Nop refais");
                return;
            }
            if (!float.TryParse(txtCoeff.Text, out coef))
            {
                MessageBox.Show("Faut remplir avec des chiffres");
                return;
            }
            if (!float.TryParse(txtDeducjeune.Text, out dedje))
            {
                MessageBox.Show("Toujours pas");
                return;
            }
            if (!float.TryParse(txtDeducTrsp.Text, out dedtr))
            {
                MessageBox.Show("Eh bah non");
                return;
            }
            if (!float.TryParse(txtRabais.Text, out raba))
            {
                MessageBox.Show("oooooooo presque mais non");
                return;
            }
            res = brut / coef; // resultats coefficient
            if (rab.Checked == true)
            {
                res -= (raba * brut / 100); // resultats rabais
            }
            if (dedj.Checked == true)
            {
                res -= dedje; // resultats et deductions jeunes
            }
            if (dedt.Checked == true)
            {
                res -= dedtr; // reseultats et deductions transports
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

        private void txtBrut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
