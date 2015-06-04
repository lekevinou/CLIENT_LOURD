using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MaBibliotheque
{
    public class personnelManager
    {
        private SqlConnection maConnection;

        public personnelManager()
        {
            bdd connection = new bdd();
            this.maConnection = connection.MaConnection;
        }

        public void addPersonnel(personnel unPersonnel)
        {
            this.maConnection.Open();

            string nom = unPersonnel.Nom_personnel;
            string prenom = unPersonnel.Prenom_personnel;
            string tel = unPersonnel.Tel_personnel;
            string mail = unPersonnel.Mail_personnel;
            string adr1 = unPersonnel.Adr_personnel_l1;
            string adr2 = unPersonnel.Adr_personnel_l2;
            string ville = unPersonnel.Ville_personnel;
            string cp = unPersonnel.Cp_personnel;
            string login = unPersonnel.Login_personnel;
            string mdp = unPersonnel.Mdp_personnel;
            DateTime dateentree = unPersonnel.Date_entree;
            int id_magasin = unPersonnel.Id_magasin;
            int id_poste = unPersonnel.Id_poste;
            int id_statut = unPersonnel.Id_statut;

            string req = "INSERT INTO personnel VALUES('" + nom + "','" + prenom + "','" + tel + "','" + mail + "','" + adr1 + "','" + adr2 + "','" + ville + "', '" + cp + "','" + login + "','" + mdp + "', '" + dateentree + "', '" + id_magasin + "', '" + id_poste + "', '" + id_statut + "')";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            this.maConnection.Close();
        }

        public personnel getUnPersonnel(int id)
        {
            string req = "SELECT * FROM personnel c WHERE c.id_personnel = '" + id + "' ";
            this.maConnection.Open();
            List<personnel> personnelList = new List<personnel>();

            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id_personnel = (int)reader["id_personnel"];
            string nom = reader["nom_personnel"].ToString();
            string prenom = reader["prenom_personnel"].ToString();
            string tel = reader["tel_personnel"].ToString();
            string mail = reader["mail_personnel"].ToString();
            string adr1 = reader["adr_personnel_l1"].ToString();
            string adr2 = reader["adr_personnel_l2"].ToString();
            string ville = reader["ville_personnel"].ToString();
            string cp = reader["cp_personnel"].ToString();
            string login = reader["login_personnel"].ToString();
            string mdp = reader["mdp_personnel"].ToString();
            DateTime dateentree = Convert.ToDateTime(reader["date_entree"]);
            int idmagasin = (int)reader["id_magasin"];
            int idposte = (int)reader["id_poste"];
            int idstatut = (int)reader["id_statut"];

            personnel unPersonnel = new personnel(id_personnel, nom, prenom, tel, mail, adr1, adr2, ville, cp, login, mdp, dateentree, idmagasin, idposte, idstatut);
            //clientList.Add(reader.GetValue(0).ToString());
            //clientList.Add(unClient);
            reader.Close();
            this.maConnection.Close();
            return unPersonnel;
        }

        public List<personnel> afficherPersonnel()
        {


            string req;
            req = "SELECT * FROM personnel";
            this.maConnection.Open();
            List<personnel> personnelList = new List<personnel>();
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                int id = (int)reader["id_personnel"];
                string nom = reader["nom_personnel"].ToString();
                string prenom = reader["prenom_personnel"].ToString();
                string tel = reader["tel_personnel"].ToString();
                string mail = reader["mail_personnel"].ToString();
                string adr1 = reader["adr_personnel_l1"].ToString();
                string adr2 = reader["adr_personnel_l2"].ToString();
                string ville = reader["ville_personnel"].ToString();
                string cp = reader["cp_personnel"].ToString();
                string login = reader["login_personnel"].ToString();
                string mdp = reader["mdp_personnel"].ToString();
                DateTime dateentree = Convert.ToDateTime(reader["date_entree"]);
                int idmagasin = (int)reader["id_magasin"];
                int idposte = (int)reader["id_poste"];
                int idstatut = (int)reader["id_statut"];
                personnel unPersonnel = new personnel(id, nom, prenom, tel, mail, adr1, adr2 ,ville, cp, login,mdp, dateentree, idmagasin, idposte, idstatut);
                personnelList.Add(unPersonnel);
            }
            reader.Close();
            this.maConnection.Close();
            return personnelList;
        }


        public void editPersonnel(personnel unPersonnel)
        {
            this.maConnection.Open();
            string req = "UPDATE personnel SET nom_personnel ='"+unPersonnel.Nom_personnel+"', prenom_personnel ='"+unPersonnel.Prenom_personnel+"', tel_personnel ='"+unPersonnel.Tel_personnel+"', adr_personnel_l1 ='"+unPersonnel.Adr_personnel_l1+"',adr_personnel_l2 ='"+unPersonnel.Adr_personnel_l2+"', ville_personnel ='"+unPersonnel.Ville_personnel+"', cp_personnel ='"+unPersonnel.Cp_personnel+"' WHERE id_personnel = '"+unPersonnel.Id_personnel+"'";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            this.maConnection.Close();
        }


        public List<magasin> afficherListeMagasins()
        {


            string req;
            req = "SELECT * FROM magasin";
            this.maConnection.Open();
            List<magasin> magasinList = new List<magasin>();
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                int id = (int)reader["id_magasin"];
                string adr = reader["adr_magasin"].ToString();
                string tel = reader["tel_magasin"].ToString();
                string mail = reader["mail_magasin"].ToString();
                string ville =reader["ville_magasin"].ToString();
                string cp = reader["cp_magasin"].ToString();
                
                magasin unMagasin = new magasin(id,adr, tel, mail, ville, cp);
                magasinList.Add(unMagasin);
            }
            reader.Close();
            this.maConnection.Close();
            return magasinList;
        }

        public string villeMagasin(int id_magasin)
        {
            this.maConnection.Open();
            string ville_magasin;

            string req = "SELECT * FROM magasin WHERE id_magasin = '" + id_magasin + "'";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            ville_magasin = reader["ville_magasin"].ToString();
            reader.Close();
            this.maConnection.Close();
            return ville_magasin;
        }

    }
}
