using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;

namespace Apps
{
    public partial class SupprimerPersonnel : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public SupprimerPersonnel()
        {
            InitializeComponent();
        }

        DataTable tabPersonnels = new DataTable(); 
        private void SupprimerPersonnel_Load(object sender, EventArgs e)
        {
            //Remplire les données
            Controllers.PersonnelController.AfficherPersonnels(ref grillePersonnels);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillePersonnels.SelectedCells[0].Value.ToString() != "")
                {
                    String Cin = grillePersonnels.SelectedCells[0].Value.ToString();
                    //Message 
                    MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Information", "Voulez-vous annuler supprimer ce personnel?");
                    message.ShowDialog();
                    if (message.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        //L'appel de la méthode
                        Controllers.PersonnelController.SupprimerPersonnel(Cin,ref grillePersonnels);
                    }
                }
            }
            catch (Exception)
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Aucun personnel n'est séléctionner");
                message.ShowDialog();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
