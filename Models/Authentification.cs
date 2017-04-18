using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Models
{
    public class Authentification
    {
        //Attributs
        private String login,mdp;
        public static Int32 num;

        //constructeurs
        public Authentification(String Login, String Mdp,String type)
        {
            this.login = Login;
            this.mdp = Mdp;

            //Appel de la fonction Ajouter
            if (type == "Personnel")
            {
                Login_Personnel(this.login, this.mdp);
                return;
            }
            else if (type == "Responsable")
            {
                Login_Responsable(this.login, this.mdp);
                return;
            }
            else
            {
                return;
            }
            
        }

        //Methode Login personnel
        private void Login_Personnel(String Login, String Mdp)
        {
            try
            {
                using (SqlCommand Commande = new SqlCommand("[LOGIN_Personnel]", Database.Connexion))
                {
                    Commande.CommandType = CommandType.StoredProcedure;

                    //Ouvrire la connexion
                    Database.Connexion.Open();

                    //les parametres d'entrées
                    Commande.Parameters.Add("@Login", SqlDbType.VarChar, 26).Value = Login;
                    Commande.Parameters.Add("@Mdp", SqlDbType.VarChar, 16).Value = Mdp;

                    //le parametre de sortie
                    SqlParameter nbr = new SqlParameter("@Num", SqlDbType.Int, 4);
                    nbr.Direction = ParameterDirection.Output;
                    Commande.Parameters.Add(nbr);

                    //Executer la requete
                    Commande.ExecuteNonQuery();
                    
                    //la vraible num recoit la valeur
                    Authentification.num = Convert.ToInt32(nbr.Value);
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


        //Methode Login personnel
        private void Login_Responsable(String Login, String Mdp)
        {
            try
            {
                using (SqlCommand Commande = new SqlCommand("[LOGIN_Responsable]", Database.Connexion))
                {
                    Commande.CommandType = CommandType.StoredProcedure;

                    //Ouvrire la connexion
                    Database.Connexion.Open();

                    //les parametres d'entrées
                    Commande.Parameters.Add("@Login", SqlDbType.VarChar, 26).Value = Login;
                    Commande.Parameters.Add("@Mdp", SqlDbType.VarChar, 16).Value = Mdp;

                    //le parametre de sortie
                    SqlParameter nbr = new SqlParameter("@Num", SqlDbType.Int, 4);
                    nbr.Direction = ParameterDirection.Output;
                    Commande.Parameters.Add(nbr);

                    //Executer la requete
                    Commande.ExecuteNonQuery();

                    //la vraible num recoit la valeur
                    Authentification.num = Convert.ToInt32(nbr.Value);
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
