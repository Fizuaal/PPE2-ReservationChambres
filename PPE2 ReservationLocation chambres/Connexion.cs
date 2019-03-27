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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void btAdminConnect_Click(object sender, EventArgs e)
        {
            Compte.ConnexionBDD();
            bool Connecte = Compte.ConnexionVerif(txtUsername.Text, txtMdp.Text);
            if (Connecte == true)
            {

            }
        }
    }
}
