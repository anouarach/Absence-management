using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Controllers;
using Models;

namespace Apps
{
    public partial class Authentification : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        public Authentification()
        {
            InitializeComponent();
            this.radioPersonnel.Checked = true;
            this.lblTitre.Font = new Font("PT Sans Narrow", 15, FontStyle.Bold, GraphicsUnit.Pixel);
            this.lblLogin.Font = new Font("PT Sans Narrow", 13, FontStyle.Bold, GraphicsUnit.Pixel);
            this.lblPasse.Font = new Font("PT Sans Narrow", 13, FontStyle.Bold, GraphicsUnit.Pixel);
            this.radioPersonnel.Font = new Font("PT Sans Narrow", 13, FontStyle.Bold, GraphicsUnit.Pixel);
            this.radioResponsable.Font = new Font("PT Sans Narrow", 13, FontStyle.Bold, GraphicsUnit.Pixel);
            this.btnConnexion.Font = new Font("PT Sans Narrow", 13, FontStyle.Bold, GraphicsUnit.Pixel);
            this.btnAnnuler.Font = new Font("PT Sans Narrow", 13, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        String Login;
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            try
            {//Authentification Personnel
                if (radioPersonnel.Checked && !radioResponsable.Checked)
                {
                    //validation des champs
                    bool etat;
                    AuthentificationController.ValiderChamps(ref txtLogin, ref txtPasse,out etat);

                    //si y'as des erreurs on est besoin de faire quitter la procedure
                    if (etat== false)
                    {
                        return;
                    }

                    //Obtenir la valuer de la zone login
                    Login = txtLogin.Text;
                    
                    //authentification
                    Models.Authentification login = new Models.Authentification(txtLogin.Text, txtPasse.Text,"Personnel");
                    
                    //validation des champs
                    if (Models.Authentification.num >= 1)
                    {
                        //fermer le formulaire d'authentification pour ne pas chargé la ram
                        this.Close();
                        
                        //ouvrire le nouveau formulaire
                        Thread thread = new Thread(TableauBordPersonnel);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }
                    else
                    {
                        MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Compte invalide.");
                        message.ShowDialog();
                    }
                }

                else if (!radioPersonnel.Checked && radioResponsable.Checked)
                {
                    //validation des champs
                    bool etat;
                    AuthentificationController.ValiderChamps(ref txtLogin, ref txtPasse, out etat);

                    //si y'as des erreurs on est besoin de faire quitter la procedure
                    if (etat == false)
                    {
                        return;
                    }

                    //Obtenir la valuer de la zone login
                    Login = txtLogin.Text;

                    //authentification
                    Models.Authentification login = new Models.Authentification(txtLogin.Text, txtPasse.Text, "Responsable");

                    //validation des champs
                    if (Models.Authentification.num >= 1)
                    {
                        //fermer le formulaire d'authentification pour ne pas chargé la ram
                        this.Close();

                        //ouvrire le nouveau formulaire
                        Thread thread = new Thread(TableauBordResponsable);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }
                    else
                    {
                        MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Compte invalide.");
                        message.ShowDialog();
                    }
                }
                else
                {
                    MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Choisir un radion bouton.");
                    message.ShowDialog();
                    return;
                }


            }
            catch (Exception ex)
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", ex.Message);
                message.ShowDialog();
            }
        }
        
        //Pour faire ouvrire le tabelau de bord
        private void TableauBordPersonnel(Object obj)
        {
            Application.Run(new DashboardPersonnel(Login));
        }

        private void TableauBordResponsable(Object obj)
        {
            Application.Run(new DashboardResponsable(Login));
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            //vider les zones
            txtLogin.Clear();
            txtPasse.Clear();

            //faire retourner a la 1er zone
            txtLogin.Focus();
        }
    }
}
