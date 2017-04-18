using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;

namespace Apps
{
    public partial class DashboardResponsable : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        String Login = "";
        public DashboardResponsable(String login)
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

        DataTable ResponsableTable = new DataTable();
        private void DashboardResponsable_Load(object sender, EventArgs e)
        {
            //Remplire les données
            Controllers.ResponsableController.RemplireDonnee(this.Login, ref ResponsableTable);

            //Charger les données
            lblNomComplet.Text = ResponsableTable.Rows[0][4].ToString().ToUpper() + " " + ResponsableTable.Rows[0][3].ToString().ToUpper();
            lblNom.Text = ResponsableTable.Rows[0][3].ToString();
            lblPrenom.Text = ResponsableTable.Rows[0][4].ToString();
            lblMatricule.Text = ResponsableTable.Rows[0][2].ToString();
            lblCin.Text = ResponsableTable.Rows[0][0].ToString();
            lblDateNaissance.Text = Convert.ToDateTime(ResponsableTable.Rows[0][5]).ToShortDateString();
            lblAjout.Text = Convert.ToDateTime(ResponsableTable.Rows[0][13]).ToShortDateString();
            lblTél.Text = ResponsableTable.Rows[0][10].ToString();
            lblEmail.Text = ResponsableTable.Rows[0][11].ToString();
            lblLogin.Text = ResponsableTable.Rows[0][6].ToString();
            lblMdp.Text = ResponsableTable.Rows[0][7].ToString();
        }

        private void btnDemandes_Click(object sender, EventArgs e)
        {
            Demandes demande = new Demandes();
            demande.ShowDialog();
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            NouveauType type = new NouveauType();
            type.ShowDialog();
        }

        private void btnHistorique_Click(object sender, EventArgs e)
        {
            Historique historique = new Historique();
            historique.ShowDialog();
        }
        
        private void btnNouveauPersonnel_Click(object sender, EventArgs e)
        {
            NouveauPersonnel personnel = new NouveauPersonnel();
            personnel.ShowDialog();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            SupprimerPersonnel pesonnel = new SupprimerPersonnel();
            pesonnel.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("www.charij.com");
        }

    }
}
