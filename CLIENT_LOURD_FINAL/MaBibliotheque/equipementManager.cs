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
            int id_type = unEquipement.Id_type;

            // Insertion d'une requêtte SQL permettant l'insertion;
            string req = "INSERT INTO EQUIPEMENT VALUES('" + nom + "','" + prix + "','" + marque + "','" + reference + "','" + id_type + "')";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            //Fermeture de la connexion
            this.maConnection.Close();
        }
        public List<equipement> getListEquipement(int critere)
        {
            string req;
            if (critere != null )
            {
                req = "SELECT * FROM EQUIPEMENT WHERE id_type_equipement = '"+ critere +"'";
            }
            else
            {
                req = "SELECT * FROM EQUIPEMENT";
            }
            this.maConnection.Open();
            List<equipement> equipementList = new List<equipement>();
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["id_equipement"];
                string nom = reader["nom_equipement"].ToString();
                string prix = reader["prix_equipement"].ToString();
                string reference = reader["reference_equipement"].ToString();
                string marque = reader["marque_equipement"].ToString();
                int id_type = (int)reader["id_type_equipement"];
                equipement unEquipement = new equipement(id, nom, prix, reference, marque, id_type);
                equipementList.Add(unEquipement);
            }
            reader.Close();
            this.maConnection.Close();
            return equipementList;
        }

        public equipement getUnequipement(int id)
        {
            string req = "SELECT * FROM EQUIPEMENT c WHERE c.id_equipement = '" + id + "' ";
            this.maConnection.Open();

            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id_equipement = (int)reader["id_equipement"];
            string nom = reader["nom_equipement"].ToString();
            string prix = reader["prix_equipement"].ToString();
            string reference = reader["reference_equipement"].ToString();
            string marque = reader["marque_equipement"].ToString();
            int id_type_equipement = (int)reader["id_type_equipement"];

            equipement unEquipement = new equipement(id_equipement, nom, prix, reference, marque, id_type_equipement);
            reader.Close();
            this.maConnection.Close();
            return unEquipement;
        }
    }
}
