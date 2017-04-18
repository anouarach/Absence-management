namespace Apps
{
    partial class AjouterDemande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterDemande));
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.checkConfirmation = new System.Windows.Forms.CheckBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSoumettre = new System.Windows.Forms.Button();
            this.comboConge = new System.Windows.Forms.ComboBox();
            this.txtDateDebut = new System.Windows.Forms.MaskedTextBox();
            this.txtDateFin = new System.Windows.Forms.MaskedTextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnReduire = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDateDebut.Location = new System.Drawing.Point(56, 140);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(84, 18);
            this.lblDateDebut.TabIndex = 6;
            this.lblDateDebut.Text = "&Date de debut :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblType.Location = new System.Drawing.Point(56, 90);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(86, 18);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "&Type de congé :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDateFin.Location = new System.Drawing.Point(56, 190);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(68, 18);
            this.lblDateFin.TabIndex = 9;
            this.lblDateFin.Text = "&Date de fin :";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCommentaire.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCommentaire.Location = new System.Drawing.Point(196, 235);
            this.txtCommentaire.MaxLength = 100;
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(250, 100);
            this.txtCommentaire.TabIndex = 12;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCommentaire.Location = new System.Drawing.Point(55, 240);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(80, 18);
            this.lblCommentaire.TabIndex = 11;
            this.lblCommentaire.Text = "&Commentaire :";
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblConfirmation.Location = new System.Drawing.Point(56, 360);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(77, 18);
            this.lblConfirmation.TabIndex = 13;
            this.lblConfirmation.Text = "&Confirmation :";
            // 
            // checkConfirmation
            // 
            this.checkConfirmation.AutoSize = true;
            this.checkConfirmation.Location = new System.Drawing.Point(196, 360);
            this.checkConfirmation.Name = "checkConfirmation";
            this.checkConfirmation.Size = new System.Drawing.Size(70, 17);
            this.checkConfirmation.TabIndex = 14;
            this.checkConfirmation.Text = "&Confirmer";
            this.checkConfirmation.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(68)))), ((int)(((byte)(112)))));
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAnnuler.Location = new System.Drawing.Point(255, 405);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(170, 35);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSoumettre
            // 
            this.btnSoumettre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(68)))), ((int)(((byte)(112)))));
            this.btnSoumettre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoumettre.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnSoumettre.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSoumettre.Location = new System.Drawing.Point(75, 405);
            this.btnSoumettre.Name = "btnSoumettre";
            this.btnSoumettre.Size = new System.Drawing.Size(170, 35);
            this.btnSoumettre.TabIndex = 15;
            this.btnSoumettre.Text = "Soumettre";
            this.btnSoumettre.UseVisualStyleBackColor = false;
            this.btnSoumettre.Click += new System.EventHandler(this.btnSoumettre_Click);
            // 
            // comboConge
            // 
            this.comboConge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboConge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboConge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.comboConge.FormattingEnabled = true;
            this.comboConge.Location = new System.Drawing.Point(196, 85);
            this.comboConge.Name = "comboConge";
            this.comboConge.Size = new System.Drawing.Size(250, 28);
            this.comboConge.TabIndex = 17;
            // 
            // txtDateDebut
            // 
            this.txtDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDateDebut.Location = new System.Drawing.Point(196, 135);
            this.txtDateDebut.Mask = "00/00/0000";
            this.txtDateDebut.Name = "txtDateDebut";
            this.txtDateDebut.Size = new System.Drawing.Size(250, 26);
            this.txtDateDebut.TabIndex = 20;
            this.txtDateDebut.ValidatingType = typeof(System.DateTime);
            // 
            // txtDateFin
            // 
            this.txtDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDateFin.Location = new System.Drawing.Point(196, 185);
            this.txtDateFin.Mask = "00/00/0000";
            this.txtDateFin.Name = "txtDateFin";
            this.txtDateFin.Size = new System.Drawing.Size(250, 26);
            this.txtDateFin.TabIndex = 21;
            this.txtDateFin.ValidatingType = typeof(System.DateTime);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("PT Sans Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTitre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitre.Location = new System.Drawing.Point(25, 15);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(126, 19);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "CRÉER UNE DEMANDE";
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
            // AjouterDemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(500, 470);
            this.Controls.Add(this.txtDateFin);
            this.Controls.Add(this.txtDateDebut);
            this.Controls.Add(this.comboConge);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSoumettre);
            this.Controls.Add(this.checkConfirmation);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjouterDemande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AjouterDemande_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.CheckBox checkConfirmation;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSoumettre;
        private System.Windows.Forms.ComboBox comboConge;
        private System.Windows.Forms.MaskedTextBox txtDateDebut;
        private System.Windows.Forms.MaskedTextBox txtDateFin;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnReduire;
        private System.Windows.Forms.Panel panelHeader;
    }
}