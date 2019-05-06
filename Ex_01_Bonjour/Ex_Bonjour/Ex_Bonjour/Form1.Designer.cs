namespace Ex_Bonjour
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB = new System.Windows.Forms.TextBox();
            this.lblBienvenue = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(308, 157);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(100, 20);
            this.TB.TabIndex = 1;
            this.TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBienvenue
            // 
            this.lblBienvenue.Enabled = false;
            this.lblBienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenue.Location = new System.Drawing.Point(308, 214);
            this.lblBienvenue.Name = "lblBienvenue";
            this.lblBienvenue.Size = new System.Drawing.Size(100, 45);
            this.lblBienvenue.TabIndex = 2;
            this.lblBienvenue.Text = "Bienvenue";
            this.lblBienvenue.UseVisualStyleBackColor = true;
            this.lblBienvenue.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBienvenue);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bonjour Qui ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Button lblBienvenue;
        private System.Windows.Forms.Label label2;
    }
}

