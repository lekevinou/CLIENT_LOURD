using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MaBibliotheque
{
    public class salleManager
    {
        private SqlConnection maConnection;

        public salleManager()
        {
            bdd connection = new bdd();
            this.maConnection = connection.MaConnection;
        }

        public List<salle> getListSalles()
        {
            string req;
            req = "SELECT * FROM SALLES";
            this.maConnection.Open();
            //List<salle> sallesList = new List<salle>();
            List<salle> sallesList = new List<salle>();
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
             {
                 int p_id_salle = Convert.ToInt32(reader["id_salle"]);
                 string p_libelle_salle = reader["libelle_salle"].ToString();
                 int p_prix_salle_heure = Convert.ToInt32(reader["prix_salle_heure"]);
                 int p_id_magasin = Convert.ToInt32(reader["id_magasin"]);
                 salle uneSalle = new salle(p_id_salle, p_libelle_salle, p_prix_salle_heure, p_id_magasin);
                 sallesList.Add(uneSalle); 
             }
             reader.Close();
             this.maConnection.Close();
             return sallesList;
        }

        public string libelleSalle(int id_salle)
        {
            string req;
            req = "SELECT libelle_salle FROM SALLES WHERE id_salle = '" + id_salle + "'";
            this.maConnection.Open();
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string libelle_salle = reader["libelle_salle"].ToString();

            return libelle_salle;
        }
    }
}
