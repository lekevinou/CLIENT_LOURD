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

        //public void addClient(client unClient)
        //{
        //    this.maConnection.Open();

        //    string prenom = unClient.Prenom;
        //    string nom = unClient.Nom;
        //    string adr1 = unClient.Adresse1;
        //    string adr2 = unClient.Adresse2;
        //    string tel = unClient.Tel;
        //    string mail = unClient.Mail;

        //    string req = "INSERT INTO CLIENT VALUES('" + nom + "','" + prenom + "','" + adr1 + "','" + adr2 + "','" + tel + "','" + mail + "')";
        //    SqlCommand cmd = new SqlCommand(req, maConnection);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    this.maConnection.Close();
        //}

        //public salle get(int id)
        //{
        //    string req = "SELECT * FROM CLIENT c WHERE c.id_client = '" + id + "' ";
        //    this.maConnection.Open();
        //    List<client> clientList = new List<client>();

        //    SqlCommand cmd = new SqlCommand(req, maConnection);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    reader.Read();
        //    //int id = (int)reader["id_client"];
        //    string nom = reader["nom_client"].ToString();
        //    string prenom = reader["prenom_client"].ToString();
        //    string adr1 = reader["adr_client_l1"].ToString();
        //    string adr2 = reader["adr_client_l2"].ToString();
        //    string tel_client = reader["tel_client"].ToString();
        //    string mail_client = reader["mail_client"].ToString();
        //    int cp_client = Convert.ToInt32(reader["id_ville"]);
        //    client unClient = new client(id, nom, prenom, adr1, adr2, tel_client, mail_client, cp_client);
        //    //clientList.Add(reader.GetValue(0).ToString());
        //    clientList.Add(unClient);
        //    reader.Close();
        //    this.maConnection.Close();
        //    return unClient;
        //}

        
        public List<salle> getListSalles()
        {
            string req;
            req = " SELECT * FROM salles s LEFT JOIN sallerepetition sr ON s.id_salle = sr.id_salle LEFT JOIN salleconcert sc ON s.id_salle = sc.id_salle";
            //Test 
            this.maConnection.Open();
            List<salle> sallesList = new List<salle>();
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
             {
                //if(!Convert.IsDBNull(reader["id_salle"]))
                //{
                //    int p_id_salle = null;
                //    int p_id_salle = 0;
                //}
                //else
                //{
                //    int p_id_salle = Convert.ToInt32(reader["id_salle"]);
                //}

                 int p_id_salle = Convert.ToInt32(reader["id_salle"]);
                 int p_id_magasin = Convert.ToInt32(reader["id_magasin"]);
                 int p_prix_salle_heure = Convert.ToInt32(reader["prix_salle_heure"]);
                 int p_nb_place = Convert.ToInt32(reader["nb_place"]);
                 string p_libelle_salle = reader["libelle_salle"].ToString();
                 float p_taille_salle = (float)reader["taille_salle"];

                 salle uneSalle = new salle(p_id_salle, p_id_magasin, p_prix_salle_heure, p_nb_place, p_libelle_salle, p_taille_salle);
                 sallesList.Add(uneSalle); 
             }
             reader.Close();
             this.maConnection.Close();
             return sallesList;
        }

        //public List<salle> getListSallesReservation()
        //{
        //    string req;
        //    req = " SELECT * FROM salles s LEFT JOIN sallerepetition sr ON s.id_salle = sr.id_salle LEFT JOIN salleconcert sc ON s.id_salle = sc.id_salle";

        //    this.maConnection.Open();
        //    List<salle> sallesList = new List<salle>();
        //    SqlCommand cmd = new SqlCommand(req, maConnection);
        //    SqlDataReader reader = cmd.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        if (!Convert.IsDBNull(reader["id_salle"]))
        //        {
        //            int p_id_salle = null;
        //            int p_id_salle = 0;
        //        }
        //        else
        //        {
        //            int p_id_salle = Convert.ToInt32(reader["id_salle"]);
        //        }


        //        int p_id_magasin = Convert.ToInt32(reader["id_magasin"]);
        //        int p_prix_salle_heure = Convert.ToInt32(reader["prix_salle_heure"]);
        //        int p_nb_place = Convert.ToInt32(reader["nb_place"]);
        //        string p_libelle_salle = reader["libelle_salle"].ToString();
        //        float p_taille_salle = (float)reader["taille_salle"];

        //        salle uneSalle = new salle(p_id_salle, p_id_magasin, p_prix_salle_heure, p_nb_place, p_libelle_salle, p_taille_salle);
        //        sallesList.Add(uneSalle);
        //    }
        //    reader.Close();
        //    this.maConnection.Close();
        //    return sallesList;
        //}
    }
}
