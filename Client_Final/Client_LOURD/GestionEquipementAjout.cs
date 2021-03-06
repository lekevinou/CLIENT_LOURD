﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
// Ajout de System.Data.SqlClient pour la connexion à la bdd.
//using System.Data.SqlClient;
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
<<<<<<< HEAD
                int id_type = int.Parse(cb_type.SelectedValue.ToString());


                equipement unEquipement = new equipement(0, nom, prix, marque, reference, id_type); //On crée un nouvel equipement avec les informations rentrées par l'utilisateur.
                equipementManager equipementManager = new equipementManager(); // On crée un nouveau clientManager qui va gérer les requêtes.
=======
                string marque = textBoxMarque.Text;
                string type = textBoxType.Text;


                equipement unEquipement = new equipement(id_equipement, nom, prix, reference, marque, type); //On crée un nouvel equipement avec les informations rentrées par l'utilisateur.
                equipementManager equipementManager = new equipementManager(); // On crée un nouveau equipementManager qui va gérer les requêtes.
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
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

        private void GestionEquipementAjout_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gamilonbaseDataSet1.type_equipement'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.type_equipementTableAdapter.Fill(this.gamilonbaseDataSet1.type_equipement);

        }
    }
}
