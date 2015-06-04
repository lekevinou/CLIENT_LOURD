using System;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            nomClient.Text = nom;
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
            //On vérifie si les valeurs du formulaire ne sont pas vides ou remplies d'espaces.
            if (string.IsNullOrWhiteSpace(prenomClient.Text) || string.IsNullOrWhiteSpace(nomClient.Text) || string.IsNullOrWhiteSpace(adr1Client.Text) ||
                 string.IsNullOrWhiteSpace(ville_txt.Text) || string.IsNullOrWhiteSpace(cp_txtBox.Text) || string.IsNullOrWhiteSpace(telClient.Text) || string.IsNullOrWhiteSpace(mailClient.Text))
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
                client unClient = new client(0, nom, prenom, adr1, ville_client, cp_client, adr2, tel, mail); //On crée un nouveau client avec les informations rentrées par l'utilisateur
                clientManager clientManager = new clientManager(); // On crée un nouveau clientManager qui va gérer les requêtes.
                clientManager.addClient(unClient); //On appelle la methode addClient avec le client que nous venons de crée en paramètre
                // La méthode va alors se charger d'ajouter en bdd le client.

                gestionClient f = new gestionClient();
                MessageBox.Show("Le client a été ajouté avec succès");
                this.Hide();
                f.ShowDialog();
                this.Close();
                
            }
        }

        private void cp_txtBox_TextChanged(object sender, EventArgs e)
        {
            int tailleCP = cp_txtBox.TextLength;
            string cp = cp_txtBox.Text;

            if (tailleCP == 5) //Si la taille du CP ==5, on cache le label d'erreur
            {
                label_erreur_cp.Visible = false;
            }
            else
            {
                label_erreur_cp.Visible = true;
            }
        }
    }
}
