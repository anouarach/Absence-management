using System;
using System.Data.SqlClient;
using System.Data;

namespace Models
{
    public class Demande
    {
        //Attributs
        private String Cin,Type,Raison;
        private DateTime DateDemande,DateDebut,DateFin;
        private Int32 NombreJours;

        //constructeurs
        public Demande() { }
        public Demande(String Cin, String Type, DateTime DateDemande, DateTime DateDebut, DateTime DateFin, Int32 NombreJours, String Raison)
        {
            //Affectation des values
            this.Cin = Cin;
            this.Type = Type;
            this.DateDemande = DateDemande;
            this.DateDebut = DateDebut;
            this.DateFin = DateFin;
            this.NombreJours = NombreJours;
            this.Raison = Raison;
        
            //Enregistrer les demande
            AjouterDemande(this.Cin, this.Type, this.DateDemande, this.DateDebut, this.DateFin, this.NombreJours, this.Raison);
        }

        //faire ajouter une demande de congé
        private void AjouterDemande(String Cin, String Type, DateTime DateDemande, DateTime DateDebut, DateTime DateFin, Int32 NombreJours,String Raison)
        {
            try
            {
                using (SqlCommand commande = new SqlCommand("AjouterDemande", Database.Connexion))
                {
                    commande.CommandType = CommandType.StoredProcedure;

                    //Ouvrire la conexion
                    Database.Connexion.Open();

                    //les parametres d'entrés
                    commande.Parameters.Add("@CIN", SqlDbType.VarChar, 10).Value = Cin;
                    commande.Parameters.Add("@Type", SqlDbType.VarChar, 255).Value = Type;
                    commande.Parameters.Add("@DateDemande", SqlDbType.DateTime).Value = DateDemande;
                    commande.Parameters.Add("@DateDebut", SqlDbType.Date).Value = DateDebut;
                    commande.Parameters.Add("@DateFin", SqlDbType.Date).Value = DateFin;
                    commande.Parameters.Add("@NbrJours", SqlDbType.TinyInt).Value = NombreJours;
                    commande.Parameters.Add("@Raison", SqlDbType.VarChar, 500).Value = Raison;

                    //Execution de la requete
                    commande.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (Database.Connexion.State == ConnectionState.Open)
                {
                    Database.Connexion.Close();
                }
            }
        }
        
        //Afficher les demandes pour le personnel
        public void AfficherPersonnel(String Cin,ref DataTable Table)
        {
            try
            {
                using (SqlCommand commande = new SqlCommand("AfficherDemande", Database.Connexion))
                {
                    commande.CommandType = CommandType.StoredProcedure;
                    
                    //ouvrire la connexion
                    Database.Connexion.Open();

                    //Ajouter le parametre
                    commande.Parameters.Add("@CIN", SqlDbType.VarChar, 10).Value = Cin;

                    //l'execution de la requete
                    SqlDataReader Reader = commande.ExecuteReader();

                    //Remplissage de table
                    Table.Load(Reader);
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (Database.Connexion.State == ConnectionState.Open)
                {
                    Database.Connexion.Close();
                }
            }
        }
        
        //Annuler une demande de congé
        public void AnnulerDemande(String CIN, String Type, DateTime DateDemande)
        {
            try
            {
                using (SqlCommand commande = new SqlCommand("AnnulerDemande", Database.Connexion))
                {
                    commande.CommandType = CommandType.StoredProcedure;

                    //ouvrire la connexion
                    Database.Connexion.Open();

                    //Ajouter les parametres
                    commande.Parameters.Add("@CIN", SqlDbType.VarChar, 10).Value = CIN;
                    commande.Parameters.Add("@Type", SqlDbType.VarChar, 255).Value = Type;
                    commande.Parameters.Add("@DateDemande", SqlDbType.DateTime).Value = DateDemande;

                    //Executer la requete
                    commande.ExecuteNonQuery();

                }
            }
            catch (SqlException)
            {
                throw new Exception();
            }
            finally
            {
                if (Database.Connexion.State == ConnectionState.Open)
                {
                    Database.Connexion.Close();
                }
            }
        }
        
        //Afficher les demandes invalide pour le responsable
        public void AfficherResponsable(ref DataTable Table)
        {
            try
            {
                using (SqlCommand commande = new SqlCommand("SELECT * FROM Demande WHERE Reponse = 'False'", Database.Connexion))
                {
                    commande.CommandType = CommandType.Text;

                    //ouvrire la connexion
                    Database.Connexion.Open();

                    //l'execution de la requete
                    SqlDataReader Reader = commande.ExecuteReader();

                    //Remplissage de table
                    Table.Load(Reader);
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (Database.Connexion.State == ConnectionState.Open)
                {
                    Database.Connexion.Close();
                }
            }
        }
    
        //Faire modifier les demandes
        public void ModifierDemande(String CIN,String Type,DateTime DateDemande)
        {
            try
            {
                using (SqlCommand commande = new SqlCommand("ModifierDemande",Database.Connexion))
                {
                    commande.CommandType = CommandType.StoredProcedure;

                    //ouvrire la connexion
                    Database.Connexion.Open();

                    //Ajouter les parametres
                    commande.Parameters.Add("@CIN", SqlDbType.VarChar, 10).Value = CIN;
                    commande.Parameters.Add("@Type", SqlDbType.VarChar, 255).Value = Type;
                    commande.Parameters.Add("@DateDemande", SqlDbType.DateTime).Value = DateDemande;

                    //Executer la requete
                    commande.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (Database.Connexion.State == ConnectionState.Open)
                {
                    Database.Connexion.Close();
                }
            }
        }

        //Afficher tout les demandes
        public void AfficherToutesDemandes(ref DataTable Table)
        {
            try
            {
                using (SqlCommand commande = new SqlCommand("SELECT * FROM [Demande]", Database.Connexion))
                {
                    commande.CommandType = CommandType.Text;

                    //ouvrire la connexion
                    Database.Connexion.Open();

                    //l'execution de la requete
                    SqlDataReader Reader = commande.ExecuteReader();

                    //Remplissage de table
                    Table.Load(Reader);
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (Database.Connexion.State == ConnectionState.Open)
                {
                    Database.Connexion.Close();
                }
            }
        }

        //afficher les derniners demandes
        public void AfficherDerniersDemandes(String Cin,ref DataTable Table)
        {
            try
            {
                using (SqlCommand commande = new SqlCommand("SELECT TOP 10 * FROM [Demande] WHERE CIN = '" + Cin + "' ORDER BY [Date demande] DESC", Database.Connexion))
                {
                    commande.CommandType = CommandType.Text;

                    //ouvrire la connexion
                    Database.Connexion.Open();

                    //l'execution de la requete
                    SqlDataReader Reader = commande.ExecuteReader();

                    //Remplissage de table
                    Table.Load(Reader);
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (Database.Connexion.State == ConnectionState.Open)
                {
                    Database.Connexion.Close();
                }
            }
        }
    }
}
