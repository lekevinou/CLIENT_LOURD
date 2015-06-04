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
    public partial class gestionClientView : Form
    {
        
        public gestionClientView()
        {
            InitializeComponent();
        }

        public void reloadDatagridView()
        {
            dataGridClient.Refresh();
            dataGridClient.Update();
        }
        private void viewClient_Load(object sender, EventArgs e)
        {
            dataGridClient.Rows.Clear(); //On vide la datagridView
            string critere = "";
            clientManager clientManager = new clientManager();
            List<client> clientList = new List<client>(); // On crée la liste de client
            clientList = clientManager.getListClient(critere); // La liste se compose de la liste clientList retourné par le clientManager

            foreach (client unClient in clientList)
            {
                dataGridClient.Rows.Add(unClient.Nom,
                    unClient.Prenom,
                    unClient.Adresse1,
                    unClient.Ville_client,
                    unClient.Adresse2,
                    unClient.Tel,
                    unClient.Mail,
                    "Modifier",
                    "Supprimer",
                    unClient.Id);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Ouverture de la page viewClient.cs.
            gestionClientAjout f = new gestionClientAjout();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void btn_valider_recherche_Click(object sender, EventArgs e)
        {
            // Au clic sur le bouton rechercher, on reconstruit la listView
            string critere = text_rechercheClient.Text;
            clientManager clientManager = new clientManager();
            List<client> clientList = new List<client>(); // On crée la liste de client
            clientList = clientManager.getListClient(critere); // La liste se compose de la liste clientList retourné par le clientManager

            dataGridClient.Rows.Clear();
            foreach (client unClient in clientList)
            {
                dataGridClient.Rows.Add(unClient.Nom,
                    unClient.Prenom,
                    unClient.Adresse1,
                    unClient.Ville_client,
                    unClient.Adresse2,
                    unClient.Tel,
                    unClient.Mail,
                    "Modifier",
                    "Supprimer",
                    unClient.Id);
            }
        }

        private void btn_refresh_list_view_client_Click(object sender, EventArgs e)
        {
            dataGridClient.Rows.Clear();
            viewClient_Load(sender, e);
            
            text_rechercheClient.Text = string.Empty;

        }

        private void back_fromViewClient_Click(object sender, EventArgs e)
        {
            // Ouverture de la page viewClient.cs.
            gestionClient f = new gestionClient();
            this.Hide();
            f.ShowDialog();
            // Fermeture de la page actuelle.
            this.Close();
        }

        private void dataGridClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7 ) //Si on clique sur une cellule de la colonne d'index 7 (modifier)
            {
                int id_client = (int)dataGridClient.CurrentRow.Cells[9].Value;

                clientManager clientManager = new clientManager();
                client unClient = clientManager.getUnclient(id_client);

                gestionClientModif f = new gestionClientModif(unClient);
                f.Show();
                
            }
            if (e.ColumnIndex == 8) //Si on clique sur une cellule de la colonne d'index 7 (supprimer)
            {


                DialogResult result = MessageBox.Show("Voulez vous supprimer ce client ?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    int id_client = (int)dataGridClient.CurrentRow.Cells[9].Value;
                    clientManager clientManager = new clientManager();
                    client unClient = clientManager.getUnclient(id_client);
                    fournitManager fournitManager = new fournitManager();
                    reservationManager reservationManager = new reservationManager();
                    List<reservation> reservationList = new List<reservation>();
                    //On récupère chaque reservation du client
                    reservationList = reservationManager.getReservationsParClient(id_client);
                    foreach (reservation uneReservation in reservationList)
                    {
                        //pour chaque numéro de reservation
                        //Suppression de toutes les données dans la table fournit
                        fournitManager.supprimerFournit(uneReservation.Num_reservation);
                    }

                    //On supprime toutes les reservations du client
                    reservationManager.supprimerReservation(id_client);
                    clientManager.supprimerClient(unClient);
                    viewClient_Load(null, null); //On appelle la méthode qui recharge la page
                    //et donc la datagridView
                }
            }
        }
    }
}
