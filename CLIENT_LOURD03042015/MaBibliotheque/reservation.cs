using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class reservation
    {
        int id_reservation, id_client, id_salle;
        string jour_res, heure_debut_res, heure_fin_res, salle_reservee;


        

        public reservation(int p_id_reservation, int p_id_client, int p_id_salle, string p_jour_res, string p_heure_debut_res, string p_heure_fin_res, string p_salle_reservee)
        {
            this.id_reservation = p_id_reservation;
            this.id_client = p_id_client;
            this.id_salle = p_id_salle;
            this.jour_res = p_jour_res;
            this.heure_debut_res = p_heure_debut_res;
            this.heure_fin_res = p_heure_fin_res;
            this.salle_reservee = p_salle_reservee;
            //this.mail = p_mail;

        }
        public int Id_salle
        {
            get { return id_salle; }
            set { id_salle = value; }
        }

        public int Id_client
        {
            get { return id_client; }
            set { id_client = value; }
        }

        public int Id_reservation
        {
            get { return id_reservation; }
            set { id_reservation = value; }
        }


        public string Heure_fin_res
        {
            get { return heure_fin_res; }
            set { heure_fin_res = value; }
        }

        public string Heure_debut_res
        {
            get { return heure_debut_res; }
            set { heure_debut_res = value; }
        }

        public string Jour_res
        {
            get { return jour_res; }
            set { jour_res = value; }
        }

        public string Salle_reservee
        {
            get { return salle_reservee; }
            set { salle_reservee = value; }
        }
    }
}

