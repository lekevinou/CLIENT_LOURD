using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MaBibliotheque
{
    public class reservationManagerOld
    {
        private SqlConnection maConnection;

        public reservationManagerOld()
        {
            bdd connection = new bdd();
            this.maConnection = connection.MaConnection;
        }
        public List<reservation> getReservationClient(int id_client){
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

        public List<reservation> getReservationsDateSalle(DateTime date, int id_salle)
        {
            this.maConnection.Open();
            List<reservation> reservationList = new List<reservation>();
            string req = "SELECT * FROM RESERVATION WHERE jour_res ='" + date.Date + "' AND id_salle = '"+ id_salle +"'";
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


                reservation uneReservation = new reservation(p_num_reservation, p_jour_res, p_heure_debut_res, p_heure_fin_res, p_id_client, p_id_salle, p_id_magasin);
                //clientList.Add(reader.GetValue(0).ToString());
                reservationList.Add(uneReservation);
            }
            reader.Close();
            this.maConnection.Close();
            return reservationList;
        }
    }
}
