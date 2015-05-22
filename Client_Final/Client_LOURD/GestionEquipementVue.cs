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
    public partial class btnAjouterEquipement : Form
    {
        public btnAjouterEquipement()
        {
            InitializeComponent();
        }

        private void GestionEquipementVue_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_list_view_client_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_valider_recherche_Click(object sender, EventArgs e)
        {

        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            // Au clic sur le bouton rechercher, on reconstruit la listView
            string critere = text_rechercheEquipement.Text;
            equipementManager equipementManager = new equipementManager();
            List<equipement> equipementList = new List<equipement>(); // On crée la liste de client
            equipementList = equipementManager.getListEquipement(critere); // La liste se compose de la liste clientList retourné par le clientManager


            dataGridClient.Rows.Clear();
            foreach (equipement unEquipement in equipementList)
            {
                dataGridClient.Rows.Add(unEquipement.Id,
                    unEquipement.Nom,
                    unEquipement.Prix,
                    unEquipement.Reference,
                    unEquipement.Marque,
                    unEquipement.Type);
            }
        }
    }
}