using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Apps
{
    public partial class Demandes : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Demandes()
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

        private void Demandes_Load(object sender, EventArgs e)
        {
            Controllers.DemandeController.AfficherDemandeInvalide(ref grilleDemande);
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            try
            {
                if (grilleDemande.SelectedCells[0].Value.ToString() != "")
                {
                    String Cin = grilleDemande.SelectedCells[0].Value.ToString();
                    String Type = grilleDemande.SelectedCells[1].Value.ToString();
                    DateTime DateDemande = Convert.ToDateTime(grilleDemande.SelectedCells[2].Value);

                    //L'appel de la méthode
                    MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Information", "Voulez-vous vraiment valider cette demande.");
                    message.ShowDialog();
                    if (message.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        Controllers.DemandeController.ModifierNouveauDemande(Cin, Type, DateDemande, ref grilleDemande);                        
                    }
                }
            }
            catch (Exception)
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Aucune demande n'est séléctionner");
                message.ShowDialog();
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
