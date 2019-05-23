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
        int dep;
        int color;
        public Fenetre()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            color++;
            this.BackColor = Color.Blue;
        }

        private void butrouge_Click(object sender, EventArgs e)
        {
            color++;
            this.BackColor = Color.Red;
        }

        private void butHG_Click(object sender, EventArgs e)
        {
            dep++;
            this.Location = new Point(0,0);
        }

        private void butBG_Click(object sender, EventArgs e)
        {
            dep++;
            this.Location = new Point(0, Screen.GetBounds(this).Height-this.Height);
        }

        private void butHD_Click(object sender, EventArgs e)
        {
            dep++;
            this.Location = new Point(Screen.GetBounds(this).Width-this.Width);
        }

        private void butBD_Click(object sender, EventArgs e)
        {
            dep++;
            this.Location = new Point(Screen.GetBounds(this).Width - this.Width, Screen.GetBounds(this).Height - this.Height);
        }

        private void butstats_Click(object sender, EventArgs e)
        { 
            MessageBox.Show( dep + "  déplacement(s), "+ color + "  changement(s) de couleur.");
        }
    }
}
