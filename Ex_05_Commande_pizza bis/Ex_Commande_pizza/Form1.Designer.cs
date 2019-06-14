namespace Ex_Commande_pizza
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
            this.txttable = new System.Windows.Forms.Label();
            this.txtbtable = new System.Windows.Forms.TextBox();
            this.txtpate = new System.Windows.Forms.Label();
            this.rbtextrafine = new System.Windows.Forms.RadioButton();
            this.rbtfine = new System.Windows.Forms.RadioButton();
            this.rbtnormale = new System.Windows.Forms.RadioButton();
            this.rbtEppaisse = new System.Windows.Forms.RadioButton();
            this.chkanchois = new System.Windows.Forms.CheckBox();
            this.chkcapres = new System.Windows.Forms.CheckBox();
            this.chkjambon = new System.Windows.Forms.CheckBox();
            this.chkcrevettes = new System.Windows.Forms.CheckBox();
            this.butcommander = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblrépertoire = new System.Windows.Forms.Label();
            this.txtbrep = new System.Windows.Forms.TextBox();
            this.butchanger = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtMnormale = new System.Windows.Forms.RadioButton();
            this.rbtMmaigre = new System.Windows.Forms.RadioButton();
            this.rdbMBufflonne = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttable
            // 
            this.txttable.AutoSize = true;
            this.txttable.Location = new System.Drawing.Point(70, 30);
            this.txttable.Name = "txttable";
            this.txttable.Size = new System.Drawing.Size(34, 13);
            this.txttable.TabIndex = 0;
            this.txttable.Text = "Table";
            // 
            // txtbtable
            // 
            this.txtbtable.Location = new System.Drawing.Point(122, 27);
            this.txtbtable.Name = "txtbtable";
            this.txtbtable.Size = new System.Drawing.Size(35, 20);
            this.txtbtable.TabIndex = 1;
            this.txtbtable.Text = "3";
            this.txtbtable.TextChanged += new System.EventHandler(this.txtbtable_TextChanged);
            // 
            // txtpate
            // 
            this.txtpate.AutoSize = true;
            this.txtpate.Location = new System.Drawing.Point(6, 0);
            this.txtpate.Name = "txtpate";
            this.txtpate.Size = new System.Drawing.Size(29, 13);
            this.txtpate.TabIndex = 2;
            this.txtpate.Text = "Pâte";
            // 
            // rbtextrafine
            // 
            this.rbtextrafine.AutoSize = true;
            this.rbtextrafine.Location = new System.Drawing.Point(88, 96);
            this.rbtextrafine.Name = "rbtextrafine";
            this.rbtextrafine.Size = new System.Drawing.Size(69, 17);
            this.rbtextrafine.TabIndex = 3;
            this.rbtextrafine.TabStop = true;
            this.rbtextrafine.Text = "Extra-fine";
            this.rbtextrafine.UseVisualStyleBackColor = true;
            // 
            // rbtfine
            // 
            this.rbtfine.AutoSize = true;
            this.rbtfine.Location = new System.Drawing.Point(88, 119);
            this.rbtfine.Name = "rbtfine";
            this.rbtfine.Size = new System.Drawing.Size(45, 17);
            this.rbtfine.TabIndex = 4;
            this.rbtfine.TabStop = true;
            this.rbtfine.Text = "Fine";
            this.rbtfine.UseVisualStyleBackColor = true;
            // 
            // rbtnormale
            // 
            this.rbtnormale.AutoSize = true;
            this.rbtnormale.Location = new System.Drawing.Point(88, 142);
            this.rbtnormale.Name = "rbtnormale";
            this.rbtnormale.Size = new System.Drawing.Size(64, 17);
            this.rbtnormale.TabIndex = 5;
            this.rbtnormale.TabStop = true;
            this.rbtnormale.Text = "Normale";
            this.rbtnormale.UseVisualStyleBackColor = true;
            // 
            // rbtEppaisse
            // 
            this.rbtEppaisse.AutoSize = true;
            this.rbtEppaisse.Location = new System.Drawing.Point(88, 165);
            this.rbtEppaisse.Name = "rbtEppaisse";
            this.rbtEppaisse.Size = new System.Drawing.Size(62, 17);
            this.rbtEppaisse.TabIndex = 6;
            this.rbtEppaisse.TabStop = true;
            this.rbtEppaisse.Text = "Epaisse";
            this.rbtEppaisse.UseVisualStyleBackColor = true;
            // 
            // chkanchois
            // 
            this.chkanchois.AutoSize = true;
            this.chkanchois.Location = new System.Drawing.Point(358, 96);
            this.chkanchois.Name = "chkanchois";
            this.chkanchois.Size = new System.Drawing.Size(64, 17);
            this.chkanchois.TabIndex = 8;
            this.chkanchois.Text = "Anchois";
            this.chkanchois.UseVisualStyleBackColor = true;
            // 
            // chkcapres
            // 
            this.chkcapres.AutoSize = true;
            this.chkcapres.Location = new System.Drawing.Point(358, 120);
            this.chkcapres.Name = "chkcapres";
            this.chkcapres.Size = new System.Drawing.Size(59, 17);
            this.chkcapres.TabIndex = 9;
            this.chkcapres.Text = "Câpres";
            this.chkcapres.UseVisualStyleBackColor = true;
            // 
            // chkjambon
            // 
            this.chkjambon.AutoSize = true;
            this.chkjambon.Location = new System.Drawing.Point(358, 143);
            this.chkjambon.Name = "chkjambon";
            this.chkjambon.Size = new System.Drawing.Size(63, 17);
            this.chkjambon.TabIndex = 10;
            this.chkjambon.Text = "Jambon";
            this.chkjambon.UseVisualStyleBackColor = true;
            // 
            // chkcrevettes
            // 
            this.chkcrevettes.AutoSize = true;
            this.chkcrevettes.Location = new System.Drawing.Point(358, 166);
            this.chkcrevettes.Name = "chkcrevettes";
            this.chkcrevettes.Size = new System.Drawing.Size(71, 17);
            this.chkcrevettes.TabIndex = 11;
            this.chkcrevettes.Text = "Crevettes";
            this.chkcrevettes.UseVisualStyleBackColor = true;
            // 
            // butcommander
            // 
            this.butcommander.Location = new System.Drawing.Point(201, 226);
            this.butcommander.Name = "butcommander";
            this.butcommander.Size = new System.Drawing.Size(75, 23);
            this.butcommander.TabIndex = 12;
            this.butcommander.Text = "Commander";
            this.butcommander.UseVisualStyleBackColor = true;
            this.butcommander.Click += new System.EventHandler(this.butcommander_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpate);
            this.groupBox1.Location = new System.Drawing.Point(58, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 115);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblrépertoire
            // 
            this.lblrépertoire.AutoSize = true;
            this.lblrépertoire.Location = new System.Drawing.Point(203, 300);
            this.lblrépertoire.Name = "lblrépertoire";
            this.lblrépertoire.Size = new System.Drawing.Size(59, 13);
            this.lblrépertoire.TabIndex = 16;
            this.lblrépertoire.Text = "Répertoire:";
            // 
            // txtbrep
            // 
            this.txtbrep.Location = new System.Drawing.Point(274, 300);
            this.txtbrep.Name = "txtbrep";
            this.txtbrep.Size = new System.Drawing.Size(195, 20);
            this.txtbrep.TabIndex = 17;
            this.txtbrep.Text = "C:\\Data\\CoursCSharp";
            // 
            // butchanger
            // 
            this.butchanger.Location = new System.Drawing.Point(106, 295);
            this.butchanger.Name = "butchanger";
            this.butchanger.Size = new System.Drawing.Size(75, 23);
            this.butchanger.TabIndex = 18;
            this.butchanger.Text = "Changer";
            this.butchanger.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbMBufflonne);
            this.groupBox2.Controls.Add(this.rbtMmaigre);
            this.groupBox2.Controls.Add(this.rbtMnormale);
            this.groupBox2.Location = new System.Drawing.Point(227, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 115);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mozzarella";
            // 
            // rbtMnormale
            // 
            this.rbtMnormale.AutoSize = true;
            this.rbtMnormale.Location = new System.Drawing.Point(6, 25);
            this.rbtMnormale.Name = "rbtMnormale";
            this.rbtMnormale.Size = new System.Drawing.Size(64, 17);
            this.rbtMnormale.TabIndex = 4;
            this.rbtMnormale.TabStop = true;
            this.rbtMnormale.Text = "Nomrale";
            this.rbtMnormale.UseVisualStyleBackColor = true;
            // 
            // rbtMmaigre
            // 
            this.rbtMmaigre.AutoSize = true;
            this.rbtMmaigre.Location = new System.Drawing.Point(6, 49);
            this.rbtMmaigre.Name = "rbtMmaigre";
            this.rbtMmaigre.Size = new System.Drawing.Size(57, 17);
            this.rbtMmaigre.TabIndex = 5;
            this.rbtMmaigre.TabStop = true;
            this.rbtMmaigre.Text = "Maigre";
            this.rbtMmaigre.UseVisualStyleBackColor = true;
            // 
            // rdbMBufflonne
            // 
            this.rdbMBufflonne.AutoSize = true;
            this.rdbMBufflonne.Location = new System.Drawing.Point(6, 72);
            this.rdbMBufflonne.Name = "rdbMBufflonne";
            this.rdbMBufflonne.Size = new System.Drawing.Size(70, 17);
            this.rdbMBufflonne.TabIndex = 6;
            this.rdbMBufflonne.TabStop = true;
            this.rdbMBufflonne.Text = "Bufflonne";
            this.rdbMBufflonne.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 448);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.butchanger);
            this.Controls.Add(this.txtbrep);
            this.Controls.Add(this.lblrépertoire);
            this.Controls.Add(this.butcommander);
            this.Controls.Add(this.chkcrevettes);
            this.Controls.Add(this.chkjambon);
            this.Controls.Add(this.chkcapres);
            this.Controls.Add(this.chkanchois);
            this.Controls.Add(this.rbtEppaisse);
            this.Controls.Add(this.rbtnormale);
            this.Controls.Add(this.rbtfine);
            this.Controls.Add(this.rbtextrafine);
            this.Controls.Add(this.txtbtable);
            this.Controls.Add(this.txttable);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txttable;
        private System.Windows.Forms.TextBox txtbtable;
        private System.Windows.Forms.Label txtpate;
        private System.Windows.Forms.RadioButton rbtextrafine;
        private System.Windows.Forms.RadioButton rbtfine;
        private System.Windows.Forms.RadioButton rbtnormale;
        private System.Windows.Forms.RadioButton rbtEppaisse;
        private System.Windows.Forms.CheckBox chkanchois;
        private System.Windows.Forms.CheckBox chkcapres;
        private System.Windows.Forms.CheckBox chkjambon;
        private System.Windows.Forms.CheckBox chkcrevettes;
        private System.Windows.Forms.Button butcommander;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblrépertoire;
        private System.Windows.Forms.TextBox txtbrep;
        private System.Windows.Forms.Button butchanger;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbMBufflonne;
        private System.Windows.Forms.RadioButton rbtMmaigre;
        private System.Windows.Forms.RadioButton rbtMnormale;
    }
}

