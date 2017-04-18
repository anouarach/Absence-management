using System;
using System.Data.SqlClient;
using System.Data;

namespace Models
{
    public class Personnel
    {
        //Attributs
        private String Cin,Nom,Prenom,Sexe,Login,Mdp,Telephone,Adresse,Email,Fonction;
        private DateTime DateNaissance;

        
        //Constructeurs
        public Personnel() { }
        public Personnel(String cin, String nom, String prenom, DateTime datenaissance, String sexe, String telephone, String adresse,
            String login, String fonction, String email, String mdp) 
        {
            this.Cin = cin;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = datenaissance;
            this.Sexe = sexe;
            this.Telephone = telephone;
            this.Adresse = adresse;
            this.Login = login;
            this.Fonction = fonction;
            this.Email = email;
            this.Mdp = mdp;

            //L'ajout 
            AjouterNouveauPersonnel(this.Cin, this.Nom, this.Prenom, this.DateNaissance, this.Sexe, this.Telephone, this.Adresse, this.Login, this.Fonction, this.Email, this.Mdp);
        }

        //Methodes public 
        private void AjouterNouveauPersonnel(String cin, String nom, String prenom, DateTime datenaissance, String sexe, String telephone, String adresse, String login,
            String fonction, String email, String mdp) 
        {
            try
            {
                using (SqlCommand commande = new SqlCommand("AjouterNouveauPersonnel", Database.Connexion))
                {
                    commande.CommandType = System.Data.CommandType.StoredProcedure;

                    //Ajouter les parametres 
                    commande.Parameters.Add("@Cin", SqlDbType.VarChar, 10).Value = cin;
                    commande.Parameters.Add("@Nom", SqlDbType.VarChar, 30).Value = nom;
                    commande.Parameters.Add("@Prenom", SqlDbType.VarChar, 30).Value = prenom;
                    commande.Parameters.Add("@DateNaissance", SqlDbType.Date).Value = datenaissance;
                    commande.Parameters.Add("@Login", SqlDbType.VarChar, 26).Value = login;
                    commande.Parameters.Add("@Mdp", SqlDbType.VarChar, 16).Value = mdp;
                    commande.Parameters.Add("@Adresse", SqlDbType.VarChar, 255).Value = adresse;
                    commande.Parameters.Add("@Sexe", SqlDbType.VarChar, 10).Value = sexe;
                    commande.Parameters.Add("@Tél", SqlDbType.VarChar, 10).Value = telephone;
                    commande.Parameters.Add("@Email", SqlDbType.VarChar, 30).Value = email;
                    commande.Parameters.Add("@Fonction", SqlDbType.VarChar, 50).Value = fonction;

                    //Ouverture de la xonnexion
                    Database.Connexion.Open();

                    //execution de la requete
                    commande.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (Database.Connexion.State == System.Data.ConnectionState.Open)
                {
                    Database.Connexion.Close();
                }
            }
        }

        //Supprimer un personnel
        public void SupprimerPersonnel(String Cin)
        {
            try
            {
                using (SqlCommand commande = new SqlCommand("SupprimerPersonnel", Database.Connexion))
                {
                    commande.CommandType = System.Data.CommandType.StoredProcedure;

                    //Ajouter les parametres 
                    commande.Parameters.Add("@Cin", SqlDbType.VarChar, 10).Value = Cin;

                    //Ouverture de la xonnexion
                    Database.Connexion.Open();

                    //execution de la requete
                    commande.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (Database.Connexion.State == System.Data.ConnectionState.Open)
                {
                    Database.Connexion.Close();
                }
            }
        }

        //Afficher tous les personnels
        public void AfficherPersonnels(ref DataTable tab)
        {
            try
            {
                using (SqlCommand commande = new SqlCommand("AfficherPersonnels", Database.Connexion))
                {
                    commande.CommandType = System.Data.CommandType.StoredProcedure;

                    //Ouverture de la xonnexion
                    Database.Connexion.Open();

                    //execution de la requete
                    SqlDataReader reader =  commande.ExecuteReader();

                    //charger le tableau

                    tab.Load(reader);
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (Database.Connexion.State == System.Data.ConnectionState.Open)
                {
                    Database.Connexion.Close();
                }
            }
        }
    }
}
