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
        public List<reservation> getReservationClient(int id_client){
            this.maConnection.Open();
            List<reservation> reservationList = new List<reservation>();

            
            string req = "SELECT r.*, s.LIBELLE_SALLE FROM RESERVATION r LEFT JOIN SALLES s ON s.ID_SALLE = r.fk_id_salle_res WHERE FK_id_CLIENT_RES = '" + id_client + "'";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id_reservation = (int)reader["num_reservation"];
                int id_client_res = (int)reader["fk_id_client_res"] ;
                int id_salle = (int)reader["fk_id_salle_res"] ;;

                string jour_res = reader["jour_res"].ToString();
                string heure_debut_res = reader["heure_debut_res"].ToString();
                string heure_fin_res = reader["heure_fin_res"].ToString();
                string salle_reservee = reader["LIBELLE_SALLE"].ToString();

                reservation uneReservation = new reservation(id_reservation, id_client_res, id_salle, jour_res, heure_debut_res, heure_fin_res, salle_reservee);
                //clientList.Add(reader.GetValue(0).ToString());
                reservationList.Add(uneReservation);
            }
            reader.Close();
            this.maConnection.Close();
            return reservationList;
            
        }
    }
}
