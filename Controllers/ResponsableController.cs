using System;
using System.Data;
using Models;


namespace Controllers
{
    public class ResponsableController
    {
        //Remplire Table Responsable
        public static void RemplireDonnee(String Login, ref DataTable Table)
        {
            if (Database.Data.Tables.Contains("responsable"))
            {
                return;
            }
            else
            {
                Models.Database.RemplireDataElement(Login, "responsable", "Responsable", ref Table);
            }
        }
    }
}
