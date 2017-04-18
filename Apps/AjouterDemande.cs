using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;

namespace Apps
{
    public partial class AjouterDemande : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        String CIN = "";
        public AjouterDemande(String Cin)
        {
            InitializeComponent();
            this.CIN = Cin;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        DataTable conge = new DataTable();     
        private void AjouterDemande_Load(object sender, EventArgs e)
        {
            Controllers.DemandeController.RemplireConge(ref conge, ref comboConge);
        }

        private void btnSoumettre_Click(object sender, EventArgs e)
        {
            //Validation des entrés
            bool etat;
            Controllers.DemandeController.ValidationZone(txtDateDebut, txtDateFin, txtCommentaire, checkConfirmation, out etat);
            if (!etat)
            {
                return;
            }

            //Eregistrement des données
            Controllers.DemandeController.EnregistrerDemande(this.CIN,comboConge.SelectedValue.ToString(),Convert.ToDateTime(txtDateDebut.Text),Convert.ToDateTime(txtDateFin.Text),txtCommentaire.Text);
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //faire retourner tout vide
            comboConge.SelectedIndex = 0;
            txtDateDebut.Clear();
            txtDateFin.Clear();
            txtCommentaire.Clear();
            checkConfirmation.Checked = false;
            this.Close();
        }

    }
}
