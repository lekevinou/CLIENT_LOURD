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
            public equipement getUnEquipement(int id)
        {
            string req = "SELECT * FROM EQUIPEMENT c WHERE c.id_equipment = '" + id + "' ";
            this.maConnection.Open();
            List<equipement> equipementList = new List<equipement>();

            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //int id = (int)reader["id_equipement"];
            string nom = reader["nom_equipement"].ToString();
            string prix = reader["prix_equipement"].ToString();
            string reference = reader["reference_equipement"].ToString();
            string marque = reader["marque_equipement"].ToString();
            string type = reader["type_equipement"].ToString();
            equipement unEquipement = new equipement(id, nom, prix, reference, marque, type);
            //equipementList.Add(reader.GetValue(0).ToString());
            equipementList.Add(unEquipement);
            reader.Close();
            this.maConnection.Close();
            return unEquipement;
        }

        public List<equipement> getListEquipement(string critere)
        {
            string req;
            if (critere != "")
            {
                req = "SELECT * FROM EQUIPEMENT WHERE nom_equipement LIKE '%" + critere + "%' OR prix_equipement LIKE '%" + critere + "%'";
            }
            else{
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
                 string type = reader["type_equipement"].ToString();
                 int cp_client = Convert.ToInt32(reader["id_ville"]);
                 equipement unEquipement = new equipement( id, nom, prix, reference, marque, type);
                 equipementList.Add(unEquipement);
             }
             reader.Close();
             this.maConnection.Close();
             return equipementList;
        
        }
    }
}
