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
<<<<<<< HEAD
            // Ouverture de la page GestionEquipementVue.cs.
=======
            // Ouverture de la page Index.cs.
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
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
            // Ouverture de la page gestionClientView.cs.
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
