using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epreuve_formative
{
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(215, 415);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantite_TextChanged(object sender, EventArgs e)
        {
            txtQuantite.Location = new Point(25, 25);
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            cmdAjouter.Location = new Point(25, 25);
        }

        private void cboArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboArticle.Location = new Point(5,25);
        }
    }
}
