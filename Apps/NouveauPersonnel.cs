using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Models;

namespace Apps
{
    public partial class NouveauPersonnel : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public NouveauPersonnel()
        {
            InitializeComponent();
            comboFonction.SelectedIndex = 0;
            comboSexe.SelectedIndex = 0;
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //valdiation des données
            bool etat = false;
            Controllers.PersonnelController.ValiderDonner(txtCin, txtNom, txtPrénom, txtDN, comboSexe, txtTelephone, txtAdresse, comboFonction,txtEmail, txtLogin, txtMdp, txtConfirmationMdp, out etat);

            if (etat)
            {
                Personnel personnel = new Personnel(txtCin.Text,  txtNom.Text, txtPrénom.Text, Convert.ToDateTime(txtDN.Text), comboSexe.SelectedText, txtTelephone.Text, txtAdresse.Text,txtLogin.Text,comboFonction.SelectedText,txtEmail.Text,txtMdp.Text);
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Information", "Le nouveau personnel est ajouter avec succé.");
                message.ShowDialog();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //vider les zones
            txtCin.Clear();
            txtNom.Clear();
            txtPrénom.Clear();
            txtDN.Clear();
            comboSexe.SelectedIndex = 0;
            txtTelephone.Clear();
            txtAdresse.Clear();
            comboFonction.SelectedIndex = 0;
            txtEmail.Clear();
            txtLogin.Clear();
            txtMdp.Clear();
            txtConfirmationMdp.Clear();

            //donner le focus a la 1er zone
            txtCin.Focus();
        }

    }
}
