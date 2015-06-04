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
    public partial class gestionPersonnelAfficher : Form
    {
        personnel unPersonnel;

        public gestionPersonnelAfficher(personnel p_unPersonnel)
        {
            InitializeComponent();
            this.unPersonnel = p_unPersonnel;
        }

        private void gestionPersonnelAfficher_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gamilonbaseDataSet1.magasin'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.magasinTableAdapter.Fill(this.gamilonbaseDataSet1.magasin);

            nom_modif.Text = unPersonnel.Nom_personnel;
            prenom_modif.Text = unPersonnel.Prenom_personnel;
            magasin_modif.Text = unPersonnel.Prenom_personnel;
            magasin_modif.Text = unPersonnel.Id_magasin.ToString();
            adresse1_modif.Text = unPersonnel.Adr_personnel_l1;
            adresse2_modif.Text = unPersonnel.Adr_personnel_l2;
            cp_modif.Text = unPersonnel.Cp_personnel;
            ville_modif.Text = unPersonnel.Ville_personnel;
            tel_modif.Text = unPersonnel.Tel_personnel;
            mail_modif.Text = unPersonnel.Mail_personnel;
            login_modif.Text = unPersonnel.Login_personnel;

        }

        private void annuler_modif_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifier_modif_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nom_modif.Text) || string.IsNullOrWhiteSpace(prenom_modif.Text) || string.IsNullOrWhiteSpace(tel_modif.Text) ||
                  string.IsNullOrWhiteSpace(adresse1_modif.Text) || string.IsNullOrWhiteSpace(ville_modif.Text) || string.IsNullOrWhiteSpace(cp_modif.Text))
            {
                const string message = "Veuillez remplir tous les champs."; //Champs texte dans la fen
                const string caption = "Error"; //Titre fenêtre

                var mess = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = unPersonnel.Id_personnel;
                string nom = nom_modif.Text;
                string prenom = prenom_modif.Text;
                string tel = tel_modif.Text;
                string mail = unPersonnel.Mail_personnel;
                string adr1 = adresse1_modif.Text;
                string adr2 = adresse2_modif.Text;
                string ville = ville_modif.Text;
                string cp = cp_modif.Text;
                string login = unPersonnel.Login_personnel;
                string mdp = unPersonnel.Mdp_personnel;
                // voir si on peut seulement modifier certaine colonne et non pas toute dns la reques sql comme en php
                DateTime date_entree = unPersonnel.Date_entree;
                int id_magasin = unPersonnel.Id_magasin;
                int id_poste = unPersonnel.Id_poste;
                int id_statut = unPersonnel.Id_statut;

                personnel unPersonnelAModifier = new personnel(id, nom, prenom, tel, mail, adr1, adr2, ville, cp, login, mdp, date_entree, id_magasin, id_poste, id_statut);
                personnelManager personnelManager = new personnelManager();
                personnelManager.editPersonnel(unPersonnelAModifier);

                MessageBox.Show("Le client a été modifié avec succès");
                this.Close();

            }
        }


    }
}
