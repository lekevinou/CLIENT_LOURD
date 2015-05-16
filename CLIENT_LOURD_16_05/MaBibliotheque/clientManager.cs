using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MaBibliotheque
{

    public class clientManager
    {
        private SqlConnection maConnection;

        public clientManager()
        {
            bdd connection = new bdd();
            this.maConnection = connection.MaConnection;
        }
        public string getCPClient(string ville_cient, string mail_client)
        {
            this.maConnection.Open();
            string req = "SELECT cp_client FROM CLIENT c WHERE c.ville_client = '" + ville_cient + "' AND c.mail_client = '" + mail_client + "'";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string cp_client = reader["cp_client"].ToString();
            reader.Close();
            this.maConnection.Close();
            return cp_client;
        }

        public void addClient(client unClient)
        {
            this.maConnection.Open();
            string req = "INSERT INTO CLIENT VALUES('" + unClient.Nom + "','" + unClient.Prenom + "','" + unClient.Adresse1 + "','" + unClient.Ville_client + "','" + unClient.Cp_client + "','" + unClient.Adresse2 + "','" + unClient.Tel + "','" + unClient.Mail + "')";
            //string req = "INSERT INTO CLIENT VALUES('" + nom + "','" + prenom + "','" + adr1 + "','" + ville_client + "','" + cp_client + "','" + adr2 + "','" + tel + "','" + mail + "')";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            this.maConnection.Close();
        }

        public client getUnclient(int id)
        {
            string req = "SELECT * FROM CLIENT c WHERE c.id_client = '" + id + "' ";
            this.maConnection.Open();
            List<client> clientList = new List<client>();

            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id_client = (int)reader["id_client"];
            string nom = reader["nom_client"].ToString();
            string prenom = reader["prenom_client"].ToString();
            string adr1 = reader["adr_client_l1"].ToString();
            string ville_client = reader["ville_client"].ToString();
            string cp_client = reader["cp_client"].ToString();
            string adr2 = reader["adr_client_l2"].ToString();
            string tel_client = reader["tel_client"].ToString();
            string mail_client = reader["mail_client"].ToString();
            //int cp_client = Convert.ToInt32(reader["id_ville"]);

            client unClient = new client(id_client, nom, prenom, adr1, ville_client, cp_client, adr2, tel_client, mail_client);
            //clientList.Add(reader.GetValue(0).ToString());
            //clientList.Add(unClient);
            reader.Close();
            this.maConnection.Close();
            return unClient;
        }

        public List<client> getListClient(string critere)
        {
            string req;
            if (critere != "")
            {
                req = "SELECT * FROM CLIENT c WHERE nom_client LIKE '%" + critere + "%' OR prenom_client LIKE '%" + critere + "%'";
            }
            else{
                req = "SELECT * FROM CLIENT";
            }
            this.maConnection.Open();
            List<client> clientList = new List<client>();
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
             while (reader.Read())
             {
                 int id = (int)reader["id_client"];
                 string nom = reader["nom_client"].ToString();
                 string prenom = reader["prenom_client"].ToString();
                 string adr1 = reader["adr_client_l1"].ToString();
                 string ville_client = reader["ville_client"].ToString();
                 string cp_client = reader["cp_client"].ToString();
                 string adr2 = reader["adr_client_l2"].ToString();
                 string tel_client = reader["tel_client"].ToString();
                 string mail_client = reader["mail_client"].ToString();
                 //int cp_client = Convert.ToInt32(reader["id_ville"]);
                 client unClient = new client(id, nom, prenom, adr1, ville_client, cp_client, adr2, tel_client, mail_client);
                 clientList.Add(unClient);
             }
             reader.Close();
             this.maConnection.Close();
             return clientList;
        }
        public void editClient(client unClient)
        {
            this.maConnection.Open();
            string req = "UPDATE CLIENT SET nom_client ='"+unClient.Nom+"', prenom_client = '"+unClient.Prenom+"', adr_client_l1 = '"+unClient.Adresse1+"', ville_client = '"+unClient.Ville_client+"', cp_client = '"+unClient.Cp_client+"', adr_client_l2 = '"+unClient.Adresse2+"', tel_client = '"+unClient.Tel+"', mail_client = '"+unClient.Mail+"' WHERE id_client = '"+unClient.Id+"'";
            //string req = "INSERT INTO CLIENT VALUES('" + nom + "','" + prenom + "','" + adr1 + "','" + ville_client + "','" + cp_client + "','" + adr2 + "','" + tel + "','" + mail + "')";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            this.maConnection.Close();
        }

        public void supprimerClient(client unClient)
        {
            this.maConnection.Open();
            string req = "DELETE FROM CLIENT WHERE id_client ='"+unClient.Id+"'";
            //string req = "INSERT INTO CLIENT VALUES('" + nom + "','" + prenom + "','" + adr1 + "','" + ville_client + "','" + cp_client + "','" + adr2 + "','" + tel + "','" + mail + "')";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            this.maConnection.Close();
        }
    }
}