using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Models;

namespace Controllers
{
    public class CongéController
    {
        //Validation des zones de texte
        public static void ValiderZone(TextBox txtType, TextBox txtDroit, out bool etat)
        {
            etat = false;

            if (txtType.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer un nouveau type.");
                message.ShowDialog();
                txtType.Focus();
                txtType.SelectAll();
                return;
            }

            if (txtDroit.Text.Trim() == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer des droits valides.");
                message.ShowDialog();
                txtDroit.Focus();
                txtDroit.SelectAll();
                return;
            }

            etat = true;
        }
    
        //Ajouter une nouveau type
        public static void AjouterType(String Type, String Droits)
        {
            //Ajouter les données
            Congé conge = new Congé(Type, Droits);

            //Message
            MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Information", "Nouveau type ajouter avec succé.");
            message.ShowDialog();
        }
    }
}
