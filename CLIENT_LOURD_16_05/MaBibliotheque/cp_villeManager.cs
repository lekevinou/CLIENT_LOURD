using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MaBibliotheque
{
    public class cp_villeManager
    {
        private SqlConnection maConnection;

        public cp_villeManager()
        {
            bdd connection = new bdd();
            this.maConnection = connection.MaConnection;
        }

        public List<cp_ville> getCP_VILLE(string cp_text_box)
        {
            this.maConnection.Open();
            List<cp_ville> cp_villeList = new List<cp_ville>();


            string req = "SELECT * FROM CP_VILLE WHERE code_postal = '" + cp_text_box + "'";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id_ville = (int)reader["id_ville"];
                string code_postal = reader["code_postal"].ToString();
                string nom_ville = reader["nom_ville"].ToString(); ;

                cp_ville unCP_VILLE = new cp_ville(id_ville, code_postal, nom_ville);
                //clientList.Add(reader.GetValue(0).ToString());
                cp_villeList.Add(unCP_VILLE);
            }
            reader.Close();
            this.maConnection.Close();
            return cp_villeList;
        }

        public string getVilleByIdVille(int id_ville)
        {
            this.maConnection.Open();
            string clientVille;

            string req = "SELECT nom_ville FROM CP_VILLE WHERE id_ville = '" + id_ville + "'";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            clientVille = reader["nom_ville"].ToString();
            reader.Close();
            this.maConnection.Close();
            return clientVille;
        }
    }
}
