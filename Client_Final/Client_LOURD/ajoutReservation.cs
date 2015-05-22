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
    public partial class ajoutReservation : Form
    {
        int test = 0;
        int id_client;
        int critere;
        int id_equipement = 0;

        public ajoutReservation()
        {
            InitializeComponent();
        }

        private void AjoutReservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gamilonbaseDataSet1.type_equipement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.type_equipementTableAdapter.Fill(this.gamilonbaseDataSet1.type_equipement);
            // TODO: cette ligne de code charge les données dans la table 'gamilonbaseDataSet1.equipement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.equipementTableAdapter.Fill(this.gamilonbaseDataSet1.equipement);
            this.sallesTableAdapter.Fill(this.gamilonbaseDataSet1.salles);
            // TODO: cette ligne de code charge les données dans la table 'gamilonbaseDataSet1.client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.gamilonbaseDataSet1.client);
        }

        private void ajoutReservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            //cb_equipement.ValueMember = null;
        }

        private void btn_recherche_nom_Click_1(object sender, EventArgs e)
        {
             // Au clic sur le bouton rechercher, on construit la listView
            string critere = textBox_recherche_nom.Text;
            clientManager clientManager = new clientManager();
            List<client> clientList = new List<client>(); // On crée la liste de client
            clientList = clientManager.getListClient(critere); // La liste se compose de la liste clientList retourné par le clientManager

            dataGridView_client.Rows.Clear();
            foreach (client unClient in clientList)
            {
                dataGridView_client.Rows.Add(unClient.Id, unClient.Nom, unClient.Prenom);
            }

            test = 1;
        }

        private void Gridview_Client_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (test == 0)
            {

            }
            else
            {
                textBox_Nom.Text = dataGridView_client.CurrentRow.Cells[1].Value.ToString();
                textBox_Prenom.Text = dataGridView_client.CurrentRow.Cells[2].Value.ToString();
                id_client = Convert.ToInt32(dataGridView_client.CurrentRow.Cells[0].Value);
                dataGridView_client.Rows.Clear();
                test = 0;
            }
        }

        private void btn_ajouter_reservation_Click(object sender, EventArgs e)
        {
            DateTime heure_deb = Convert.ToDateTime(dateTimePicker_heure_debut.Value);
            DateTime heure_fin = Convert.ToDateTime(dateTimePicker_heure_fin.Value);
            int minute_deb = Convert.ToInt32(dateTimePicker_heure_debut.Value.Minute);
            int minute_fin = Convert.ToInt32(dateTimePicker_heure_fin.Value.Minute);
            DateTime date_jour = DateTime.Now;


            if (string.IsNullOrWhiteSpace(textBox_Nom.Text) || string.IsNullOrWhiteSpace(textBox_Prenom.Text))
            {
                const string message = "Veuillez remplir tous les champs."; //Champs texte dans la fen
                const string caption = "Error"; //Titre fenêtre

                var mess = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (heure_fin < heure_deb)
            {
                const string message_heure = "L'heure de fin ne peut pas être inférieure à l'heure de début."; //Champs texte dans la fen
                const string caption_heure = "Error"; //Titre fenêtre

                var mess = MessageBox.Show(message_heure, caption_heure, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (minute_deb != 00 || minute_fin != 00)
            {
                const string message_minute = "Vous ne pouvez entrer que des heures entières"; //Champs texte dans la fen
                const string caption_minute = "Error"; //Titre fenêtre

                var mess = MessageBox.Show(message_minute, caption_minute, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (date_jour > dateTimePicker_jour.Value)
            {
                const string message_jour = "Vous ne pouvez pas faire de réservation pour un jour déjà passé"; //Champs texte dans la fen
                const string caption_jour = "Error"; //Titre fenêtre

                var mess = MessageBox.Show(message_jour, caption_jour, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime jour_res = dateTimePicker_jour.Value.Date;
                DateTime heure_debut_res = Convert.ToDateTime(dateTimePicker_heure_debut.Value);
                DateTime heure_fin_res = Convert.ToDateTime(dateTimePicker_heure_fin.Value);
          
                int id_salle = int.Parse(cbSalle.SelectedValue.ToString());
                int id_magasin = 1;
                
                reservation uneReservation = new reservation(0, jour_res, heure_debut_res, heure_fin_res, id_client, id_salle, id_magasin); //On crée une nouvelle réservation avec les informations rentrées par l'utilisateur
                reservationManager reservationManager = new reservationManager(); // On crée un nouveau reservationManager qui va gérer les requêtes.
                reservationManager.addReservation(uneReservation); //On appelle la methode addReservation avec la réservation que nous venons de crée en paramètre
                // La méthode va alors se charger d'ajouter en bdd la réservation.



                MessageBox.Show("La réservation a été ajouté avec succès");
                this.Close();
            }

            for (int i = 0; i < dataGridView_equipements_choisis.Rows.Count; i++)
            {
                id_equipement = Convert.ToInt32(dataGridView_equipements_choisis.Rows[i].Cells[0].Value);
                fournit unFournit = new fournit(0, id_equipement, 0);
                fournitManager fournitManager = new fournitManager();
                fournitManager.addFournit(unFournit);

            }
        
        }

        private void cb_equipement_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView_equipement.Rows.Clear();
            // Au clic sur le bouton rechercher, on construit la listView

            id_equipement = Convert.ToInt32(cb_equipement.SelectedValue.ToString());
            equipementManager equipementManager = new equipementManager();
            List<equipement> equipementList = new List<equipement>(); // On crée la liste de client
            equipementList = equipementManager.getListEquipement(id_equipement); // La liste se compose de la liste clientList retourné par le clientManager

            foreach (equipement unEquipement in equipementList)
            {
                dataGridView_equipement.Rows.Add(unEquipement.Id, unEquipement.Nom, unEquipement.Prix);
            }
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_equipement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_equipement.CurrentRow.Cells[0].Value);

            equipementManager equipementManager = new equipementManager();
            equipement monEquipement = equipementManager.getUnequipement(id);

            dataGridView_equipements_choisis.Rows.Add(monEquipement.Id,
                monEquipement.Nom,
                monEquipement.Prix,
                "Supprimer");
        }

        private void dataGridView_equipements_choisis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) //Si on clique sur une cellule de la colonne d'index 3
            {
                DataGridViewRow row = dataGridView_equipements_choisis.CurrentRow;

                dataGridView_equipements_choisis.Rows.Remove(row);

            }
        }
    }
}
