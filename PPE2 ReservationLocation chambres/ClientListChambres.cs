using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE2_ReservationLocation_chambres
{
    public partial class ClientListChambresForm : Form
    {
        public string profilValide { get; set; }
        internal List<Chambre> listChambresPourProfil;
        internal List<Reservation> listDemandeReserv;
        public ClientListChambresForm(string nomConnexion)
        {
            InitializeComponent();
            profilValide = nomConnexion;
            GestionCompte.ConnexionBDD();
            string[] paramCompte = GestionCompte.ConnexionRecupParamCompte(nomConnexion);
            lblConnecte.Text = "Vous êtes connecté en temps que " + paramCompte[0] + " | " + paramCompte[1];
            GestionChambre.ConnexionBDD();
            UpdateLists();
        }

        private void ClientListChambresForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btDemandeReserv_Click(object sender, EventArgs e)
        {
            string[] paramCompte = GestionCompte.ConnexionRecupParamCompte(profilValide);
            GestionChambre.CreerDemandeReserv(paramCompte[0], Convert.ToInt32(((Chambre)lbChambres.SelectedItem).getId()));
            MessageBox.Show("Votre demande à été prise en compte");
            UpdateLists();
        }

        private void UpdateLists()
        {
            string[] paramCompte = GestionCompte.ConnexionRecupParamCompte(profilValide);
            if (paramCompte[1] == "Admin")
            {
                listChambresPourProfil = GestionChambre.RecupAllChambres();
                lblChambresList.Text = "Liste de toutes les chambres";
                listDemandeReserv = GestionChambre.RecupDemandesReserv();
                lbDemandeReserv.DataSource = listDemandeReserv;
                if(listDemandeReserv.Count == 0)
                {
                    btAccepter.Visible = false;
                    btRefuser.Visible = false;
                }
                else
                {
                    btAccepter.Visible = true;
                    btRefuser.Visible = true;
                }
                btSupprChambre.Visible = true;
                btNewChambre.Visible = false;
                btDemandeReserv.Visible = false;
            }
            else
            {
                btSupprChambre.Visible = false;
                btNewChambre.Visible = false;
                btAccepter.Visible = false;
                btRefuser.Visible = false;
                listChambresPourProfil = GestionChambre.RecupChambresVides();
                lbDemandeReserv.Visible = false;
                lblDemandeReserv.Visible = false;
            }
            lbChambres.DataSource = listChambresPourProfil;
        }

        private void btAccepter_Click(object sender, EventArgs e)
        {
            string[] paramCompte = GestionCompte.ConnexionRecupParamCompte(profilValide);
            int idChambre = Convert.ToInt32(((Reservation)lbDemandeReserv.SelectedItem).getIdChambre());
            if(GestionChambre.AccepterReserv(idChambre, ((Reservation)lbDemandeReserv.SelectedItem).getNomCompte()) == true)
            {
                MessageBox.Show("La réservation à été acceptée");
                UpdateLists();
            }
            else
            {
                MessageBox.Show("La requète n'a pas abouti");
                UpdateLists();
            }
        }

        private void btRefuser_Click(object sender, EventArgs e)
        {
            string[] paramCompte = GestionCompte.ConnexionRecupParamCompte(profilValide);
            int idChambre = Convert.ToInt32(((Reservation)lbDemandeReserv.SelectedItem).getIdChambre());
            if (GestionChambre.RefuserReserv(idChambre, ((Reservation)lbDemandeReserv.SelectedItem).getNomCompte()) == true)
            {
                MessageBox.Show("La réservation à été refusée");
                UpdateLists();
            }
            else
            {
                MessageBox.Show("La requète n'a pas abouti");
                UpdateLists();
            }
        }

        private void btExpulser_Click(object sender, EventArgs e)
        {
            int idChambre = Convert.ToInt32(((Chambre)lbChambres.SelectedItem).getId());
            if (GestionChambre.ExpulserLocataire(idChambre) == true)
            {
                MessageBox.Show("Le locataire a bien été expulsé");
                UpdateLists();
            }
            else
            {
                MessageBox.Show("La requète n'a pas abouti");
                UpdateLists();
            }
        }

        private void btNewChambre_Click(object sender, EventArgs e)
        {

        }

        private void btSupprChambre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Etes-vous sûr ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                int idChambre = Convert.ToInt32(((Chambre)lbChambres.SelectedItem).getId());
                if (GestionChambre.SupprimmerChambre(idChambre) == true)
                {
                    MessageBox.Show("La chambre à été supprimée");
                    UpdateLists();
                }
                else
                {
                    MessageBox.Show("La requète n'a pas abouti");
                    UpdateLists();
                }
            }
        }
    }
}
