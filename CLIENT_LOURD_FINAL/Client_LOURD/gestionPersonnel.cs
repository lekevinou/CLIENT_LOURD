using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaBibliotheque;

namespace Client_LOURD
{
    public partial class gestionPersonnel : Form
    {
        int idPersonnel;
        personnelManager personnelManager = new personnelManager();
        List<personnel> personnelList = new List<personnel>(); // On crée la liste de personnel
        
        public gestionPersonnel()
        {
            InitializeComponent();
        }

        private void gestionPersonnel_Load(object sender, EventArgs e)
        {

            personnelList = personnelManager.afficherPersonnel();


            foreach (personnel unPersonnel in personnelList)
            {
                string ville_magasin = personnelManager.villeMagasin(unPersonnel.Id_magasin);
                string afficher = "afficher";
                dataGridPersonnel.Rows.Add(unPersonnel.Id_personnel, unPersonnel.Nom_personnel,
                unPersonnel.Prenom_personnel, ville_magasin, afficher);
                idPersonnel = Convert.ToInt32(dataGridPersonnel.CurrentRow.Cells[0].Value);
            }

        }

        private void addPersonnel_Click(object sender, EventArgs e)
        {
            gestionPersonnelAjout f = new gestionPersonnelAjout();
            this.Hide();
            f.ShowDialog();
            // Fermeture de la fenêtre actuelle.
            this.Close();
        }

        private void dataGridPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int idPersonnel = (int)dataGridPersonnel.CurrentRow.Cells[0].Value;
                personnelManager personnelManager = new personnelManager();
                personnel unPersonnel = personnelManager.getUnPersonnel(idPersonnel);
                gestionPersonnelAfficher f = new gestionPersonnelAfficher(unPersonnel);
                f.Show();

            }
        }



        

         



    }
}
