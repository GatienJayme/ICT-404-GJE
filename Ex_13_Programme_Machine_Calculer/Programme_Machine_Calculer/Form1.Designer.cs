namespace Programme_Machine_Calculer
{
    partial class form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butAdditionner = new System.Windows.Forms.Button();
            this.butDiviser = new System.Windows.Forms.Button();
            this.butmultiplier = new System.Windows.Forms.Button();
            this.butSoustraire = new System.Windows.Forms.Button();
            this.butEgale = new System.Windows.Forms.Button();
            this.txtChiffre = new System.Windows.Forms.TextBox();
            this.txtResultats = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResultats);
            this.groupBox1.Controls.Add(this.txtChiffre);
            this.groupBox1.Controls.Add(this.butEgale);
            this.groupBox1.Controls.Add(this.butDiviser);
            this.groupBox1.Controls.Add(this.butmultiplier);
            this.groupBox1.Controls.Add(this.butSoustraire);
            this.groupBox1.Controls.Add(this.butAdditionner);
            this.groupBox1.Location = new System.Drawing.Point(215, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculette";
            // 
            // butAdditionner
            // 
            this.butAdditionner.Location = new System.Drawing.Point(6, 57);
            this.butAdditionner.Name = "butAdditionner";
            this.butAdditionner.Size = new System.Drawing.Size(27, 23);
            this.butAdditionner.TabIndex = 0;
            this.butAdditionner.Text = "+";
            this.butAdditionner.UseVisualStyleBackColor = true;
            // 
            // butDiviser
            // 
            this.butDiviser.Location = new System.Drawing.Point(39, 86);
            this.butDiviser.Name = "butDiviser";
            this.butDiviser.Size = new System.Drawing.Size(27, 23);
            this.butDiviser.TabIndex = 1;
            this.butDiviser.Text = "/";
            this.butDiviser.UseVisualStyleBackColor = true;
            // 
            // butmultiplier
            // 
            this.butmultiplier.Location = new System.Drawing.Point(6, 86);
            this.butmultiplier.Name = "butmultiplier";
            this.butmultiplier.Size = new System.Drawing.Size(27, 23);
            this.butmultiplier.TabIndex = 2;
            this.butmultiplier.Text = "*";
            this.butmultiplier.UseVisualStyleBackColor = true;
            // 
            // butSoustraire
            // 
            this.butSoustraire.Location = new System.Drawing.Point(39, 57);
            this.butSoustraire.Name = "butSoustraire";
            this.butSoustraire.Size = new System.Drawing.Size(27, 23);
            this.butSoustraire.TabIndex = 3;
            this.butSoustraire.Text = "-";
            this.butSoustraire.UseVisualStyleBackColor = true;
            // 
            // butEgale
            // 
            this.butEgale.Location = new System.Drawing.Point(6, 115);
            this.butEgale.Name = "butEgale";
            this.butEgale.Size = new System.Drawing.Size(27, 23);
            this.butEgale.TabIndex = 4;
            this.butEgale.Text = "=";
            this.butEgale.UseVisualStyleBackColor = true;
            // 
            // txtChiffre
            // 
            this.txtChiffre.Location = new System.Drawing.Point(6, 19);
            this.txtChiffre.Name = "txtChiffre";
            this.txtChiffre.Size = new System.Drawing.Size(79, 20);
            this.txtChiffre.TabIndex = 1;
            // 
            // txtResultats
            // 
            this.txtResultats.Location = new System.Drawing.Point(39, 117);
            this.txtResultats.Name = "txtResultats";
            this.txtResultats.Size = new System.Drawing.Size(46, 20);
            this.txtResultats.TabIndex = 2;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 456);
            this.Controls.Add(this.groupBox1);
            this.Name = "form1";
            this.Text = "Machine à Calculer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butEgale;
        private System.Windows.Forms.Button butDiviser;
        private System.Windows.Forms.Button butmultiplier;
        private System.Windows.Forms.Button butSoustraire;
        private System.Windows.Forms.Button butAdditionner;
        private System.Windows.Forms.TextBox txtResultats;
        private System.Windows.Forms.TextBox txtChiffre;
    }
}

