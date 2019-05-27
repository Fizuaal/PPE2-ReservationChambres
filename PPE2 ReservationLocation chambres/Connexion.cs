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
    public partial class ConnexionForm : Form
    {
        public ConnexionForm()
        {
            InitializeComponent();
        }

        private void btAdminConnect_Click(object sender, EventArgs e)
        {
            GestionCompte.ConnexionBDD();
            bool Connecte = GestionCompte.ConnexionVerif(txtUsername.Text, txtMdp.Text);
            if (Connecte == true)
            {
                this.Hide();
                ClientListChambresForm listChambre = new ClientListChambresForm(txtUsername.Text);
                listChambre.Show();
            }
            else
            {
                ErreurUtilis.Visible = true;
            }
        }
    }
}
