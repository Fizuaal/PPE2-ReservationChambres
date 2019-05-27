using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE2_ReservationLocation_chambres
{
    class GestionChambre
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

        public static List<Chambre> RecupChambresVides()
        {
            MySqlCommand commande = connec.CreateCommand();
            // Récupère CHAMBRE libres
            string req0 = "SELECT * FROM `chambres` WHERE `NOM_COMPTE`is null AND id NOT IN (SELECT id_chambre FROM `demande_reserv` WHERE est_acceptee IS NULL)";
            commande.CommandText = req0;

            MySqlDataReader lire = commande.ExecuteReader();
            List<Chambre> listChambres = new List<Chambre>();
            while (lire.Read())
            {
                listChambres.Add(new Chambre(Convert.ToInt32(lire.GetString("ID")), "Libre", lire.GetString("NOMCHAMBRE"), Convert.ToInt32(lire.GetString("NBPLACESCHAMBRE")), Convert.ToInt32(lire.GetString("PRIX_JOUR"))));
            }
            lire.Close();
            return listChambres;
        }

        public static List<Chambre> RecupAllChambres()
        {
            MySqlCommand commande = connec.CreateCommand();
            // Récupère CHAMBRE et USER
            string req0 = "SELECT * FROM `chambres`";
            commande.CommandText = req0;

            MySqlDataReader lire = commande.ExecuteReader();
            List<Chambre> listChambres = new List<Chambre>();
            string isOccuped;
            while (lire.Read())
            {
                if(!lire.IsDBNull(1))
                {
                    isOccuped = "" + lire.GetString("NOM_COMPTE");
                }
                else
                {
                    isOccuped = "Libre";
                }
                listChambres.Add(new Chambre(Convert.ToInt32(lire.GetString("ID")), isOccuped, lire.GetString("NOMCHAMBRE"), Convert.ToInt32(lire.GetString("NBPLACESCHAMBRE")), Convert.ToInt32(lire.GetString("PRIX_JOUR"))));
            }
            lire.Close();
            return listChambres;
        }

        public static void CreerDemandeReserv(string nom_compte, int numeroDeChambre)
        {
            MySqlCommand commande = connec.CreateCommand();
            // Créé une demande de reservation
            string req0 = "INSERT INTO `Demande_Reserv`(`NOM_COMPTE`, `ID_Chambre`) VALUES ('" + nom_compte + "','" + numeroDeChambre + "')";
            commande.CommandText = req0;
            commande.ExecuteNonQuery();
        }

        public static List<Reservation> RecupDemandesReserv()
        {
            MySqlCommand commande = connec.CreateCommand();
            // Récupère les demandes de réservation
            string req0 = "SELECT * FROM `demande_reserv` WHERE est_Acceptee IS NULL";
            commande.CommandText = req0;

            List<Chambre> detailChambre = RecupAllChambres();
            MySqlDataReader lire = commande.ExecuteReader();
            List<Reservation> listDemandeReserv = new List<Reservation>();
            string nomById;
            while (lire.Read())
            {
                nomById = "";
                foreach(Chambre room in detailChambre)
                {
                    if(room.getId() == Convert.ToInt32(lire.GetString("ID_CHAMBRE")))
                    {
                        nomById = room.getNomChambre();
                    }
                }
                Reservation temp = new Reservation(lire.GetString("NOM_COMPTE"), Convert.ToInt32(lire.GetString("ID_CHAMBRE")), nomById);
                listDemandeReserv.Add(temp);
            }
            lire.Close();
            return listDemandeReserv;
        }
        public static bool AccepterReserv(int idChambre, string nomCompte)
        {
            MySqlCommand commande = connec.CreateCommand();
            // Clos une demande de reservation
            string req0 = "UPDATE `demande_reserv` SET `est_Acceptee`=1 WHERE id_chambre = " + idChambre;
            commande.CommandText = req0;
            int R1 = commande.ExecuteNonQuery();

            MySqlCommand commande1 = connec.CreateCommand();
            // Assigne la chambre
            string req1 = "UPDATE `chambres` SET `NOM_COMPTE`= '" + nomCompte + "' WHERE ID = " + idChambre;
            commande.CommandText = req1;
            int R2 = commande.ExecuteNonQuery();

            if (R1 > 0)
            {
                if (R2 > 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool RefuserReserv(int idChambre, string nomCompte)
        {
            MySqlCommand commande = connec.CreateCommand();
            // Clos une demande de reservation
            string req0 = "UPDATE `demande_reserv` SET `est_Acceptee`=1 WHERE id_chambre = " + idChambre;
            commande.CommandText = req0;
            int R1 = commande.ExecuteNonQuery();

            if (R1 > 0)
            {
                return true;
            }
            return false;
        }

        public static bool ExpulserLocataire(int idChambre)
        {
            MySqlCommand commande = connec.CreateCommand();
            // Assigne la chambre
            string req1 = "UPDATE `chambres` SET `NOM_COMPTE`= NULL WHERE ID = " + idChambre;
            commande.CommandText = req1;
            int R2 = commande.ExecuteNonQuery();

            if (R2 > 0)
            {
                return true;
            }
            return false;
        }
        public static bool SupprimmerChambre(int idChambre)
        {
            MySqlCommand commande = connec.CreateCommand();
            // Assigne la chambre
            string req1 = "DELETE FROM `chambres` WHERE `ID` = " + idChambre;
            commande.CommandText = req1;
            int R2 = commande.ExecuteNonQuery();

            if (R2 > 0)
            {
                return true;
            }
            return false;
        }
    }
}
