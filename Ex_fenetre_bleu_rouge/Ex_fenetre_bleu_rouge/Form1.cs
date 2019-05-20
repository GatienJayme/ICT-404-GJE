using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_fenetre_bleu_rouge
{
    public partial class Fenetre : Form
    {
        public Fenetre()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void butrouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void butHG_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0,0);
        }

        private void butBG_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 550);
        }

        private void butHD_Click(object sender, EventArgs e)
        {
            this.Location = new Point(1285, 0);
        }

        private void butBD_Click(object sender, EventArgs e)
        {
            this.Location = new Point(1285, 550);
        }
    }
}
