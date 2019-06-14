// program: ICT_404_commande_pizza_bis
// Author: Gatien Jayme
// Date: 06.06.2019
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
            
            MessageBox.Show("Commande envoyé");
        
            /*if (rbtEppaisse.Checked)
            {
                txtresu.Text += "épaisse";
            }*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
