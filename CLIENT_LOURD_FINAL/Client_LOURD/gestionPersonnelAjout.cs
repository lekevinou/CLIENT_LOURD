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
    public partial class gestionPersonnelAjout : Form
    {
        public gestionPersonnelAjout()
        {
            InitializeComponent();
        }

        private void gestionPersonnelAjout_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gamilonbaseDataSet1.poste'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.posteTableAdapter.Fill(this.gamilonbaseDataSet1.poste);
            // TODO: cette ligne de code charge les données dans la table 'gamilonbaseDataSet1.magasin'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.magasinTableAdapter.Fill(this.gamilonbaseDataSet1.magasin);

        }

        private void ajouterPersonnel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nomPersonnel.Text) || string.IsNullOrWhiteSpace(prenomPersonnel.Text) || string.IsNullOrWhiteSpace(telPersonnel.Text) ||
                  string.IsNullOrWhiteSpace(adr1Personnel.Text) || string.IsNullOrWhiteSpace(villePersonnel.Text) || string.IsNullOrWhiteSpace(cpPersonnel.Text))
            {
                const string message = "Veuillez remplir tous les champs."; //Champs texte dans la fen
                const string caption = "Error"; //Titre fenêtre

                var mess = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
            else
            {
                string prenom_personnel = prenomPersonnel.Text;
                string nom_personnel = nomPersonnel.Text;
                string adresse1_personnel = adr1Personnel.Text;
                string adresse2_personnel = adr2Personnel.Text;
                string tel_personnel = telPersonnel.Text;
                string mail_personnel = prenom_personnel.ToLower() + "." + nom_personnel.ToLower() + "@gamilon.fr";
                string ville_personnel = villePersonnel.Text;
                string cp_personnel = cpPersonnel.Text;
                string login_personnel = prenom_personnel.ToLower().Substring(0, 3) + "." + nom_personnel.ToLower();
                string mdp_personnel = "azerty";
                DateTime date_entree_personnel = date_entree.Value.Date;
                int id_magasin = int.Parse(magasinPersonnel.SelectedValue.ToString());
                int id_poste = int.Parse(postePersonnel.SelectedValue.ToString());
                int id_statut = 2;

                personnel unPersonnel = new personnel(0, nom_personnel, prenom_personnel, tel_personnel, mail_personnel, adresse1_personnel, adresse2_personnel, ville_personnel, cp_personnel, login_personnel, mdp_personnel, date_entree_personnel, id_magasin, id_poste, id_statut);
                personnelManager personnelManager = new personnelManager(); // On crée un nouveau clientManager qui va gérer les requêtes.
                personnelManager.addPersonnel(unPersonnel); //On appelle la methode addClient avec le client que nous venons de crée en paramètre
                // La méthode va alors se charger d'ajouter en bdd le client.

                MessageBox.Show("Le client a été ajouté avec succès");
                this.Close();
            }
                 

        }
    }
}
