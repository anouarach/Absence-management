using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Models
{
    public class Database
    {
        //Attributs
        public static SqlConnection Connexion = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionCongé"].ConnectionString);
        public SqlCommand Commande;
        public static SqlDataAdapter Adapter = new SqlDataAdapter();
        public static SqlDataReader Reader;
        public static DataSet Data = new DataSet();

        //Remplire tout les données
        public static void RemplireData(String NomTable, String DbTable, ref DataTable Table)
        {
            using (Adapter = new SqlDataAdapter("SELECT * FROM " + DbTable, Connexion))
            {
                Adapter.Fill(Data, NomTable);
                Table = Data.Tables[NomTable];
            }
        }

        //Remplire des données pricises
        public static void RemplireDataElement(String Element, String NomTable, String DbTable, ref DataTable Table)
        {
            Adapter = new SqlDataAdapter("SELECT * FROM " + DbTable + " WHERE [Login] = '" + Element + "'", Connexion);
            Adapter.Fill(Data, NomTable);
            Table = Data.Tables[NomTable];
        }
    }
}
