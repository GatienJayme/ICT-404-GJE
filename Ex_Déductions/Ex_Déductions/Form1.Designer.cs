namespace Ex_Déductions
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
            this.revenuea = new System.Windows.Forms.Label();
            this.coeff = new System.Windows.Forms.Label();
            this.revenui = new System.Windows.Forms.Label();
            this.dedj = new System.Windows.Forms.CheckBox();
            this.dedt = new System.Windows.Forms.CheckBox();
            this.rab = new System.Windows.Forms.CheckBox();
            this.cal = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // revenuea
            // 
            this.revenuea.AutoSize = true;
            this.revenuea.Location = new System.Drawing.Point(156, 196);
            this.revenuea.Name = "revenuea";
            this.revenuea.Size = new System.Drawing.Size(101, 13);
            this.revenuea.TabIndex = 0;
            this.revenuea.Text = "Revenu annuel brut";
            // 
            // coeff
            // 
            this.coeff.AutoSize = true;
            this.coeff.Location = new System.Drawing.Point(156, 238);
            this.coeff.Name = "coeff";
            this.coeff.Size = new System.Drawing.Size(91, 13);
            this.coeff.TabIndex = 5;
            this.coeff.Text = "Coefficient familial";
            // 
            // revenui
            // 
            this.revenui.AutoSize = true;
            this.revenui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenui.Location = new System.Drawing.Point(191, 443);
            this.revenui.Name = "revenui";
            this.revenui.Size = new System.Drawing.Size(138, 16);
            this.revenui.TabIndex = 8;
            this.revenui.Text = "Revenu imposable";
            this.revenui.Visible = false;
            // 
            // dedj
            // 
            this.dedj.AutoSize = true;
            this.dedj.Location = new System.Drawing.Point(182, 285);
            this.dedj.Name = "dedj";
            this.dedj.Size = new System.Drawing.Size(104, 17);
            this.dedj.TabIndex = 9;
            this.dedj.Text = "Déduction jeune";
            this.dedj.UseVisualStyleBackColor = true;
            // 
            // dedt
            // 
            this.dedt.AutoSize = true;
            this.dedt.Location = new System.Drawing.Point(182, 313);
            this.dedt.Name = "dedt";
            this.dedt.Size = new System.Drawing.Size(119, 17);
            this.dedt.TabIndex = 10;
            this.dedt.Text = "Déduction transport";
            this.dedt.UseVisualStyleBackColor = true;
            this.dedt.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // rab
            // 
            this.rab.AutoSize = true;
            this.rab.Location = new System.Drawing.Point(182, 339);
            this.rab.Name = "rab";
            this.rab.Size = new System.Drawing.Size(109, 17);
            this.rab.TabIndex = 11;
            this.rab.Text = "Rabais fidélité (%)";
            this.rab.UseVisualStyleBackColor = true;
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(267, 392);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 23);
            this.cal.TabIndex = 12;
            this.cal.Text = "Calcul";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(295, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(364, 229);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(52, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(364, 285);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(64, 21);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.Text = "900";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(364, 309);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(64, 21);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.Text = "650";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(364, 337);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(64, 21);
            this.comboBox5.TabIndex = 17;
            this.comboBox5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 614);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.rab);
            this.Controls.Add(this.dedt);
            this.Controls.Add(this.dedj);
            this.Controls.Add(this.revenui);
            this.Controls.Add(this.coeff);
            this.Controls.Add(this.revenuea);
            this.Name = "Form1";
            this.Text = "Déductions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label revenuea;
        private System.Windows.Forms.Label coeff;
        private System.Windows.Forms.Label revenui;
        private System.Windows.Forms.CheckBox dedj;
        private System.Windows.Forms.CheckBox dedt;
        private System.Windows.Forms.CheckBox rab;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}

