using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE2_ReservationLocation_chambres
{
    class Chambre
    {
        private int id;
        private string nomCompte;
        private string nomChambre;
        private int nbrPlaces;
        private int prixJournee;

        public Chambre(int idBase, string nomCompteBase, string nomChambreBase, int nbrPlacesBase, int prixJourneeBase)
        {
            id = idBase;
            nomCompte = nomCompteBase;
            nomChambre = nomChambreBase;
            nbrPlaces = nbrPlacesBase;
            prixJournee = prixJourneeBase;
        }

        public Chambre(int idBase, string nomChambreBase, int nbrPlacesBase, int prixJourneeBase)
        {
            id = idBase;
            nomCompte = "Libre";
            nomChambre = nomChambreBase;
            nbrPlaces = nbrPlacesBase;
            prixJournee = prixJourneeBase;
        }
        public int getId()
        {
            return id;
        }
        public string getNomChambre()
        {
            return nomChambre;
        }
        public override string ToString()
        {
            return "" + nomChambre + " - " + nbrPlaces + " Personnes - "
                    + prixJournee + "€/Jour - " + nomCompte;
        }
    }
}
