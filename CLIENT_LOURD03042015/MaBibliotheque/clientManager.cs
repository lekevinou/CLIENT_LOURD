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

        public void addClient(client unClient)
        {
            this.maConnection.Open();

            string prenom = unClient.Prenom;
            string nom = unClient.Nom;
            string adr1 = unClient.Adresse1;
            string adr2 = unClient.Adresse2;
            string tel = unClient.Tel;
            string mail = unClient.Mail;

            string req = "INSERT INTO CLIENT VALUES('" + nom + "','" + prenom + "','" + adr1 + "','" + adr2 + "','" + tel + "','" + mail + "')";
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
            //int id = (int)reader["id_client"];
            string nom = reader["nom_client"].ToString();
            string prenom = reader["prenom_client"].ToString();
            string adr1 = reader["adr_client_l1"].ToString();
            string adr2 = reader["adr_client_l2"].ToString();
            string tel_client = reader["tel_client"].ToString();
            string mail_client = reader["mail_client"].ToString();
            client unClient = new client(id, nom, prenom, adr1, adr2, tel_client, mail_client);
            //clientList.Add(reader.GetValue(0).ToString());
            clientList.Add(unClient);
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
                 string adr2 = reader["adr_client_l2"].ToString();
                 string tel_client = reader["tel_client"].ToString();
                 string mail_client = reader["mail_client"].ToString();
                 client unClient = new client(id, nom, prenom, adr1, adr2, tel_client, mail_client);
                 clientList.Add(unClient);
             }
             reader.Close();
             this.maConnection.Close();
             return clientList;
        }

    }
}
