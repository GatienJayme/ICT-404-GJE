// program: ICT_404_commande_pizza
// Author: Gatien Jayme
// Date: 27.05.2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_Commande_pizza
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

        private void txtresu_Click(object sender, EventArgs e)
        {
                
        }

        private void txtbtable_TextChanged(object sender, EventArgs e)
        {

        }

        private void butcommander_Click(object sender, EventArgs e)
        {
            txtresu.BackColor = Color.Yellow;
            txtresu.Text = "Pour la "+ txtbtable.Text+": pâte ";
            if (txtbtable.Text == "")
            {
                MessageBox.Show("Remplir case table");
            }
            if (rbtEppaisse.Checked)
            {
                txtresu.Text += "épaisse";
            }
            if (rbtextrafine.Checked)
            {
                txtresu.Text += "extra-fine";
            }
            if (rbtfine.Checked)
            {
                txtresu.Text += "fine";
            }
            if (rbtnormale.Checked)
            {
                txtresu.Text += "normale";
            }
            txtresu.Text += " avec ";

            if (chkanchois.Checked)
            {
                txtresu.Text += "anchois, ";
            }
            if (chkcapres.Checked)
            {
                txtresu.Text += "capres, ";
            }
            if (chkjambon.Checked)
            {
                txtresu.Text += "jambon, ";
            }
            if (chkcrevettes.Checked)
            {
                txtresu.Text += "crevettes, ";
            }
            if(txtresu.Text != "")
            {
                txtresu.Text = txtresu.Text.Substring(0, txtresu.Text.Length - 2);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
