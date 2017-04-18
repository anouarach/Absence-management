using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Apps
{
    public partial class DashboardPersonnel : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        String Login = "";
        public DashboardPersonnel(String login)
        {
            InitializeComponent();
            this.Login = login;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        
        private void DashboardPersonnel_Load(object sender, EventArgs e)
        {
            DataTable PersonnelTable = new DataTable();
            
            //Remplire les données
            Controllers.PersonnelController.RemplireDonnee(this.Login, ref PersonnelTable);
           
            //Charger les données
            lblNomComplet.Text = PersonnelTable.Rows[0][3].ToString().ToUpper() + " " + PersonnelTable.Rows[0][2].ToString().ToUpper();
            lblNom.Text = PersonnelTable.Rows[0][2].ToString();
            lblPrenom.Text = PersonnelTable.Rows[0][3].ToString();
            lblMatricule.Text = PersonnelTable.Rows[0][1].ToString();
            lblCin.Text = PersonnelTable.Rows[0][0].ToString();
            lblDateNaissance.Text = Convert.ToDateTime(PersonnelTable.Rows[0][4]).ToShortDateString();
            lblAjout.Text = Convert.ToDateTime(PersonnelTable.Rows[0][12]).ToShortDateString();
            lblTél.Text = PersonnelTable.Rows[0][9].ToString();
            lblEmail.Text = PersonnelTable.Rows[0][10].ToString();
            lblLogin.Text = PersonnelTable.Rows[0][5].ToString();
            lblMdp.Text = PersonnelTable.Rows[0][6].ToString();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAjouterDemande_Click(object sender, EventArgs e)
        {
            AjouterDemande demande = new AjouterDemande(lblCin.Text);
            demande.Show();
        }

        private void btnAnnulerDemande_Click(object sender, EventArgs e)
        {
            AnnulerDemande demande = new AnnulerDemande(lblCin.Text);
            demande.ShowDialog();
        }

        private void btnReponse_Click(object sender, EventArgs e)
        {
            Reponse reponse = new Reponse(lblCin.Text);
            reponse.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.charij.com"); 
        }
    }
}
