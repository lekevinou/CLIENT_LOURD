using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
// Ajout de System.Data.SqlClient pour la connexion à la bdd.
using System.Data.SqlClient;
//Insertion de la bibliothèque "bdd"
using MaBibliotheque;

namespace Client_LOURD
{
    public partial class GestionEquipementAjout : Form
    {
        public GestionEquipementAjout()
        {
            InitializeComponent();
        }

        private void voirEquipement_Click(object sender, EventArgs e)
        {
            // Ouverture de la page GestionEquipementVue.cs.
            btnAjouterEquipement f = new btnAjouterEquipement();
            this.Hide();
            // Fermeture de la page actuelle.
            f.ShowDialog();
            this.Close();
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            //On vérifie que les champs soient bien remplies
            if (textBoxNom.Text == "" || textBoxPrix.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs. ");
            }
            else
            {
                int id_equipement = 1;
                string nom = textBoxNom.Text;
                string prix = textBoxPrix.Text;
                string reference = textBoxReference.Text;
                string marque = textBoxMarque.Text;
                string type = textBoxType.Text;


                equipement unEquipement = new equipement(id_equipement, nom, prix, reference, marque, type); //On crée un nouvel equipement avec les informations rentrées par l'utilisateur.
                equipementManager equipementManager = new equipementManager(); // On crée un nouveau equipementManager qui va gérer les requêtes.
                equipementManager.addEquipement(unEquipement); //On appelle la methode addEquipement avec l'equipement que nous venons de créer en paramètre.
                // La méthode va alors se charger d'ajouter en bdd l'équipement.
                MessageBox.Show("L'équipement a été ajouté avec succès");
            } 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Ouverture de la page GestionEquipement.cs.
            GestionEquipement f = new GestionEquipement();
            this.Hide();
            // Fermeture de la page actuelle.
            f.ShowDialog();
            this.Close();
        }
    }
}
