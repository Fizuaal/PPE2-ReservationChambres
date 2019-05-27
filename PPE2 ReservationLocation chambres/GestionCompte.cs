using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE2_ReservationLocation_chambres
{
    class GestionCompte
    {
        private static string Connexion = @"server=localhost;password=;userid=root;database=ppe2location";
        private static MySqlConnection connec;


        public static bool ConnexionBDD()
        {
            // Méthode static qui se connect à la base de donnée.
            connec = new MySqlConnection(Connexion);
            connec.Open();
            return (connec.State == System.Data.ConnectionState.Open);

        }

        public static bool DeconnexionBDD()
        {
            connec = new MySqlConnection(Connexion);
            connec.Close();
            return (connec.State == System.Data.ConnectionState.Closed);
        }

        public static bool ConnexionVerif(string id, string pass)
        {
            bool res = false;
            MySqlCommand commande = connec.CreateCommand();
            // Récupère USER / MOT DE PASSE 
            string req0 = "SELECT NOM_COMPTE, mdp FROM comptes WHERE NOM_COMPTE='" + id + "' AND mdp='" + pass + "'";
            commande.CommandText = req0;


            MySqlDataReader lire = commande.ExecuteReader();

            if(lire.Read())
            {
                res = true;
            }
            lire.Close();
            return res;
        }

        public static string[] ConnexionRecupParamCompte(string id)
        {
            MySqlCommand commande = connec.CreateCommand();
            // Récupère USER / MOT DE PASSE 
            string req0 = "SELECT *, mdp FROM comptes WHERE NOM_COMPTE='" + id +"'";
            commande.CommandText = req0;


            MySqlDataReader lire = commande.ExecuteReader();
            lire.Read();
            string[] parametres = new string[] { lire.GetString("NOM_COMPTE"), lire.GetString("TYPECOMPTE") };
            lire.Close();
            return parametres;
        }
    }
}
