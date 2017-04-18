using System;
using System.Data.SqlClient;
using System.Data;


namespace Models
{
    public class Congé
    {
        //Attributs
        private String type;
        private String droits;

        //Constructeurs
        public Congé() { }
        public Congé(String Type, String Droits)
        {
            this.type = Type;
            this.droits = Droits;
            
            //l'ajout des données
            AjouterType(this.type, this.droits);
        }

        //Ajouter un nouveau type de congé
        private void AjouterType(String Type, String Droits)
        {
            try
            {
                using (SqlCommand commande = new SqlCommand("AjouterType", Database.Connexion))
                {
                    commande.CommandType = System.Data.CommandType.StoredProcedure;

                    //Ajouter les parametres 
                    commande.Parameters.Add("@Type", SqlDbType.VarChar, 255).Value = Type;
                    commande.Parameters.Add("@Droit", SqlDbType.VarChar, 255).Value = Droits;

                    //ouverture de la connexion
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
    }
}
