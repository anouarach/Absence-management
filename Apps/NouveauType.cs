using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Apps
{
    public partial class NouveauType : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public NouveauType()
        {
            InitializeComponent();
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void NouveauType_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //Validation des zones
            bool etat;
            Controllers.CongéController.ValiderZone(txtType, txtDroits,out etat);

            //L'ajout des données
            if (etat)
            {
                Controllers.CongéController.AjouterType(txtType.Text.Trim(), txtDroits.Text.Trim());
            }
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //Vider les zones de texte
            txtType.Clear();
            txtDroits.Clear();

            //focus a la zone type
            txtType.Focus();
        }
    }
}
