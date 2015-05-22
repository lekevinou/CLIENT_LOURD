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
<<<<<<< HEAD
            
=======

>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            string nom = unEquipement.Nom;
            string prix = unEquipement.Prix;
            string reference = unEquipement.Reference;
            string marque = unEquipement.Marque;
<<<<<<< HEAD
            int id_type = unEquipement.Id_type;

            // Insertion d'une requêtte SQL permettant l'insertion;
            string req = "INSERT INTO EQUIPEMENT VALUES('" + nom + "','" + prix + "','" + marque + "','" + reference + "','" + id_type + "')";
=======
            string type = unEquipement.Type;

            // Insertion d'une requêtte SQL permettant l'insertion;
            string req = "INSERT INTO EQUIPEMENT VALUES('" + nom + "','" + prix + "','" + reference + "','" + marque + "','" + type + "')";
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            //Fermeture de la connexion
            this.maConnection.Close();
        }
<<<<<<< HEAD
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
=======
            public equipement getUnEquipement(int id)
        {
            string req = "SELECT * FROM EQUIPEMENT c WHERE c.id_equipment = '" + id + "' ";
            this.maConnection.Open();
            List<equipement> equipementList = new List<equipement>();
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9

            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
<<<<<<< HEAD
            int id_equipement = (int)reader["id_equipement"];
=======
            //int id = (int)reader["id_equipement"];
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            string nom = reader["nom_equipement"].ToString();
            string prix = reader["prix_equipement"].ToString();
            string reference = reader["reference_equipement"].ToString();
            string marque = reader["marque_equipement"].ToString();
<<<<<<< HEAD
            int id_type_equipement = (int)reader["id_type_equipement"];

            equipement unEquipement = new equipement(id_equipement, nom, prix, reference, marque, id_type_equipement);
=======
            string type = reader["type_equipement"].ToString();
            equipement unEquipement = new equipement(id, nom, prix, reference, marque, type);
            //equipementList.Add(reader.GetValue(0).ToString());
            equipementList.Add(unEquipement);
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            reader.Close();
            this.maConnection.Close();
            return unEquipement;
        }
<<<<<<< HEAD
=======

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
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
    }
}
