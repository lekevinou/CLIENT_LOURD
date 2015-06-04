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
    public partial class gestionClientModif : Form
    {
        client unClient;
        //clientManager clientManager = new clientManager();
        //string cp_client;
        
        public gestionClientModif(client p_unClient)
        {
            InitializeComponent();
            this.unClient = p_unClient;
            //cp_client = clientManager.getCPClient(ListclientSelectionne[3], ListclientSelectionne[6]); //Recupère le CP en fonction de la ville et de l'email du client.
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            prenomClient.Text = unClient.Prenom;
            nomClient.Text = unClient.Nom;
            adr1Client.Text = unClient.Adresse1;
            ville_txt.Text = unClient.Ville_client;
            adr2Client.Text = unClient.Adresse2;
            telClient.Text = unClient.Tel;
            mailClient.Text = unClient.Mail;
            cp_txtBox.Text = unClient.Cp_client;

        }
        private void quitter_Click(object sender, EventArgs e)
        {
            // this.Hide();
            // Ouverture de la page viewClient.cs.
            //gestionClient f = new gestionClient();
            this.Hide();
            //f.ShowDialog();
            // Fermeture de la page actuelle.
            this.Close();
        }

        private void modifier_Click(object sender, EventArgs e)
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
                int id_client = unClient.Id;
                string prenom = prenomClient.Text;
                string nom = nomClient.Text;
                string adr1 = adr1Client.Text;
                string ville_client = ville_txt.Text;
                string cp_client = cp_txtBox.Text;
                string adr2 = adr2Client.Text;
                string tel = telClient.Text;
                string mail = mailClient.Text;

                client unClientAModif = new client(id_client, nom, prenom, adr1, ville_client, cp_client, adr2, tel, mail); //On crée un nouveau client avec les informations rentrées par l'utilisateur
                clientManager clientManager = new clientManager(); // On crée un nouveau clientManager qui va gérer les requêtes.
                clientManager.editClient(unClientAModif); //On appelle la methode addClient avec le client que nous venons de crée en paramètre
                // La méthode va alors se charger d'ajouter en bdd le client.

                MessageBox.Show("Le client a été modifié avec succès");
                this.Close();
            }
        }

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
    }
}
