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
        
        public gestionClientAjout()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void quitter_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            //On vérifie que les champs soient bien remplies
            if (prenomClient.Text == "" || nomClient.Text == "" || adr1Client.Text == "")
            {
                const string message = "Veuillez remplir tous les champs."; //Champs texte dans la fen
                const string caption = "Error"; //Titre fenêtre

                var mess = MessageBox.Show(message, caption,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string prenom = prenomClient.Text;
                string nom = nomClient.Text;
                string adr1 = adr1Client.Text;
                string adr2 = adr2Client.Text;
                string tel = telClient.Text;
                string mail = mailClient.Text;
                int id_ville = 1;

                client unClient = new client(0, nom, prenom, adr1, adr2, tel, mail, id_ville); //On crée un nouveau client avec les informations rentrées par l'utilisateur
                clientManager clientManager = new clientManager(); // On crée un nouveau clientManager qui va gérer les requêtes.
                clientManager.addClient(unClient); //On appelle la methode addClient avec le client que nous venons de crée en paramètre
                // La méthode va alors se charger d'ajouter en bdd le client.

                MessageBox.Show("Le client a été ajouté avec succès");
                this.Close();
            }
        }

        private void btn_VoirClients_Click(object sender, EventArgs e)
        {
            // Ouverture de la page GestionClientView.cs
            gestionClientView f = new gestionClientView();
            this.Hide();
            // Fermeture de la page actuelle.
            f.ShowDialog();
            this.Close();
        } 
    }
}
