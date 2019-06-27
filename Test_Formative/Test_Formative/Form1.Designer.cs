namespace Test_Formative
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
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdImprimer = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cboArticle = new System.Windows.Forms.ComboBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(39, 74);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(166, 23);
            this.cmdAjouter.TabIndex = 0;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // cmdImprimer
            // 
            this.cmdImprimer.Location = new System.Drawing.Point(39, 329);
            this.cmdImprimer.Name = "cmdImprimer";
            this.cmdImprimer.Size = new System.Drawing.Size(166, 23);
            this.cmdImprimer.TabIndex = 1;
            this.cmdImprimer.Text = "Imprimer";
            this.cmdImprimer.UseVisualStyleBackColor = true;
            this.cmdImprimer.Click += new System.EventHandler(this.cmdImprimer_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(39, 300);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(166, 23);
            this.cmdSupprimer.TabIndex = 2;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cboArticle
            // 
            this.cboArticle.FormattingEnabled = true;
            this.cboArticle.Items.AddRange(new object[] {
            "Pain",
            "Beurre",
            "Lait",
            "Confiture",
            "Fromage",
            "Oeufs",
            "Farine",
            "Sucre",
            "Viande"});
            this.cboArticle.Location = new System.Drawing.Point(104, 38);
            this.cboArticle.Name = "cboArticle";
            this.cboArticle.Size = new System.Drawing.Size(101, 21);
            this.cboArticle.TabIndex = 3;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(39, 38);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(32, 20);
            this.txtQuantite.TabIndex = 4;
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Location = new System.Drawing.Point(39, 103);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(166, 186);
            this.lstCourses.TabIndex = 5;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 392);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.cboArticle);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdImprimer);
            this.Controls.Add(this.cmdAjouter);
            this.Name = "frmCourses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.frmCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdImprimer;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.ComboBox cboArticle;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.ListBox lstCourses;
    }
}

