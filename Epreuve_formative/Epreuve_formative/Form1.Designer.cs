namespace Epreuve_formative
{
    partial class frmCourses
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cboArticle = new System.Windows.Forms.ComboBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(119, 65);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(25, 20);
            this.txtQuantite.TabIndex = 0;
            this.txtQuantite.TextChanged += new System.EventHandler(this.txtQuantite_TextChanged);
            // 
            // cboArticle
            // 
            this.cboArticle.FormattingEnabled = true;
            this.cboArticle.Location = new System.Drawing.Point(162, 64);
            this.cboArticle.Name = "cboArticle";
            this.cboArticle.Size = new System.Drawing.Size(121, 21);
            this.cboArticle.TabIndex = 1;
            this.cboArticle.SelectedIndexChanged += new System.EventHandler(this.cboArticle_SelectedIndexChanged);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(119, 101);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(164, 23);
            this.cmdAjouter.TabIndex = 2;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Items.AddRange(new object[] {
            "Lait: 6",
            "Pain: 1",
            "Viande: 750"});
            this.lstCourses.Location = new System.Drawing.Point(119, 143);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(164, 108);
            this.lstCourses.TabIndex = 3;
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(119, 278);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(164, 23);
            this.cmdSupprimer.TabIndex = 4;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.Location = new System.Drawing.Point(119, 319);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.Size = new System.Drawing.Size(164, 23);
            this.cmdImprimer.TabIndex = 5;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 448);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.cboArticle);
            this.Controls.Add(this.txtQuantite);
            this.Name = "frmCourses";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cboArticle;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdImprimer;
    }
}

