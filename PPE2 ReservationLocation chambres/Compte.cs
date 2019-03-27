using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE2_ReservationLocation_chambres
{
    class Compte
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

        public static string ConnexionVerifCompte()
        {
            string res = "error";
            MySqlCommand commande = connec.CreateCommand();
            // Creation de la requête en fonction de l'user
            string req1 = "SELECT typeCompte FROM compte";
            commande.CommandText = req1;
            MySqlDataReader lire = commande.ExecuteReader();
            res = lire.Read();
            return res;
        }
    }
}
