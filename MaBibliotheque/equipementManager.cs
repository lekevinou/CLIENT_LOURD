using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MaBibliotheque
{
    public class equipementManager
    {
        private SqlConnection maConnection;
        public equipementManager()
        {
            // Connexion à la base de données.
            bdd connection = new bdd();
            this.maConnection = connection.MaConnection;
        }
        public void addEquipement(equipement unEquipement)
        {
            // Ouverture de la connexion.
            this.maConnection.Open();
            
            string nom = unEquipement.Nom;
            string prix = unEquipement.Prix;
            string reference = unEquipement.Reference;
            string marque = unEquipement.Marque;
            string type = unEquipement.Type;

            // Insertion d'une requêtte SQL permettant l'insertion;
            string req = "INSERT INTO EQUIPEMENT VALUES('" + nom + "','" + prix + "','" + reference + "','" + marque + "','" + type + "')";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            //Fermeture de la connexion
            this.maConnection.Close();
        }
    }
}
