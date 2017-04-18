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
    public partial class AnnulerDemande : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        String CIN;
        public AnnulerDemande(String Cin)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AnnulerDemande_Load(object sender, EventArgs e)
        {
            Controllers.DemandeController.AfficherDemandeAnnuler(CIN, ref grilleDemande);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            try
            {
                if (grilleDemande.SelectedCells[0].Value.ToString() != "")
                {
                    String Type = grilleDemande.SelectedCells[0].Value.ToString();
                    DateTime DateDemande = Convert.ToDateTime(grilleDemande.SelectedCells[1].Value);
                    //Message 
                    MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Information", "Voulez-vous annuler cette demande ?.");
                    message.ShowDialog();
                    if (message.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        //L'appel de la méthode
                        Controllers.DemandeController.AnnulerDemande(CIN, Type, DateDemande, ref grilleDemande);
                    }
                }
            }
            catch (Exception)
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Aucune demande n'est séléctionner");
                message.ShowDialog();
            }
        }
    }
}
