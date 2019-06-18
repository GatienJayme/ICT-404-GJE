namespace timer
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
            this.components = new System.ComponentModel.Container();
            this.lblsecondes = new System.Windows.Forms.Label();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmdStartStop = new System.Windows.Forms.Button();
            this.lblminutes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsecondes
            // 
            this.lblsecondes.AutoSize = true;
            this.lblsecondes.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecondes.Location = new System.Drawing.Point(534, 152);
            this.lblsecondes.Name = "lblsecondes";
            this.lblsecondes.Size = new System.Drawing.Size(128, 44);
            this.lblsecondes.TabIndex = 0;
            this.lblsecondes.Text = "label1";
            // 
            // tmrTick
            // 
            this.tmrTick.Interval = 1000;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timer:";
            // 
            // cmdStartStop
            // 
            this.cmdStartStop.Location = new System.Drawing.Point(400, 283);
            this.cmdStartStop.Name = "cmdStartStop";
            this.cmdStartStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStartStop.TabIndex = 2;
            this.cmdStartStop.Text = "Start";
            this.cmdStartStop.UseVisualStyleBackColor = true;
            this.cmdStartStop.Click += new System.EventHandler(this.cmdStartStop_Click);
            // 
            // lblminutes
            // 
            this.lblminutes.AutoSize = true;
            this.lblminutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminutes.Location = new System.Drawing.Point(414, 152);
            this.lblminutes.Name = "lblminutes";
            this.lblminutes.Size = new System.Drawing.Size(128, 44);
            this.lblminutes.TabIndex = 3;
            this.lblminutes.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 447);
            this.Controls.Add(this.lblminutes);
            this.Controls.Add(this.cmdStartStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsecondes);
            this.Name = "Form1";
            this.Text = "Ballon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsecondes;
        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdStartStop;
        private System.Windows.Forms.Label lblminutes;
    }
}

