using System;
using System.Text.RegularExpressions;
using Models;
using System.Data;
using System.Windows.Forms;

namespace Controllers
{
    public class PersonnelController
    {
        //Remplire Table Personnel
        public static void RemplireDonnee(String Login,ref DataTable Table)
        {
            if (Database.Data.Tables.Contains("personnel"))
            {
                return;
            }
            else
            {
                Models.Database.RemplireDataElement(Login,"personnel", "Personnel", ref Table);
            }
        }

        //validation des entrés
        public static void ValiderDonner(TextBox txtCIN,TextBox txtNom,TextBox txtPrenom,MaskedTextBox txtDN, ComboBox comboSexe,TextBox txtTél,TextBox txtAdresse, ComboBox comboFonction,TextBox txtEmail ,TextBox txtLogin,
            TextBox txtMDP,TextBox txtMDPC,out bool etat)
        {
            //variable locale
            DateTime date;
            Regex emailRegex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"); //regex pour valider le format d'email

            etat = false;

            if (txtCIN.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer le CIN.");
                message.ShowDialog();
                txtCIN.Focus();
                txtCIN.SelectAll();
                return;
            }

            if (txtNom.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer le Nom.");
                message.ShowDialog();
                txtNom.Focus();
                txtNom.SelectAll();
                return;
            }

            if (txtPrenom.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer le Prénom.");
                message.ShowDialog();
                txtPrenom.Focus();
                txtPrenom.SelectAll();
                return;
            }

            if (!DateTime.TryParse(txtDN.Text,out date) || Convert.ToDateTime(txtDN.Text) >= DateTime.Now )
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer une date valide.");
                message.ShowDialog();
                txtDN.Focus();
                txtDN.SelectAll();
                return;
            }

            if (comboSexe.SelectedIndex < 0)
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez selectionner le sexe.");
                message.ShowDialog();
                comboSexe.Focus();
                return;
            }

            if (txtTél.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer le Téléphone.");
                message.ShowDialog();
                txtTél.Focus();
                txtTél.SelectAll();
                return;
            }

            if (txtAdresse.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer l'Adresse.");
                message.ShowDialog();
                txtAdresse.Focus();
                txtAdresse.SelectAll();
                return;
            }

            if (comboFonction.SelectedIndex < 0)
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez selectionner la fonction.");
                message.ShowDialog();
                comboFonction.Focus();
                return;
            }

            if (txtEmail.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer l'Adresse email.");
                message.ShowDialog();
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }

            if (emailRegex.IsMatch(txtEmail.Text) == false)
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Adresse email invalide.");
                message.ShowDialog();
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }

            if (txtLogin.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer le Login.");
                message.ShowDialog();
                txtLogin.Focus();
                txtLogin.SelectAll();
                return;
            }

            if (txtMDP.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer le Mot de passe.");
                message.ShowDialog();
                txtMDP.Focus();
                txtMDP.SelectAll();
                return;
            }

            if (txtMDPC.Text != txtMDP.Text)
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer un Mot de passe valide.");
                message.ShowDialog();
                txtMDP.Focus();
                txtMDP.SelectAll();
                txtMDPC.Focus();
                txtMDPC.SelectAll();
                return;
            }

            etat = true;
        }

        //Afficher la liste des persoonels
        public static void AfficherPersonnels(ref DataGridView Grille)
        {
            if (Database.Data.Tables.Contains("personnels"))
            {
                Grille.DataSource = Database.Data.Tables["personnels"];
                return;
            }
            else
            {
                DataTable tab = new DataTable();
                Personnel per = new Personnel();
                per.AfficherPersonnels(ref tab);
                //charger la grille
                Grille.DataSource = tab;
            }

        }

        //supprimer un perosnnel
        public static void SupprimerPersonnel(String CIN,ref DataGridView Grille)
        {
            Personnel personne = new Personnel();
            personne.SupprimerPersonnel(CIN);
            
            //Message
            MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Information", "Le personnel est supprimer avec succés.");
            message.ShowDialog();

            //vider la grille
            Grille.DataSource = null;

            //remplire la grille
            PersonnelController.AfficherPersonnels(ref Grille);
        }
    }
}
