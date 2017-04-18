namespace Apps
{
    partial class DashboardPersonnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPersonnel));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnReduire = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReponse = new System.Windows.Forms.Button();
            this.btnCompte = new System.Windows.Forms.Button();
            this.btnAnnulerDemande = new System.Windows.Forms.Button();
            this.btnAjouterDemande = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCin = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNomComplet = new System.Windows.Forms.Label();
            this.lblAjout = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTél = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(34)))), ((int)(((byte)(65)))));
            this.panelHeader.Controls.Add(this.btnReduire);
            this.panelHeader.Controls.Add(this.btnFermer);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 50);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // btnReduire
            // 
            this.btnReduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduire.ForeColor = System.Drawing.Color.Transparent;
            this.btnReduire.Location = new System.Drawing.Point(820, 13);
            this.btnReduire.Name = "btnReduire";
            this.btnReduire.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnReduire.Size = new System.Drawing.Size(25, 25);
            this.btnReduire.TabIndex = 5;
            this.btnReduire.Text = "_";
            this.btnReduire.UseVisualStyleBackColor = true;
            this.btnReduire.Click += new System.EventHandler(this.btnReduire_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFermer.Location = new System.Drawing.Point(850, 13);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnFermer.Size = new System.Drawing.Size(25, 25);
            this.btnFermer.TabIndex = 4;
            this.btnFermer.Text = "X";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Sans Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "TABLEAU DE BORD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnReponse);
            this.panel1.Controls.Add(this.btnCompte);
            this.panel1.Controls.Add(this.btnAnnulerDemande);
            this.panel1.Controls.Add(this.btnAjouterDemande);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 500);
            this.panel1.TabIndex = 3;
            // 
            // btnReponse
            // 
            this.btnReponse.FlatAppearance.BorderSize = 0;
            this.btnReponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReponse.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnReponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnReponse.Image = ((System.Drawing.Image)(resources.GetObject("btnReponse.Image")));
            this.btnReponse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReponse.Location = new System.Drawing.Point(0, 258);
            this.btnReponse.Name = "btnReponse";
            this.btnReponse.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnReponse.Size = new System.Drawing.Size(300, 60);
            this.btnReponse.TabIndex = 3;
            this.btnReponse.Text = "        Les résponses";
            this.btnReponse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReponse.UseVisualStyleBackColor = true;
            this.btnReponse.Click += new System.EventHandler(this.btnReponse_Click);
            // 
            // btnCompte
            // 
            this.btnCompte.BackColor = System.Drawing.Color.Silver;
            this.btnCompte.FlatAppearance.BorderSize = 0;
            this.btnCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompte.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCompte.Image = ((System.Drawing.Image)(resources.GetObject("btnCompte.Image")));
            this.btnCompte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompte.Location = new System.Drawing.Point(0, 45);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCompte.Size = new System.Drawing.Size(300, 60);
            this.btnCompte.TabIndex = 2;
            this.btnCompte.Text = "        Mon compte";
            this.btnCompte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompte.UseVisualStyleBackColor = false;
            // 
            // btnAnnulerDemande
            // 
            this.btnAnnulerDemande.FlatAppearance.BorderSize = 0;
            this.btnAnnulerDemande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerDemande.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAnnulerDemande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAnnulerDemande.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnulerDemande.Image")));
            this.btnAnnulerDemande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnulerDemande.Location = new System.Drawing.Point(0, 187);
            this.btnAnnulerDemande.Name = "btnAnnulerDemande";
            this.btnAnnulerDemande.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAnnulerDemande.Size = new System.Drawing.Size(300, 60);
            this.btnAnnulerDemande.TabIndex = 1;
            this.btnAnnulerDemande.Text = "        Annuler une demande";
            this.btnAnnulerDemande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnnulerDemande.UseVisualStyleBackColor = true;
            this.btnAnnulerDemande.Click += new System.EventHandler(this.btnAnnulerDemande_Click);
            // 
            // btnAjouterDemande
            // 
            this.btnAjouterDemande.FlatAppearance.BorderSize = 0;
            this.btnAjouterDemande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterDemande.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAjouterDemande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAjouterDemande.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouterDemande.Image")));
            this.btnAjouterDemande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterDemande.Location = new System.Drawing.Point(0, 116);
            this.btnAjouterDemande.Name = "btnAjouterDemande";
            this.btnAjouterDemande.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAjouterDemande.Size = new System.Drawing.Size(300, 60);
            this.btnAjouterDemande.TabIndex = 0;
            this.btnAjouterDemande.Text = "        Ajouter une demande";
            this.btnAjouterDemande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterDemande.UseVisualStyleBackColor = true;
            this.btnAjouterDemande.Click += new System.EventHandler(this.btnAjouterDemande_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(395, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "&Adresse email :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lbl.Location = new System.Drawing.Point(395, 353);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 18);
            this.lbl.TabIndex = 29;
            this.lbl.Text = "&Téléphone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(395, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "&Date d\'ajout :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(395, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "&Date de naissance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(395, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "&CIN :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(395, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "&Nom Complet :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblNom.Font = new System.Drawing.Font("PT Sans Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblNom.Location = new System.Drawing.Point(570, 153);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(33, 19);
            this.lblNom.TabIndex = 34;
            this.lblNom.Text = "Nom";
            // 
            // lblCin
            // 
            this.lblCin.AutoSize = true;
            this.lblCin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblCin.Font = new System.Drawing.Font("PT Sans Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblCin.Location = new System.Drawing.Point(570, 233);
            this.lblCin.Name = "lblCin";
            this.lblCin.Size = new System.Drawing.Size(126, 19);
            this.lblCin.TabIndex = 35;
            this.lblCin.Text = "Carte identité national";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblDateNaissance.Font = new System.Drawing.Font("PT Sans Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaissance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblDateNaissance.Location = new System.Drawing.Point(570, 273);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(102, 19);
            this.lblDateNaissance.TabIndex = 36;
            this.lblDateNaissance.Text = "Date de naissance";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblPrenom.Font = new System.Drawing.Font("PT Sans Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblPrenom.Location = new System.Drawing.Point(655, 153);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 19);
            this.lblPrenom.TabIndex = 37;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblMatricule.Font = new System.Drawing.Font("PT Sans Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblMatricule.Location = new System.Drawing.Point(570, 193);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(57, 19);
            this.lblMatricule.TabIndex = 39;
            this.lblMatricule.Text = "Matricule";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label13.Location = new System.Drawing.Point(395, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 18);
            this.label13.TabIndex = 38;
            this.label13.Text = "&Matricule :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(395, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // lblNomComplet
            // 
            this.lblNomComplet.AutoSize = true;
            this.lblNomComplet.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNomComplet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(122)))), ((int)(((byte)(191)))));
            this.lblNomComplet.Location = new System.Drawing.Point(421, 96);
            this.lblNomComplet.Name = "lblNomComplet";
            this.lblNomComplet.Size = new System.Drawing.Size(72, 18);
            this.lblNomComplet.TabIndex = 44;
            this.lblNomComplet.Text = "Nom Prénom";
            // 
            // lblAjout
            // 
            this.lblAjout.AutoSize = true;
            this.lblAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblAjout.Font = new System.Drawing.Font("PT Sans Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblAjout.Location = new System.Drawing.Point(570, 312);
            this.lblAjout.Name = "lblAjout";
            this.lblAjout.Size = new System.Drawing.Size(72, 19);
            this.lblAjout.TabIndex = 47;
            this.lblAjout.Text = "Date d\'ajout";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblEmail.Font = new System.Drawing.Font("PT Sans Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblEmail.Location = new System.Drawing.Point(570, 392);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 19);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "Adresse email";
            // 
            // lblTél
            // 
            this.lblTél.AutoSize = true;
            this.lblTél.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTél.Font = new System.Drawing.Font("PT Sans Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTél.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblTél.Location = new System.Drawing.Point(570, 352);
            this.lblTél.Name = "lblTél";
            this.lblTél.Size = new System.Drawing.Size(65, 19);
            this.lblTél.TabIndex = 45;
            this.lblTél.Text = "Téléphone";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblLogin.Font = new System.Drawing.Font("PT Sans Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblLogin.Location = new System.Drawing.Point(570, 432);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 19);
            this.lblLogin.TabIndex = 49;
            this.lblLogin.Text = "Login";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(395, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 48;
            this.label9.Text = "&Login :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblMdp.Font = new System.Drawing.Font("PT Sans Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblMdp.Location = new System.Drawing.Point(570, 472);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(77, 19);
            this.lblMdp.TabIndex = 51;
            this.lblMdp.Text = "Mot de passe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("PT Sans Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label11.Location = new System.Drawing.Point(395, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 50;
            this.label11.Text = "&Mot de passe :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("PT Sans Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(793, 517);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 19);
            this.linkLabel1.TabIndex = 52;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.charij.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DashboardPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAjout);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTél);
            this.Controls.Add(this.lblNomComplet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMatricule);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.lblCin);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DashboardPersonnel_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjouterDemande;
        private System.Windows.Forms.Button btnAnnulerDemande;
        private System.Windows.Forms.Button btnReponse;
        private System.Windows.Forms.Button btnCompte;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnReduire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCin;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomComplet;
        private System.Windows.Forms.Label lblAjout;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTél;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

