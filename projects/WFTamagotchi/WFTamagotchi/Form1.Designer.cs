namespace WFTamagotchi
{
    partial class frm1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEtat = new System.Windows.Forms.Label();
            this.btnManger = new System.Windows.Forms.Button();
            this.pgrbCalorie = new System.Windows.Forms.ProgressBar();
            this.pgrbLiquide = new System.Windows.Forms.ProgressBar();
            this.pgrbVirus = new System.Windows.Forms.ProgressBar();
            this.pgrbFatigue = new System.Windows.Forms.ProgressBar();
            this.btnBoire = new System.Windows.Forms.Button();
            this.btnSoigner = new System.Windows.Forms.Button();
            this.btnDormir = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lblCalorie = new System.Windows.Forms.Label();
            this.lblFatigue = new System.Windows.Forms.Label();
            this.lblVirus = new System.Windows.Forms.Label();
            this.lblLiquide = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxDead = new System.Windows.Forms.TextBox();
            this.lblMechant = new System.Windows.Forms.Label();
            this.pgrbMechant = new System.Windows.Forms.ProgressBar();
            this.btnPunir = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.btnCalinou = new System.Windows.Forms.Button();
            this.btnTamagotchi1 = new System.Windows.Forms.Button();
            this.btnTamagotchi4 = new System.Windows.Forms.Button();
            this.btnTamagotchi3 = new System.Windows.Forms.Button();
            this.btnTamagotchi2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(25, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 34);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nom";
            // 
            // lblEtat
            // 
            this.lblEtat.AutoSize = true;
            this.lblEtat.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtat.Location = new System.Drawing.Point(25, 358);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Size = new System.Drawing.Size(59, 34);
            this.lblEtat.TabIndex = 1;
            this.lblEtat.Text = "Etat";
            // 
            // btnManger
            // 
            this.btnManger.Location = new System.Drawing.Point(239, 344);
            this.btnManger.Name = "btnManger";
            this.btnManger.Size = new System.Drawing.Size(70, 39);
            this.btnManger.TabIndex = 2;
            this.btnManger.Text = "Manger";
            this.btnManger.UseVisualStyleBackColor = true;
            this.btnManger.Click += new System.EventHandler(this.btnManger_Click);
            // 
            // pgrbCalorie
            // 
            this.pgrbCalorie.Location = new System.Drawing.Point(334, 34);
            this.pgrbCalorie.Name = "pgrbCalorie";
            this.pgrbCalorie.Size = new System.Drawing.Size(294, 20);
            this.pgrbCalorie.TabIndex = 3;
            // 
            // pgrbLiquide
            // 
            this.pgrbLiquide.Location = new System.Drawing.Point(334, 94);
            this.pgrbLiquide.Name = "pgrbLiquide";
            this.pgrbLiquide.Size = new System.Drawing.Size(294, 20);
            this.pgrbLiquide.TabIndex = 4;
            // 
            // pgrbVirus
            // 
            this.pgrbVirus.ForeColor = System.Drawing.Color.Red;
            this.pgrbVirus.Location = new System.Drawing.Point(334, 150);
            this.pgrbVirus.Name = "pgrbVirus";
            this.pgrbVirus.Size = new System.Drawing.Size(294, 20);
            this.pgrbVirus.TabIndex = 5;
            // 
            // pgrbFatigue
            // 
            this.pgrbFatigue.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pgrbFatigue.ForeColor = System.Drawing.Color.Red;
            this.pgrbFatigue.Location = new System.Drawing.Point(334, 211);
            this.pgrbFatigue.Name = "pgrbFatigue";
            this.pgrbFatigue.Size = new System.Drawing.Size(294, 20);
            this.pgrbFatigue.TabIndex = 6;
            this.pgrbFatigue.UseWaitCursor = true;
            // 
            // btnBoire
            // 
            this.btnBoire.Location = new System.Drawing.Point(325, 344);
            this.btnBoire.Name = "btnBoire";
            this.btnBoire.Size = new System.Drawing.Size(70, 39);
            this.btnBoire.TabIndex = 7;
            this.btnBoire.Text = "Boire";
            this.btnBoire.UseVisualStyleBackColor = true;
            this.btnBoire.Click += new System.EventHandler(this.btnBoire_Click);
            // 
            // btnSoigner
            // 
            this.btnSoigner.Location = new System.Drawing.Point(417, 344);
            this.btnSoigner.Name = "btnSoigner";
            this.btnSoigner.Size = new System.Drawing.Size(70, 39);
            this.btnSoigner.TabIndex = 8;
            this.btnSoigner.Text = "Soigner";
            this.btnSoigner.UseVisualStyleBackColor = true;
            this.btnSoigner.Click += new System.EventHandler(this.btnSoigner_Click);
            // 
            // btnDormir
            // 
            this.btnDormir.Location = new System.Drawing.Point(504, 344);
            this.btnDormir.Name = "btnDormir";
            this.btnDormir.Size = new System.Drawing.Size(70, 39);
            this.btnDormir.TabIndex = 9;
            this.btnDormir.Text = "Dormir";
            this.btnDormir.UseVisualStyleBackColor = true;
            this.btnDormir.Click += new System.EventHandler(this.btnDormir_Click);
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Interval = 500;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lblCalorie
            // 
            this.lblCalorie.AutoSize = true;
            this.lblCalorie.Location = new System.Drawing.Point(257, 37);
            this.lblCalorie.Name = "lblCalorie";
            this.lblCalorie.Size = new System.Drawing.Size(52, 17);
            this.lblCalorie.TabIndex = 10;
            this.lblCalorie.Text = "Calorie";
            // 
            // lblFatigue
            // 
            this.lblFatigue.AutoSize = true;
            this.lblFatigue.Location = new System.Drawing.Point(245, 211);
            this.lblFatigue.Name = "lblFatigue";
            this.lblFatigue.Size = new System.Drawing.Size(55, 17);
            this.lblFatigue.TabIndex = 11;
            this.lblFatigue.Text = "Fatigue";
            // 
            // lblVirus
            // 
            this.lblVirus.AutoSize = true;
            this.lblVirus.Location = new System.Drawing.Point(260, 150);
            this.lblVirus.Name = "lblVirus";
            this.lblVirus.Size = new System.Drawing.Size(40, 17);
            this.lblVirus.TabIndex = 12;
            this.lblVirus.Text = "Virus";
            // 
            // lblLiquide
            // 
            this.lblLiquide.AutoSize = true;
            this.lblLiquide.Location = new System.Drawing.Point(255, 94);
            this.lblLiquide.Name = "lblLiquide";
            this.lblLiquide.Size = new System.Drawing.Size(54, 17);
            this.lblLiquide.TabIndex = 13;
            this.lblLiquide.Text = "Liquide";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFTamagotchi.Properties.Resources.Michael_Myers;
            this.pictureBox1.Location = new System.Drawing.Point(31, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tbxDead
            // 
            this.tbxDead.BackColor = System.Drawing.Color.Black;
            this.tbxDead.Font = new System.Drawing.Font("Mistral", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDead.ForeColor = System.Drawing.Color.Red;
            this.tbxDead.Location = new System.Drawing.Point(195, 389);
            this.tbxDead.Multiline = true;
            this.tbxDead.Name = "tbxDead";
            this.tbxDead.ReadOnly = true;
            this.tbxDead.Size = new System.Drawing.Size(545, 52);
            this.tbxDead.TabIndex = 15;
            this.tbxDead.Text = "YOU\'RE DEAD";
            this.tbxDead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxDead.Visible = false;
            this.tbxDead.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMechant
            // 
            this.lblMechant.AutoSize = true;
            this.lblMechant.Location = new System.Drawing.Point(238, 262);
            this.lblMechant.Name = "lblMechant";
            this.lblMechant.Size = new System.Drawing.Size(62, 17);
            this.lblMechant.TabIndex = 16;
            this.lblMechant.Text = "Méchant";
            // 
            // pgrbMechant
            // 
            this.pgrbMechant.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pgrbMechant.ForeColor = System.Drawing.Color.Red;
            this.pgrbMechant.Location = new System.Drawing.Point(334, 262);
            this.pgrbMechant.Name = "pgrbMechant";
            this.pgrbMechant.Size = new System.Drawing.Size(294, 20);
            this.pgrbMechant.TabIndex = 17;
            this.pgrbMechant.UseWaitCursor = true;
            // 
            // btnPunir
            // 
            this.btnPunir.Location = new System.Drawing.Point(597, 344);
            this.btnPunir.Name = "btnPunir";
            this.btnPunir.Size = new System.Drawing.Size(70, 39);
            this.btnPunir.TabIndex = 18;
            this.btnPunir.Text = "Punir";
            this.btnPunir.UseVisualStyleBackColor = true;
            this.btnPunir.Click += new System.EventHandler(this.btnPunir_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(656, 18);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(72, 36);
            this.lblTest.TabIndex = 19;
            this.lblTest.Text = "Test";
            // 
            // btnCalinou
            // 
            this.btnCalinou.Location = new System.Drawing.Point(597, 344);
            this.btnCalinou.Name = "btnCalinou";
            this.btnCalinou.Size = new System.Drawing.Size(70, 39);
            this.btnCalinou.TabIndex = 20;
            this.btnCalinou.Text = "Calinou";
            this.btnCalinou.UseVisualStyleBackColor = true;
            this.btnCalinou.Click += new System.EventHandler(this.btnCalinou_Click);
            // 
            // btnTamagotchi1
            // 
            this.btnTamagotchi1.Location = new System.Drawing.Point(786, 83);
            this.btnTamagotchi1.Name = "btnTamagotchi1";
            this.btnTamagotchi1.Size = new System.Drawing.Size(115, 39);
            this.btnTamagotchi1.TabIndex = 22;
            this.btnTamagotchi1.Text = "Tamagotchi 1";
            this.btnTamagotchi1.UseVisualStyleBackColor = true;
            this.btnTamagotchi1.Click += new System.EventHandler(this.btnTamagotchi1_Click);
            // 
            // btnTamagotchi4
            // 
            this.btnTamagotchi4.Location = new System.Drawing.Point(786, 262);
            this.btnTamagotchi4.Name = "btnTamagotchi4";
            this.btnTamagotchi4.Size = new System.Drawing.Size(115, 39);
            this.btnTamagotchi4.TabIndex = 23;
            this.btnTamagotchi4.Text = "Tamagotchi 4";
            this.btnTamagotchi4.UseVisualStyleBackColor = true;
            this.btnTamagotchi4.Click += new System.EventHandler(this.btnTamagotchi4_Click);
            // 
            // btnTamagotchi3
            // 
            this.btnTamagotchi3.Location = new System.Drawing.Point(786, 200);
            this.btnTamagotchi3.Name = "btnTamagotchi3";
            this.btnTamagotchi3.Size = new System.Drawing.Size(115, 39);
            this.btnTamagotchi3.TabIndex = 24;
            this.btnTamagotchi3.Text = "Tamagotchi 3";
            this.btnTamagotchi3.UseVisualStyleBackColor = true;
            this.btnTamagotchi3.Click += new System.EventHandler(this.btnTamagotchi3_Click);
            // 
            // btnTamagotchi2
            // 
            this.btnTamagotchi2.Location = new System.Drawing.Point(786, 139);
            this.btnTamagotchi2.Name = "btnTamagotchi2";
            this.btnTamagotchi2.Size = new System.Drawing.Size(115, 39);
            this.btnTamagotchi2.TabIndex = 25;
            this.btnTamagotchi2.Text = "Tamagotchi 2";
            this.btnTamagotchi2.UseVisualStyleBackColor = true;
            this.btnTamagotchi2.Click += new System.EventHandler(this.btnTamagotchi2_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.btnTamagotchi2);
            this.Controls.Add(this.btnTamagotchi3);
            this.Controls.Add(this.btnTamagotchi4);
            this.Controls.Add(this.btnTamagotchi1);
            this.Controls.Add(this.btnCalinou);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnPunir);
            this.Controls.Add(this.pgrbMechant);
            this.Controls.Add(this.lblMechant);
            this.Controls.Add(this.tbxDead);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLiquide);
            this.Controls.Add(this.lblVirus);
            this.Controls.Add(this.lblFatigue);
            this.Controls.Add(this.lblCalorie);
            this.Controls.Add(this.btnDormir);
            this.Controls.Add(this.btnSoigner);
            this.Controls.Add(this.btnBoire);
            this.Controls.Add(this.pgrbFatigue);
            this.Controls.Add(this.pgrbVirus);
            this.Controls.Add(this.pgrbLiquide);
            this.Controls.Add(this.pgrbCalorie);
            this.Controls.Add(this.btnManger);
            this.Controls.Add(this.lblEtat);
            this.Controls.Add(this.lblName);
            this.Name = "frm1";
            this.Text = "Tamagotchi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEtat;
        private System.Windows.Forms.Button btnManger;
        private System.Windows.Forms.ProgressBar pgrbCalorie;
        private System.Windows.Forms.ProgressBar pgrbLiquide;
        private System.Windows.Forms.ProgressBar pgrbVirus;
        private System.Windows.Forms.ProgressBar pgrbFatigue;
        private System.Windows.Forms.Button btnBoire;
        private System.Windows.Forms.Button btnSoigner;
        private System.Windows.Forms.Button btnDormir;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label lblCalorie;
        private System.Windows.Forms.Label lblFatigue;
        private System.Windows.Forms.Label lblVirus;
        private System.Windows.Forms.Label lblLiquide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxDead;
        private System.Windows.Forms.Label lblMechant;
        private System.Windows.Forms.ProgressBar pgrbMechant;
        private System.Windows.Forms.Button btnPunir;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnCalinou;
        private System.Windows.Forms.Button btnTamagotchi1;
        private System.Windows.Forms.Button btnTamagotchi4;
        private System.Windows.Forms.Button btnTamagotchi3;
        private System.Windows.Forms.Button btnTamagotchi2;
    }
}

