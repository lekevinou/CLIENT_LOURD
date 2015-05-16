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
            //int idClientSelected = (int)combo_listClient.SelectedValue;


            ////On vide les items
            ////listReservationUnClient.Columns.Clear(); //On vide les columns
            ////ListView listReservationUnClient = new ListView();

            //reservationManagerOld reservationManager = new reservationManagerOld();

            //List<reservation> reservationList = new List<reservation>(); // On crée la liste de client
            //reservationList = reservationManager.getReservationClient(idClientSelected); // La liste est composé des reservation en rapport avec le client
            //clientManager clientManager = new clientManager();
            //client unClient = clientManager.getUnclient(idClientSelected);

            //if (reservationList.Count() == 0)
            //{
            //    label_noReservation.Visible = true;
            //    listReservationUnClient.Visible = false;
            //}
            //else
            //{
            //    label_noReservation.Visible = false;
            //    listReservationUnClient.Visible = true;
            //}

            //listReservationUnClient.Items.Clear();
            //foreach (reservation uneReservation in reservationList) //On parcour la liste 
            //{
            //    ListViewItem item = new ListViewItem(uneReservation.Salle_reservee.ToString());

            //    item.SubItems.Add(uneReservation.Jour_res.ToString());
            //    item.SubItems.Add(uneReservation.Heure_debut_res.ToString());
            //    item.SubItems.Add(uneReservation.Heure_fin_res.ToString());

            //    listReservationUnClient.Items.Add(item); //On ajoute les items à la ListView
            //    listReservationUnClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //}
        }

        private void viewClientReservation_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gamilonbaseDataSet1.client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.gamilonbaseDataSet1.client);

            //Au chargement de la fenêtre, on cache la liste view
            listReservationUnClient.Visible = false;
            //Au chargement de la fenêtre, on cache le libellé 
            label_noReservation.Visible = false;

            listReservationUnClient.View = View.Details;

            listReservationUnClient.Columns.Add("Salle reservée");
            listReservationUnClient.Columns.Add("Date reservation");
            listReservationUnClient.Columns.Add("Heure de début");
            listReservationUnClient.Columns.Add("heure de fin");
            //listReservationUnClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //Ajuste automatiquement la largeur des colonnes.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
