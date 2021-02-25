namespace Convertisseur_MVC
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
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblMonnaie = new System.Windows.Forms.Label();
            this.lblConverssion = new System.Windows.Forms.Label();
            this.tbxMontant = new System.Windows.Forms.TextBox();
            this.cbxMonnaie = new System.Windows.Forms.ComboBox();
            this.cbxConverssion = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(12, 42);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(59, 17);
            this.lblMontant.TabIndex = 0;
            this.lblMontant.Text = "Montant";
            // 
            // lblMonnaie
            // 
            this.lblMonnaie.AutoSize = true;
            this.lblMonnaie.Location = new System.Drawing.Point(12, 89);
            this.lblMonnaie.Name = "lblMonnaie";
            this.lblMonnaie.Size = new System.Drawing.Size(121, 17);
            this.lblMonnaie.TabIndex = 1;
            this.lblMonnaie.Text = "Monnaie de base ";
            // 
            // lblConverssion
            // 
            this.lblConverssion.AutoSize = true;
            this.lblConverssion.Location = new System.Drawing.Point(12, 138);
            this.lblConverssion.Name = "lblConverssion";
            this.lblConverssion.Size = new System.Drawing.Size(85, 17);
            this.lblConverssion.TabIndex = 2;
            this.lblConverssion.Text = "Convertir en";
            // 
            // tbxMontant
            // 
            this.tbxMontant.Location = new System.Drawing.Point(152, 39);
            this.tbxMontant.Name = "tbxMontant";
            this.tbxMontant.Size = new System.Drawing.Size(154, 22);
            this.tbxMontant.TabIndex = 3;
            // 
            // cbxMonnaie
            // 
            this.cbxMonnaie.FormattingEnabled = true;
            this.cbxMonnaie.Location = new System.Drawing.Point(152, 86);
            this.cbxMonnaie.Name = "cbxMonnaie";
            this.cbxMonnaie.Size = new System.Drawing.Size(154, 24);
            this.cbxMonnaie.TabIndex = 4;
            // 
            // cbxConverssion
            // 
            this.cbxConverssion.FormattingEnabled = true;
            this.cbxConverssion.Location = new System.Drawing.Point(152, 135);
            this.cbxConverssion.Name = "cbxConverssion";
            this.cbxConverssion.Size = new System.Drawing.Size(154, 24);
            this.cbxConverssion.TabIndex = 5;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(95, 188);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(154, 23);
            this.btnConvertir.TabIndex = 6;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // tbxResultat
            // 
            this.tbxResultat.Location = new System.Drawing.Point(15, 228);
            this.tbxResultat.Multiline = true;
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.Size = new System.Drawing.Size(291, 100);
            this.tbxResultat.TabIndex = 7;
            this.tbxResultat.Text = "Resultat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 346);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cbxConverssion);
            this.Controls.Add(this.cbxMonnaie);
            this.Controls.Add(this.tbxMontant);
            this.Controls.Add(this.lblConverssion);
            this.Controls.Add(this.lblMonnaie);
            this.Controls.Add(this.lblMontant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblMonnaie;
        private System.Windows.Forms.Label lblConverssion;
        private System.Windows.Forms.TextBox tbxMontant;
        private System.Windows.Forms.ComboBox cbxMonnaie;
        private System.Windows.Forms.ComboBox cbxConverssion;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox tbxResultat;
    }
}

