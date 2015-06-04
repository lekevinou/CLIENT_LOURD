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
    public partial class VueJournee : Form
    {
        int id_magasin;
        public VueJournee()
        {
            
            InitializeComponent();
            id_magasin = 1;
        }

        private void VueJournee_Load(object sender, EventArgs e)
        {
            //Definition des couleurs pour la légende à droite de la Form
            this.reservee_rectangle.BackColor = System.Drawing.Color.Crimson;
            this.libre_rectangle.BackColor = System.Drawing.Color.White;

            DateTime aujourdhui = DateTime.Now;
            int jj_today = aujourdhui.Day;
            int mm_today = aujourdhui.Month;
            int aaaa_today = aujourdhui.Year;

            numericUpDown_jj.Value = jj_today;
            numericUpDown_mm.Value = mm_today;
            numericUpDown_aaaa.Value = aaaa_today;

            salleManager salleManager = new salleManager();
            List<salle> sallesList = new List<salle>();
            sallesList = salleManager.getListSalles(); //Récupération des Salles du magasin connecté

            foreach(salle uneSalle in sallesList) //On remplit les colonnes du datagridview
            {
                datagridview_ParJour.Columns.Add(uneSalle.Libelle_salle, uneSalle.Libelle_salle.ToString().ToUpper());
            }       

            for (int i = 14; i < 24; i++ ) //Ajout des horaires dans la première colonne
            {
                datagridview_ParJour.Rows.Add(i + ":00:00");
            }
            
            traitementDateVersDatagrid(null, null);

        }
        private void traitementDateVersDatagrid(object sender, EventArgs e)
        {
            //On récupère le jour mois et année des numericUpDown
            //Puis, on initialise l'objet date avec l'année, le mois et le jours
            int annee = (int)numericUpDown_aaaa.Value;
            int mois = (int)numericUpDown_mm.Value;
            int jour = (int)numericUpDown_jj.Value;
            DateTime date = new DateTime(annee, mois, jour, 0, 0, 0); // C'est la date qu'on passera en paramètre de la méthode

            reservationManager reservationManager = new reservationManager();
            List<reservation> listeReservations = new List<reservation>();
            //On remplit la liste de reservations avec la méthode qui récupère
            // toutes les reservations en fonction de la date
            listeReservations = reservationManager.getReservationsDateSalle(date, id_magasin);

            //Coloration d'une celulle d'un datagridView
            DataGridViewCellStyle StyleReservee = new DataGridViewCellStyle(datagridview_ParJour.Rows[1].DefaultCellStyle);
            StyleReservee.BackColor = Color.Crimson;

            if (listeReservations.Count > 0) //Si la liste de reservation n'est pas vide
            {
                foreach (reservation uneReservation in listeReservations)
                {
                    int Heure_debut_res = uneReservation.Heure_debut_res.Hour; //On récupère seulement l'heure du début de la reservation
                    int Heure_fin_res = uneReservation.Heure_fin_res.Hour; //On récupère seulement l'heure de la fin de reservation
                    int diffFinDebut = Heure_fin_res - Heure_debut_res; //La différence entre la fin et le début
                    int id_salle = uneReservation.Id_salle;
                    int colonne = 0;

                    for (int i = 0; i < datagridview_ParJour.Rows.Count; i++) //On parcours chaque ligne du tableau
                    {
                        //celluleAtester correspond à l'heure de chaque ligne
                        string celluleAtester = datagridview_ParJour.Rows[i].Cells[0].Value.ToString();
                        if (celluleAtester == Heure_debut_res + ":00:00") //Si l'heure = heure de début de la réservation
                        {
                            //On test la valeur de l'id de la salle
                            //colonne prend la valeur de la colonne qui sera remplit en fonction de la salle
                            //Par exemple: id_salle = 1 alors colonne = 1 alors salle = Amateur
                            switch (id_salle)
                            {
                                case 1:
                                    colonne = 1;
                                    break;
                                case 2:
                                    colonne = 2;
                                    break;
                                case 3:
                                    colonne = 3;
                                    break;
                                case 4:
                                    colonne = 4;
                                    break;
                            }

                            client unClient = reservationManager.GetClientQuiAReserve(uneReservation.Id_client);
                            datagridview_ParJour.Rows[i].Cells[colonne].Style = StyleReservee; //On colore la case de la salle reservée

                            //On remplit la case du nom et prénom du client
                            datagridview_ParJour.Rows[i].Cells[colonne].Value = unClient.Nom.ToUpper() + " - " + unClient.Prenom;

                            diffFinDebut--; //On enleve 1 à la différence entre fin et début de reservation
                            int j = i;
                            while (diffFinDebut > 0) //on remplit les cellules suivantes pour chaque heure qu'il y a après celle du début
                            {
                                
                                datagridview_ParJour.Rows[j + 1].Cells[colonne].Style = StyleReservee;
                                datagridview_ParJour.Rows[j + 1].Cells[colonne].Value = unClient.Nom.ToUpper() + " - " + unClient.Prenom;
                                diffFinDebut--;
                                j++;
                            }
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //On re initialise la couleurs de toutes les cellules de la datagridview
            DataGridViewCellStyle Style = new DataGridViewCellStyle(datagridview_ParJour.Rows[1].DefaultCellStyle);
            Style.BackColor = Color.White;
            for (int i = 0; i < datagridview_ParJour.Rows.Count; i++) //On parcourt chaque ligne
            {
                for (int j = 0; j < datagridview_ParJour.Rows[i].Cells.Count; j++ ) //On parcours chaque cellule de la ligne en cours
                {
                    datagridview_ParJour.Rows[i].Cells[j].Style = Style;
                } 
            }

            //On vide le tableau
            for (int i = 0; i < datagridview_ParJour.Rows.Count; i++) //On parcourt chaque ligne
            {
                for (int j = 1; j < datagridview_ParJour.Rows[i].Cells.Count; j++) //On parcours chaque cellule de la ligne en cours (sauf la 1ère (colonne 1 =heures))
                {
                    datagridview_ParJour.Rows[i].Cells[j].Value = null;
                } 
            }
            
            traitementDateVersDatagrid(null, null);
        }

        private void datagridview_ParJour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewImageCell cell = (DataGridViewImageCell) datagridview_ParJour.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //MessageBox.Show(cell.Value.ToString());
            //if (datagridview_ParJour.CurrentCell.Value != null)
            //{
                
            //    MessageBox.Show(datagridview_ParJour.CurrentCell.Value.ToString());
            //    gestionClientAjout f = new gestionClientAjout(datagridview_ParJour.CurrentCell.Value.ToString());
            //    f.Show();
            //}
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ouverture de la page viewClient.cs.
            gestionClient f = new gestionClient();
            this.Hide();
            f.ShowDialog();
            // Fermeture de la page actuelle.
            this.Close();
        }
    }
}
