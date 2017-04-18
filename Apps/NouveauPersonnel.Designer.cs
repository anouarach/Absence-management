namespace Apps
{
    partial class NouveauPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NouveauPersonnel));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnReduire = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.lblCIN = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrénom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConfirmationMdp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.comboFonction = new System.Windows.Forms.ComboBox();
            this.comboSexe = new System.Windows.Forms.ComboBox();
            this.txtDN = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.panelHeader.TabIndex = 19;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // btnReduire
            // 
            this.btnReduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduire.ForeColor = System.Drawing.Color.Transparent;
            this.btnReduire.Location = new System.Drawing.Point(419, 13);
            this.btnReduire.Name = "btnReduire";
            this.btnReduire.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnReduire.Size = new System.Drawing.Size(25, 25);
            this.btnReduire.TabIndex = 6;
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
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "X";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("PT Sans Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitre.Location = new System.Drawing.Point(25, 15);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(130, 19);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "NOUVEAU PERSONNEL";
            // 
            // txtCin
            // 
            this.txtCin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCin.Location = new System.Drawing.Point(202, 84);
            this.txtCin.MaxLength = 100;
            this.txtCin.Multiline = true;
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(250, 30);
            this.txtCin.TabIndex = 26;
            // 
            // lblCIN
            // 
            this.lblCIN.AutoSize = true;
            this.lblCIN.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCIN.Location = new System.Drawing.Point(51, 90);
            this.lblCIN.Name = "lblCIN";
            this.lblCIN.Size = new System.Drawing.Size(32, 18);
            this.lblCIN.TabIndex = 25;
            this.lblCIN.Text = "&CIN :";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNom.Location = new System.Drawing.Point(202, 127);
            this.txtNom.MaxLength = 100;
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(250, 30);
            this.txtNom.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(50, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "&Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(50, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "&Date de naissance :";
            // 
            // txtPrénom
            // 
            this.txtPrénom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrénom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrénom.Location = new System.Drawing.Point(202, 170);
            this.txtPrénom.MaxLength = 100;
            this.txtPrénom.Multiline = true;
            this.txtPrénom.Name = "txtPrénom";
            this.txtPrénom.Size = new System.Drawing.Size(250, 30);
            this.txtPrénom.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(51, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "&Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(50, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 39;
            this.label4.Text = "&Fonction :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdresse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAdresse.Location = new System.Drawing.Point(202, 340);
            this.txtAdresse.MaxLength = 100;
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(250, 100);
            this.txtAdresse.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(51, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "&Adresse :";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelephone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTelephone.Location = new System.Drawing.Point(202, 297);
            this.txtTelephone.MaxLength = 100;
            this.txtTelephone.Multiline = true;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(250, 30);
            this.txtTelephone.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(50, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "&Téléphone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(51, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "&Sexe :";
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMdp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMdp.Location = new System.Drawing.Point(202, 580);
            this.txtMdp.MaxLength = 100;
            this.txtMdp.Multiline = true;
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '•';
            this.txtMdp.Size = new System.Drawing.Size(250, 30);
            this.txtMdp.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(48, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "&Mot de passe :";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLogin.Location = new System.Drawing.Point(202, 537);
            this.txtLogin.MaxLength = 100;
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(250, 30);
            this.txtLogin.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(49, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "&Login :";
            // 
            // txtConfirmationMdp
            // 
            this.txtConfirmationMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmationMdp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtConfirmationMdp.Location = new System.Drawing.Point(202, 623);
            this.txtConfirmationMdp.MaxLength = 100;
            this.txtConfirmationMdp.Multiline = true;
            this.txtConfirmationMdp.Name = "txtConfirmationMdp";
            this.txtConfirmationMdp.PasswordChar = '•';
            this.txtConfirmationMdp.Size = new System.Drawing.Size(250, 30);
            this.txtConfirmationMdp.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(48, 632);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 18);
            this.label10.TabIndex = 45;
            this.label10.Text = "&Confirmer le mot de passe :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(68)))), ((int)(((byte)(112)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnuler.Location = new System.Drawing.Point(255, 680);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(170, 35);
            this.btnAnnuler.TabIndex = 48;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(68)))), ((int)(((byte)(112)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAjouter.Location = new System.Drawing.Point(75, 680);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(170, 35);
            this.btnAjouter.TabIndex = 47;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // comboFonction
            // 
            this.comboFonction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFonction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboFonction.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comboFonction.FormattingEnabled = true;
            this.comboFonction.Items.AddRange(new object[] {
            "Employé",
            "Reponsable"});
            this.comboFonction.Location = new System.Drawing.Point(202, 453);
            this.comboFonction.Name = "comboFonction";
            this.comboFonction.Size = new System.Drawing.Size(250, 28);
            this.comboFonction.TabIndex = 49;
            // 
            // comboSexe
            // 
            this.comboSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSexe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comboSexe.FormattingEnabled = true;
            this.comboSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.comboSexe.Location = new System.Drawing.Point(202, 256);
            this.comboSexe.Name = "comboSexe";
            this.comboSexe.Size = new System.Drawing.Size(250, 28);
            this.comboSexe.TabIndex = 50;
            // 
            // txtDN
            // 
            this.txtDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDN.Location = new System.Drawing.Point(202, 213);
            this.txtDN.Mask = "00/00/0000";
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(250, 26);
            this.txtDN.TabIndex = 51;
            this.txtDN.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(202, 493);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 30);
            this.txtEmail.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label11.Location = new System.Drawing.Point(49, 502);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 18);
            this.label11.TabIndex = 52;
            this.label11.Text = "&Adresse Email :";
            // 
            // NouveauPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(500, 740);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDN);
            this.Controls.Add(this.comboSexe);
            this.Controls.Add(this.comboFonction);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtConfirmationMdp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrénom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCin);
            this.Controls.Add(this.lblCIN);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NouveauPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NouveauPersonnel";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnReduire;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtCin;
        private System.Windows.Forms.Label lblCIN;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrénom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtConfirmationMdp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox comboFonction;
        private System.Windows.Forms.ComboBox comboSexe;
        private System.Windows.Forms.MaskedTextBox txtDN;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
    }
}