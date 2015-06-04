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
    public partial class viewClientReservation : Form
    {
        public viewClientReservation()
        {
            InitializeComponent();
        }

        private void btn_view_reservation_Click(object sender, EventArgs e)
        {
            int idClientSelected = (int)combo_listClient.SelectedValue;

            listReservationUnClient.Columns.Clear(); //On vide les columns
            listReservationUnClient.Items.Clear();

            listReservationUnClient.Visible = true;
            listReservationUnClient.View = View.Details;
            listReservationUnClient.Columns.Add("Salle reservée");
            listReservationUnClient.Columns.Add("Date reservation");
            listReservationUnClient.Columns.Add("Heure de début");
            listReservationUnClient.Columns.Add("heure de fin");

            reservationManager reservationManager = new reservationManager();
            List<reservation> reservationList = new List<reservation>(); // On crée la liste de client
            // La liste remplit avec la méthode getReservationParClient
            reservationList = reservationManager.getReservationsParClient(idClientSelected); 
            
            if (reservationList.Count() == 0) //Si la liste ne contient aucune valeurs
            {
                //Pas de reservation donc on affiche un labe
                label_noReservation.Visible = true; //Label qui dit qu'il n'y a aucune reservation
                listReservationUnClient.Visible = false;//On cache la listeView
            }
            else //Sinon si elle en contient
            {
                label_noReservation.Visible = false; //On cache le label
                listReservationUnClient.Visible = true; //On affiche la listeView
            }

            foreach (reservation uneReservation in reservationList) //On parcour la liste 
            {
                salleManager salleManager = new salleManager();
                //On recupère le libellé de la salle correspondant à l'id dans la reservation
                string libelle_salle = salleManager.libelleSalle(uneReservation.Id_salle); 

                ListViewItem item = new ListViewItem(libelle_salle.ToString());
                item.SubItems.Add(uneReservation.Jour_res.ToString("dd/MM/yyyy"));
                item.SubItems.Add(uneReservation.Heure_debut_res.ToString("HH:mm"));
                item.SubItems.Add(uneReservation.Heure_fin_res.ToString("HH:mm"));

                listReservationUnClient.Items.Add(item); //On ajoute les items à la ListView
                listReservationUnClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void viewClientReservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gamilonbaseDataSet1.client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.gamilonbaseDataSet1.client);

            //Au chargement de la fenêtre, on cache la liste view
            listReservationUnClient.Visible = false;
            //Au chargement de la fenêtre, on cache le libellé 
            label_noReservation.Visible = false;

            //listReservationUnClient.View = View.Details;

            //listReservationUnClient.Columns.Add("Salle reservée");
            //listReservationUnClient.Columns.Add("Date reservation");
            //listReservationUnClient.Columns.Add("Heure de début");
            //listReservationUnClient.Columns.Add("heure de fin");
            //listReservationUnClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //Ajuste automatiquement la largeur des colonnes.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
