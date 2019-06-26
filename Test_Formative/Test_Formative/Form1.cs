// Program: Test Formative
// Author: Gatien Jayme
// Date: 26.06.2019
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Formative
{
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {

        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            // Demande de sélectionnez un article
            float quantite; // Déclaration de la variable pour tester si c'est un chiffre
            if (cboArticle.Text == "")
            {
                MessageBox.Show("Sélectionnez un article");
            }
            // Demande d'introduire une quantite donc des chiffres et non des lettres
            else if (txtQuantite.Text == "" || !float.TryParse(txtQuantite.Text, out quantite))
            {
                MessageBox.Show("Introduisez une quantite");
                return;
            }
            // Ajouter les differents items demande par l'utilisateurs
            else
            {
                lstCourses.Items.Add(String.Format("{0} : {1}", cboArticle.Text, txtQuantite.Text));
                // faire un clean après avoir ajouté
                cboArticle.Text = "";
                txtQuantite.Text = "";
            }
        }

        private void cmdImprimer_Click(object sender, EventArgs e)
            // Fonction pour imprimer et affichage du message
        {
            MessageBox.Show("Cette fonction n'est pas encore disponible");
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
            // Si pas d'items selectionnez en demande de selectionner un
        {
            if (lstCourses.Text == "")
            {
                MessageBox.Show("Selectionnez un article a supprimer");
            }
            // items sélectionner supprimer
            lstCourses.Items.Remove(lstCourses.Text);
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
