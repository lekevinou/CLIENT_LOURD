using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_LOURD
{
    public partial class GestionEquipement : Form
    {
        public GestionEquipement()
        {
            InitializeComponent();
        }

        private void VoirEquipement_Click(object sender, EventArgs e)
        {
            GestionEquipementVue f = new GestionEquipementVue();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Index f = new Index();
            this.Hide(); // Ouvre la page Index.cs.
            f.ShowDialog();
            this.Close(); // Ferme la page GestionEquipement.cs, fenêtre actuelle.
        }

        private void AjouterEquipement_Click(object sender, EventArgs e)
        {
            GestionEquipementAjout f = new GestionEquipementAjout();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
