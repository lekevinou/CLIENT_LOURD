﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaBibliotheque;

namespace Client_LOURD
{
    public partial class gestionClientAjout : Form
    {
        string nom;
        public gestionClientAjout(string p_nom ="")
        {
            InitializeComponent();
            this.nom = p_nom;
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            // Ouverture de la page viewClient.cs.
            gestionClient f = new gestionClient();
            this.Hide();
            f.ShowDialog();
            // Fermeture de la page actuelle.
            this.Close();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            //TODO à modifier, prendre la méthode de RAKO
            //
            //
            //On vérifie que les champs soient bien remplies
            if (prenomClient.Text == "" || nomClient.Text == "" || adr1Client.Text == "")
            {
                const string message = "Veuillez remplir tous les champs."; //Champs texte dans la fen
                const string caption = "Error"; //Titre fenêtre

                var mess = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string prenom = prenomClient.Text;
                string nom = nomClient.Text;
                string adr1 = adr1Client.Text;
                string ville_client = ville_txt.Text;
                string cp_client = cp_txtBox.Text;
                string adr2 = adr2Client.Text;
                string tel = telClient.Text;
                string mail = mailClient.Text;
<<<<<<< HEAD
                //int id_ville = (int)ville_cbbox.SelectedValue;
                //int id_ville;
                //id_ville = Convert.ToInt32(ville_cbbox.ValueMember);

                client unClient = new client(0, nom, prenom, adr1, ville_client, cp_client, adr2, tel, mail); //On crée un nouveau client avec les informations rentrées par l'utilisateur
=======
                int id_ville = 1;

                client unClient = new client(0, nom, prenom, adr1, adr2, tel, mail, id_ville); //On crée un nouveau client avec les informations rentrées par l'utilisateur
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
                clientManager clientManager = new clientManager(); // On crée un nouveau clientManager qui va gérer les requêtes.
                clientManager.addClient(unClient); //On appelle la methode addClient avec le client que nous venons de crée en paramètre
                // La méthode va alors se charger d'ajouter en bdd le client.

                MessageBox.Show("Le client a été ajouté avec succès");
                this.Close();
            }
        }

<<<<<<< HEAD
        private void cp_txtBox_TextChanged(object sender, EventArgs e)
        {
            int tailleCP = cp_txtBox.TextLength;
            string cp = cp_txtBox.Text;
            //ville_cbbox.Items.Clear();

            if (tailleCP == 5) //Si la taille du CP ==5, on cache le label d'erreur
            {
                //ville_cbbox.Items.Add(cp_txtBox.Text);
                label_erreur_cp.Visible = false;

                //cp_villeManager cp_villeManager = new cp_villeManager();
                //List<cp_ville> cp_villeList = new List<cp_ville>();
                //cp_villeList = cp_villeManager.getCP_VILLE(cp);

                //foreach (cp_ville Uncp_ville in cp_villeList)
                //{
                //    ville_cbbox.Items.Add(Uncp_ville.Nom_ville.ToString()); //La valeur affiché dans la combo, est la ville
                //    int id_ville = (int)Uncp_ville.Id_ville;
                //    ville_cbbox.ValueMember = id_ville.ToString(); //La valeur caché de la combo sera l'id de la ville
                //}
            }
            else
            {
                label_erreur_cp.Visible = true;
                //ville_cbbox.Items.Clear();
            }




        }

        private void ville_cbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ville_cbbox.Items.Add(cp_txtBox.Text);
            //if(label_erreur_cp.Visible == false)
            //{
            //    ville_cbbox.Items.Add(cp_txtBox.Text);
            //}
        }
=======
        private void btn_VoirClients_Click(object sender, EventArgs e)
        {
            // Ouverture de la page GestionClientView.cs
            gestionClientView f = new gestionClientView();
            this.Hide();
            // Fermeture de la page actuelle.
            f.ShowDialog();
            this.Close();
        } 
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
    }
}
