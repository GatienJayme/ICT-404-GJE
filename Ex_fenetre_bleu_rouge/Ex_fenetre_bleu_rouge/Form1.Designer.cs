namespace Ex_fenetre_bleu_rouge
{
    partial class Fenetre
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
            this.butHG = new System.Windows.Forms.Button();
            this.butBG = new System.Windows.Forms.Button();
            this.butHD = new System.Windows.Forms.Button();
            this.butBD = new System.Windows.Forms.Button();
            this.butbleu = new System.Windows.Forms.Button();
            this.butrouge = new System.Windows.Forms.Button();
            this.butstats = new System.Windows.Forms.Button();
            this.butquitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butHG
            // 
            this.butHG.Location = new System.Drawing.Point(12, 12);
            this.butHG.Name = "butHG";
            this.butHG.Size = new System.Drawing.Size(124, 23);
            this.butHG.TabIndex = 0;
            this.butHG.Text = "Haut / Gauche";
            this.butHG.UseVisualStyleBackColor = true;
            this.butHG.Click += new System.EventHandler(this.butHG_Click);
            // 
            // butBG
            // 
            this.butBG.Location = new System.Drawing.Point(12, 415);
            this.butBG.Name = "butBG";
            this.butBG.Size = new System.Drawing.Size(111, 23);
            this.butBG.TabIndex = 1;
            this.butBG.Text = "Bas / Gauche";
            this.butBG.UseVisualStyleBackColor = true;
            this.butBG.Click += new System.EventHandler(this.butBG_Click);
            // 
            // butHD
            // 
            this.butHD.Location = new System.Drawing.Point(498, 12);
            this.butHD.Name = "butHD";
            this.butHD.Size = new System.Drawing.Size(117, 23);
            this.butHD.TabIndex = 2;
            this.butHD.Text = "Haut / Droite";
            this.butHD.UseVisualStyleBackColor = true;
            this.butHD.Click += new System.EventHandler(this.butHD_Click);
            // 
            // butBD
            // 
            this.butBD.Location = new System.Drawing.Point(517, 423);
            this.butBD.Name = "butBD";
            this.butBD.Size = new System.Drawing.Size(98, 23);
            this.butBD.TabIndex = 3;
            this.butBD.Text = "Bas / Droite";
            this.butBD.UseVisualStyleBackColor = true;
            this.butBD.Click += new System.EventHandler(this.butBD_Click);
            // 
            // butbleu
            // 
            this.butbleu.Location = new System.Drawing.Point(279, 98);
            this.butbleu.Name = "butbleu";
            this.butbleu.Size = new System.Drawing.Size(75, 23);
            this.butbleu.TabIndex = 4;
            this.butbleu.Text = "Bleu";
            this.butbleu.UseVisualStyleBackColor = true;
            this.butbleu.Click += new System.EventHandler(this.button5_Click);
            // 
            // butrouge
            // 
            this.butrouge.Location = new System.Drawing.Point(279, 153);
            this.butrouge.Name = "butrouge";
            this.butrouge.Size = new System.Drawing.Size(75, 23);
            this.butrouge.TabIndex = 5;
            this.butrouge.Text = "Rouge";
            this.butrouge.UseVisualStyleBackColor = true;
            this.butrouge.Click += new System.EventHandler(this.butrouge_Click);
            // 
            // butstats
            // 
            this.butstats.Location = new System.Drawing.Point(279, 251);
            this.butstats.Name = "butstats";
            this.butstats.Size = new System.Drawing.Size(75, 23);
            this.butstats.TabIndex = 6;
            this.butstats.Text = "Stats";
            this.butstats.UseVisualStyleBackColor = true;
            this.butstats.Click += new System.EventHandler(this.butstats_Click);
            // 
            // butquitter
            // 
            this.butquitter.Location = new System.Drawing.Point(279, 346);
            this.butquitter.Name = "butquitter";
            this.butquitter.Size = new System.Drawing.Size(75, 23);
            this.butquitter.TabIndex = 7;
            this.butquitter.Text = "Quitter";
            this.butquitter.UseVisualStyleBackColor = true;
            this.butquitter.Click += new System.EventHandler(this.button8_Click);
            // 
            // Fenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 458);
            this.Controls.Add(this.butquitter);
            this.Controls.Add(this.butstats);
            this.Controls.Add(this.butrouge);
            this.Controls.Add(this.butbleu);
            this.Controls.Add(this.butBD);
            this.Controls.Add(this.butHD);
            this.Controls.Add(this.butBG);
            this.Controls.Add(this.butHG);
            this.Name = "Fenetre";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butHG;
        private System.Windows.Forms.Button butBG;
        private System.Windows.Forms.Button butHD;
        private System.Windows.Forms.Button butBD;
        private System.Windows.Forms.Button butbleu;
        private System.Windows.Forms.Button butrouge;
        private System.Windows.Forms.Button butstats;
        private System.Windows.Forms.Button butquitter;
    }
}

