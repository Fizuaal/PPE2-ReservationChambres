using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE2_ReservationLocation_chambres
{
    class Reservation
    {
        private string nomCompte;
        private int idChambre;
        private string nomChambre;

        public Reservation(string nomCompteBase, int idChambreBase, string nomChambreBase)
        {
            nomCompte = nomCompteBase;
            idChambre = idChambreBase;
            nomChambre = nomChambreBase;
        }

        public int getIdChambre()
        {
            return idChambre;
        }
        public string getNomCompte()
        {
            return nomCompte;
        }
        public override string ToString()
        {
            return "" + nomCompte + " veut réserver " + nomChambre;
        }
    }
}
