namespace Apps
{
    partial class Authentification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnReduire = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPasse = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPasse = new System.Windows.Forms.TextBox();
            this.radioPersonnel = new System.Windows.Forms.RadioButton();
            this.radioResponsable = new System.Windows.Forms.RadioButton();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.panelHeader.Controls.Add(this.btnReduire);
            this.panelHeader.Controls.Add(this.btnFermer);
            this.panelHeader.Controls.Add(this.lblTitre);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(500, 50);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // btnReduire
            // 
            this.btnReduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduire.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReduire.Location = new System.Drawing.Point(419, 13);
            this.btnReduire.Name = "btnReduire";
            this.btnReduire.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnReduire.Size = new System.Drawing.Size(25, 25);
            this.btnReduire.TabIndex = 2;
            this.btnReduire.Text = "_";
            this.btnReduire.UseVisualStyleBackColor = true;
            this.btnReduire.Click += new System.EventHandler(this.btnReduire_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFermer.Location = new System.Drawing.Point(450, 13);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnFermer.Size = new System.Drawing.Size(25, 25);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "X";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Myriad Web Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitre.Location = new System.Drawing.Point(25, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(140, 15);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "AUTHENTIFICATION";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(55, 90);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 16);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "&Login :";
            // 
            // lblPasse
            // 
            this.lblPasse.AutoSize = true;
            this.lblPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasse.Location = new System.Drawing.Point(55, 140);
            this.lblPasse.Name = "lblPasse";
            this.lblPasse.Size = new System.Drawing.Size(110, 16);
            this.lblPasse.TabIndex = 2;
            this.lblPasse.Text = "&Mot de passe :";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogin.Location = new System.Drawing.Point(195, 85);
            this.txtLogin.MaxLength = 26;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(250, 27);
            this.txtLogin.TabIndex = 3;
            // 
            // txtPasse
            // 
            this.txtPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPasse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPasse.Location = new System.Drawing.Point(195, 135);
            this.txtPasse.MaxLength = 16;
            this.txtPasse.Name = "txtPasse";
            this.txtPasse.PasswordChar = '•';
            this.txtPasse.Size = new System.Drawing.Size(250, 27);
            this.txtPasse.TabIndex = 4;
            // 
            // radioPersonnel
            // 
            this.radioPersonnel.AutoSize = true;
            this.radioPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPersonnel.Location = new System.Drawing.Point(195, 180);
            this.radioPersonnel.Name = "radioPersonnel";
            this.radioPersonnel.Size = new System.Drawing.Size(90, 19);
            this.radioPersonnel.TabIndex = 5;
            this.radioPersonnel.TabStop = true;
            this.radioPersonnel.Text = "&Personnel";
            this.radioPersonnel.UseVisualStyleBackColor = true;
            // 
            // radioResponsable
            // 
            this.radioResponsable.AutoSize = true;
            this.radioResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioResponsable.Location = new System.Drawing.Point(290, 180);
            this.radioResponsable.Name = "radioResponsable";
            this.radioResponsable.Size = new System.Drawing.Size(109, 19);
            this.radioResponsable.TabIndex = 6;
            this.radioResponsable.TabStop = true;
            this.radioResponsable.Text = "&Responsable";
            this.radioResponsable.UseVisualStyleBackColor = true;
            // 
            // btnConnexion
            // 
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(68)))), ((int)(((byte)(112)))));
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConnexion.Location = new System.Drawing.Point(75, 225);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(170, 35);
            this.btnConnexion.TabIndex = 7;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = false;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(68)))), ((int)(((byte)(112)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnuler.Location = new System.Drawing.Point(255, 225);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(170, 35);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(500, 290);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.radioResponsable);
            this.Controls.Add(this.radioPersonnel);
            this.Controls.Add(this.txtPasse);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPasse);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnReduire;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPasse;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPasse;
        private System.Windows.Forms.RadioButton radioPersonnel;
        private System.Windows.Forms.RadioButton radioResponsable;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnAnnuler;
    }
}