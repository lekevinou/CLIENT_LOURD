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
    public partial class gestionClient : Form
    {
        public gestionClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ouverture de la page GestionEquipementVue.cs.
            Index f = new Index();
            this.Hide();
            f.ShowDialog();
            // Fermeture de la page actuelle.
            this.Close();
        }

        private void btn_ajouterClient_Click(object sender, EventArgs e)
        {
            gestionClientAjout f = new gestionClientAjout();
            this.Hide();
            f.ShowDialog();
            // Fermeture de la fenêtre actuelle.
            this.Close();
        }
        private void vueClient_btn_Click(object sender, EventArgs e)
        {
            // Ouverture de la page viewClient.cs.
            gestionClientView f = new gestionClientView();
            this.Hide();
            f.ShowDialog();
            // Fermeture de la page actuelle.
            this.Close();
        }

        private void btn_vue_journee_Click(object sender, EventArgs e)
        {
            VueJournee vueJournee = new VueJournee();
            vueJournee.Show();
        }
    }
}
