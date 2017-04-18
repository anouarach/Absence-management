using System;
using System.Data;
using Models;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Controllers
{
    public class DemandeController
    {
        //Remplire Table Congés
        public static void RemplireConge(ref DataTable Table, ref ComboBox Combo)
        {
            if (Database.Data.Tables.Contains("conge"))
            {
                return;
            }
            else
            {
                Models.Database.RemplireData("conge", "[Congé]", ref Table);
                Combo.DataSource = Table;
                Combo.DisplayMember = "Type";
                Combo.ValueMember = "Type";
            }
        }

        //Validation des zones
        public static void ValidationZone(MaskedTextBox DateDebut, MaskedTextBox DateFin, TextBox Commentaire, CheckBox Confirmation, out bool etat)
        {
            etat = false;

            if (!DateDebut.MaskCompleted)
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer la date de debut de congé.");
                message.ShowDialog();
                DateDebut.Focus();
                DateDebut.SelectAll();
                return;
            }

            if (!DateFin.MaskCompleted)
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer la date de fin de congé.");
                message.ShowDialog();
                DateFin.Focus();
                DateFin.SelectAll();
                return;
            }

            if (DateDebut.MaskCompleted && DateFin.MaskCompleted)
            {
                DateTime Debut, Fin;

                if (!DateTime.TryParse(DateDebut.Text,out Debut))
                {
                    MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer une date valide.");
                    message.ShowDialog();
                    DateDebut.Focus();
                    DateDebut.SelectAll();
                    return;   
                }

                if (!DateTime.TryParse(DateFin.Text, out Fin))
                {
                    MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer une date valide.");
                    message.ShowDialog();
                    DateFin.Focus();
                    DateFin.SelectAll();
                    return;
                }

                Debut = DateTime.Parse(DateDebut.Text);
                Fin = DateTime.Parse(DateFin.Text);

                if (DateTime.Now.Date > Debut.Date)
                {
                    MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer une date valide.");
                    message.ShowDialog();
                    DateDebut.Focus();
                    DateDebut.SelectAll();
                    return;   
                }

                if (Debut.Date > Fin.Date)
                {
                    MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "La date de debut est inférieur que la date de fin.");
                    message.ShowDialog();
                    DateFin.Focus();
                    DateFin.SelectAll();
                    return;
                }                
            }

            if (Commentaire.Text == "")
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez entrer la raison de congé.");
                message.ShowDialog();
                Commentaire.Focus();
                Commentaire.SelectAll();
                return;
            }

            if (!Confirmation.Checked)
            {
                MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Erreur", "Veuillez confirmer la demande.");
                message.ShowDialog();
                return;
            }

            etat = true;
        }

        //Enregistrement de la demande
        public static void EnregistrerDemande(String CIN,String Type, DateTime DateDebut, DateTime DateFin, String Commentaire)
        {
            Int32 NombreJours = Convert.ToInt32((DateFin.Date - DateDebut.Date).TotalDays);
            
            //Enregistremet des données
            Demande demande = new Demande(CIN, Type, DateTime.Now, DateDebut, DateFin, NombreJours, Commentaire);

            //Message
            MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Information", "Votre demande ajouter avec succés.");
            message.ShowDialog();
        }

        //Afficher les demandes pour le personnel
        public static void AfficherDemandeAnnuler(String CIN, ref DataGridView Grille)
        {
            //Instanciation
            Demande demande = new Demande();

            //Le Reader
            DataTable Table = new DataTable();
            demande.AfficherPersonnel(CIN,ref Table);

            //Afficher les données
            DateTime debut, fin;
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                debut = Convert.ToDateTime(Table.Rows[i][2]);
                fin = Convert.ToDateTime(Table.Rows[i][3]);
                Grille.Rows.Add(Table.Rows[i][0], Table.Rows[i][1], debut.ToShortDateString(), fin.ToShortDateString(), Table.Rows[i][4], Table.Rows[i][5]);
            }
        }

        //Annuler une demande
        public static void AnnulerDemande(String CIN,String Type,DateTime DateDemande,ref DataGridView Grille)
        {
            Demande demande = new Demande();
            demande.AnnulerDemande(CIN, Type, DateDemande);
            
            //Message 
            MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Information", "La demande à été annuler avec succés.");
            message.ShowDialog();

            //vider la grille
            Grille.Rows.Clear();

            //remplire la grille 
            DemandeController.AfficherDemandeAnnuler(CIN, ref Grille);
        }

        //Afficher les demandes pour le responsable
        public static void AfficherDemandeInvalide(ref DataGridView Grille)
        {
            //Instanciation
            Demande demande = new Demande();

            //Le Reader
            DataTable Table = new DataTable();
            demande.AfficherResponsable(ref Table);

            //Afficher les données
            DateTime debut, fin;
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                debut = Convert.ToDateTime(Table.Rows[i][3]);
                fin = Convert.ToDateTime(Table.Rows[i][4]);
                Grille.Rows.Add(Table.Rows[i][0], Table.Rows[i][1], Table.Rows[i][2], debut.ToShortDateString(), fin.ToShortDateString(), Table.Rows[i][5], Table.Rows[i][6], Table.Rows[i][7]);
            }
        }
        
        //Valider les demandes (Modifier)
        public static void ModifierNouveauDemande(String Cin,String Type,DateTime DateDemande,ref DataGridView Grille)
        {
            Demande demande = new Demande();
            demande.ModifierDemande(Cin, Type, DateDemande);

            //Message 
            MyMessageBox.MyMessageBox message = new MyMessageBox.MyMessageBox("Information", "La demande à été valider avec succés.");
            message.ShowDialog();

            //vider la grille
            Grille.Rows.Clear();

            //remplire la grille 
            DemandeController.AfficherDemandeInvalide(ref Grille);
        }

        //Afficher tout les demande
        public static void AfficherDemandes(ref DataGridView Grille)
        {
            Demande demande = new Demande();
            DataTable tab = new DataTable();

            //l'appel de la méthode
            demande.AfficherToutesDemandes(ref tab);

            //Affichage des données
            Grille.DataSource = tab;
        }

        //Afficher les reponses
        public static void AfficherReponses(String Cin,ref DataGridView Grille)
        {
            Demande demande = new Demande();
            DataTable tab = new DataTable();

            //Afficher les réponses
            demande.AfficherDerniersDemandes(Cin,ref tab);
            
            //Afficher les réponses dans la grille
            Grille.DataSource = tab;
        }
    }
}
