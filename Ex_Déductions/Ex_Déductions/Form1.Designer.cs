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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.revenuea = new System.Windows.Forms.Label();
            this.coeff = new System.Windows.Forms.Label();
            this.revenui = new System.Windows.Forms.Label();
            this.dedj = new System.Windows.Forms.CheckBox();
            this.dedt = new System.Windows.Forms.CheckBox();
            this.rab = new System.Windows.Forms.CheckBox();
            this.cal = new System.Windows.Forms.Button();
            this.txtBrut = new System.Windows.Forms.TextBox();
            this.txtDeducjeune = new System.Windows.Forms.TextBox();
            this.txtDeducTrsp = new System.Windows.Forms.TextBox();
            this.txtRabais = new System.Windows.Forms.TextBox();
            this.txtCoeff = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // revenuea
            // 
            resources.ApplyResources(this.revenuea, "revenuea");
            this.revenuea.Name = "revenuea";
            // 
            // coeff
            // 
            resources.ApplyResources(this.coeff, "coeff");
            this.coeff.Name = "coeff";
            // 
            // revenui
            // 
            resources.ApplyResources(this.revenui, "revenui");
            this.revenui.Name = "revenui";
            this.revenui.Click += new System.EventHandler(this.revenui_Click);
            // 
            // dedj
            // 
            resources.ApplyResources(this.dedj, "dedj");
            this.dedj.Name = "dedj";
            this.dedj.UseVisualStyleBackColor = true;
            // 
            // dedt
            // 
            resources.ApplyResources(this.dedt, "dedt");
            this.dedt.Name = "dedt";
            this.dedt.UseVisualStyleBackColor = true;
            this.dedt.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // rab
            // 
            resources.ApplyResources(this.rab, "rab");
            this.rab.Name = "rab";
            this.rab.UseVisualStyleBackColor = true;
            // 
            // cal
            // 
            resources.ApplyResources(this.cal, "cal");
            this.cal.Name = "cal";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBrut
            // 
            resources.ApplyResources(this.txtBrut, "txtBrut");
            this.txtBrut.Name = "txtBrut";
            // 
            // txtDeducjeune
            // 
            resources.ApplyResources(this.txtDeducjeune, "txtDeducjeune");
            this.txtDeducjeune.Name = "txtDeducjeune";
            // 
            // txtDeducTrsp
            // 
            resources.ApplyResources(this.txtDeducTrsp, "txtDeducTrsp");
            this.txtDeducTrsp.Name = "txtDeducTrsp";
            // 
            // txtRabais
            // 
            resources.ApplyResources(this.txtRabais, "txtRabais");
            this.txtRabais.Name = "txtRabais";
            // 
            // txtCoeff
            // 
            resources.ApplyResources(this.txtCoeff, "txtCoeff");
            this.txtCoeff.Name = "txtCoeff";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtRabais);
            this.Controls.Add(this.txtDeducTrsp);
            this.Controls.Add(this.txtDeducjeune);
            this.Controls.Add(this.txtCoeff);
            this.Controls.Add(this.txtBrut);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.rab);
            this.Controls.Add(this.dedt);
            this.Controls.Add(this.dedj);
            this.Controls.Add(this.revenui);
            this.Controls.Add(this.coeff);
            this.Controls.Add(this.revenuea);
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox txtBrut;
        private System.Windows.Forms.TextBox txtDeducjeune;
        private System.Windows.Forms.TextBox txtDeducTrsp;
        private System.Windows.Forms.TextBox txtRabais;
        private System.Windows.Forms.TextBox txtCoeff;
    }
}

