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
    public partial class Index : Form
    {
        string usernameMagasin;
        public Index(string p_usernameMagasin="")
        {
            InitializeComponent();
            this.usernameMagasin = p_usernameMagasin;
        }

        private void btn_ajouterClient_Click(object sender, EventArgs e)
        {
            gestionClientAjout AjouterClient = new gestionClientAjout();
            AjouterClient.Show(); // ouvre la fenêtre ajoutClient.cs
        }

        private void Index_Load(object sender, EventArgs e)
        {
            //On récupère la valeur de la text box correspondant au magasin connecté.
            login log = new login();
            //this.Close();
            //MessageBox.Show(usernameMagasin);
            labelMagasinAffiche.Text = usernameMagasin;
        }

        private void vueClient_btn_Click(object sender, EventArgs e)
        {
            gestionClientView ViewClient = new gestionClientView();
            ViewClient.Show();
        }

        private void btn_viewReservation_Click(object sender, EventArgs e)
        {
            viewClientReservation ViewClientReservation = new viewClientReservation();
            ViewClientReservation.Show();
        }

        private void btn_EquipementSup_Click(object sender, EventArgs e)
        {
            // Ouverture de la page GestionEquipement.cs.
            GestionEquipement f = new GestionEquipement();
            this.Hide();
            f.ShowDialog();
            // Fermeture de la page actuelle.
            this.Close();
        }

        private void _Click(object sender, EventArgs e)
        {
            // Ouverture le la gestion des client
            gestionClient f = new gestionClient();
            this.Hide();
            f.ShowDialog();
            // Fermeture de la fenêtre actuelle.
            this.Close();
        }
    }
}
