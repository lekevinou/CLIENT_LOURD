using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MaBibliotheque
{
    public class reservationManager
    {
        private SqlConnection maConnection;
        
        public reservationManager()
        {
            bdd connection = new bdd();
            this.maConnection = connection.MaConnection;
            
        }

        public int getId(string jour_res, string heure_debut_res, int id_salle)
        {
            this.maConnection.Open();
            string req = "SELECT num_reservation FROM reservation WHERE jour_res = '" + jour_res + "' AND heure_debut_res = '" + heure_debut_res + "' AND id_salle = " + id_salle + "";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int num_reservation = (int)reader["num_reservation"];
            this.maConnection.Close();
            return num_reservation;

        }
        public void addReservation(reservation uneReservation)
        {
            this.maConnection.Open();
            string req = "INSERT INTO RESERVATION VALUES('" + uneReservation.Jour_res + "','" + uneReservation.Heure_debut_res + "','" + uneReservation.Heure_fin_res + "','" + uneReservation.Id_client + "','" + uneReservation.Id_salle + "','" + uneReservation.Id_magasin + "')";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            this.maConnection.Close();
        }

        public List<reservation> getReservationClient(int id_client)
        {
            this.maConnection.Open();
            List<reservation> reservationList = new List<reservation>();


            string req = "SELECT r.*, s.LIBELLE_SALLE FROM RESERVATION r LEFT JOIN SALLES s ON s.ID_SALLE = r.fk_id_salle_res WHERE FK_id_CLIENT_RES = '" + id_client + "'";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int p_num_reservation = (int)reader["num_reservation"];
                DateTime p_jour_res = (DateTime)reader["jour_res"];
                DateTime p_heure_debut_res = (DateTime)reader["heure_debut_res"];
                DateTime p_heure_fin_res = (DateTime)reader["heure_fin_res"];
                int p_id_client = (int)reader["id_client"];
                int p_id_salle = (int)reader["id_salle"];
                int p_id_magasin = (int)reader["id_magasin"];

                //string p_salle_reservee = reader["LIBELLE_SALLE"].ToString();

                reservation uneReservation = new reservation(p_num_reservation, p_jour_res, p_heure_debut_res, p_heure_fin_res, p_id_client, p_id_salle, p_id_magasin);
                //clientList.Add(reader.GetValue(0).ToString());
                reservationList.Add(uneReservation);
            }
            reader.Close();
            this.maConnection.Close();
            return reservationList;

        }

        public List<reservation> getReservationsDateSalle(DateTime date, int id_magasin)
        {
            string dateSansHeure = date.ToString("yyyy-MM-dd");
            this.maConnection.Open();
            List<reservation> reservationList = new List<reservation>();
            string req = "SELECT * FROM RESERVATION WHERE id_magasin = '"+id_magasin+"' AND jour_res ='" + dateSansHeure + "'";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int p_num_reservation = (int)reader["num_reservation"];
                DateTime p_jour_res = (DateTime)reader["jour_res"];
                DateTime p_heure_debut_res = (DateTime.Parse(reader["heure_debut_res"].ToString()));
                DateTime p_heure_fin_res = (DateTime.Parse(reader["heure_fin_res"].ToString()));
                int p_id_client = (int)reader["id_client"];
                int p_id_salle = (int)reader["id_salle"];
                int p_id_magasin = (int)reader["id_magasin"];

                reservation uneReservation = new reservation(p_num_reservation, p_jour_res, p_heure_debut_res, p_heure_fin_res, p_id_client, p_id_salle, p_id_magasin);
                reservationList.Add(uneReservation);
            }
            reader.Close();
            this.maConnection.Close();
            return reservationList;
        }

        public List<reservation> getReservationDateHeureSalle(DateTime jour_res, DateTime heure_deb_res, DateTime heure_fin_res, int id_salle, int id_magasin)
        {
            this.maConnection.Open();
            List<reservation> reservationList = new List<reservation>();
            string req = "SELECT * FROM reservation WHERE jour_res = '" + jour_res + "' AND id_salle = " + id_salle + " AND id_magasin = " + id_magasin + " AND (('" + heure_deb_res + "' > heure_debut_res AND '" + heure_deb_res + "' < heure_fin_res) OR ('" + heure_deb_res + "' < heure_debut_res AND '" + heure_fin_res + "' > heure_debut_res) OR ('" + heure_deb_res + "' < heure_debut_res AND '" + heure_fin_res + "' > heure_debut_res) OR ('" + heure_deb_res + "' = heure_debut_res))";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int p_num_reservation = (int)reader["num_reservation"];
                DateTime p_jour_res = (DateTime)reader["jour_res"];
                DateTime p_heure_debut_res = (DateTime)Convert.ToDateTime(reader["heure_debut_res"].ToString());
                DateTime p_heure_fin_res = (DateTime)Convert.ToDateTime(reader["heure_fin_res"].ToString());
                int p_id_client = (int)reader["id_client"];
                int p_id_salle = (int)reader["id_salle"];
                int p_id_magasin = (int)reader["id_magasin"];


                reservation uneReservation = new reservation(p_num_reservation, p_jour_res, p_heure_debut_res, p_heure_fin_res, p_id_client, p_id_salle, p_id_magasin);
                reservationList.Add(uneReservation);
            }
            reader.Close();
            this.maConnection.Close();
            return reservationList;
        }

        public string GetPrenom_Nom_client(int id_client)
        {
            this.maConnection.Open();
            string req = "SELECT nom_client, prenom_client FROM CLIENT WHERE id_client ='" + id_client + "'";
            //string req = "INSERT INTO CLIENT VALUES('" + nom + "','" + prenom + "','" + adr1 + "','" + ville_client + "','" + cp_client + "','" + adr2 + "','" + tel + "','" + mail + "')";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string nom = reader["nom_client"].ToString();
            string prenom = reader["prenom_client"].ToString();

            string nomCompletClient = nom.ToUpper() + " - " + prenom;

            this.maConnection.Close();
            return nomCompletClient;
        }

        public client GetClientQuiAReserve(int id_client)
        {
            this.maConnection.Open();
            string req = "SELECT * FROM CLIENT c WHERE c.id_client = '" + id_client + "' ";
            List<client> clientList = new List<client>();

            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = (int)reader["id_client"];
            string nom = reader["nom_client"].ToString();
            string prenom = reader["prenom_client"].ToString();
            string adr1 = reader["adr_client_l1"].ToString();
            string ville_client = reader["ville_client"].ToString();
            string cp_client = reader["cp_client"].ToString();
            string adr2 = reader["adr_client_l2"].ToString();
            string tel_client = reader["tel_client"].ToString();
            string mail_client = reader["mail_client"].ToString();

            client unClient = new client(id_client, nom, prenom, adr1, ville_client, cp_client, adr2, tel_client, mail_client);
            this.maConnection.Close();
            return unClient;
        }

        public void supprimerReservation(int id_client)
        {
            this.maConnection.Open();
            string req = "DELETE FROM RESERVATION WHERE id_client= '" +  id_client + "' ";

            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            this.maConnection.Close();
        }

        public List<reservation> getReservationsParClient(int id_client)
        {
            this.maConnection.Open();
            List<reservation> reservationList = new List<reservation>();
            //string req = "SELECT * FROM RESERVATION WHERE jour_res ='" + date.Date + "' AND id_salle = '" + id_salle + "'";
            string req = "SELECT * FROM RESERVATION WHERE id_client ='" + id_client + "'";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int p_num_reservation = (int)reader["num_reservation"];
                DateTime p_jour_res = (DateTime)reader["jour_res"];
                DateTime p_heure_debut_res = (DateTime.Parse(reader["heure_debut_res"].ToString()));
                DateTime p_heure_fin_res = (DateTime.Parse(reader["heure_fin_res"].ToString()));
                int p_id_client = (int)reader["id_client"];
                int p_id_salle = (int)reader["id_salle"];
                int p_id_magasin = (int)reader["id_magasin"];


                reservation uneReservation = new reservation(p_num_reservation, p_jour_res, p_heure_debut_res, p_heure_fin_res, p_id_client, p_id_salle, p_id_magasin);
                reservationList.Add(uneReservation);
            }
            reader.Close();
            this.maConnection.Close();
            return reservationList;
        }

    }
}
