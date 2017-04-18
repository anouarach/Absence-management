using System;
using System.Drawing;
using System.Windows.Forms;
using MyMessageBox;
using Models;


namespace Controllers
{
    public class AuthentificationController
    {
        
        //Controlle des champs
        public static void ValiderChamps(ref TextBox Login,ref TextBox Mdp,out bool etat)
        {
            etat = false;

            if (Login.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer votre login.");
                message.ShowDialog();
                Login.Focus();
                Login.SelectAll();
                return;
            }

            if (Mdp.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer votre mot de passe.");
                message.ShowDialog();
                Mdp.Focus();
                Mdp.SelectAll();
                return;
            }

            etat = true;
        }

    }
}
