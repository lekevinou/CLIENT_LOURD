using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class reservation
    {
        int num_reservation, id_client, id_salle, id_magasin;
        DateTime jour_res, heure_debut_res, heure_fin_res;
        
        public reservation(int p_num_reservation, DateTime p_jour_res, DateTime p_heure_debut_res, DateTime p_heure_fin_res, int p_id_client, int p_id_salle, int p_id_magasin)
        {
            this.num_reservation = p_num_reservation;
            this.jour_res = p_jour_res;
            this.heure_debut_res = p_heure_debut_res;
            this.heure_fin_res = p_heure_fin_res;
            this.id_client = p_id_client;
            this.id_salle = p_id_salle;
            this.id_magasin = p_id_magasin;

        }

        public int Num_reservation
        {
            get { return num_reservation; }
            set { num_reservation = value; }
        }

        public DateTime Jour_res
        {
            get { return jour_res; }
            set { jour_res = value; }
        }

        public DateTime Heure_debut_res
        {
            get { return heure_debut_res; }
            set { heure_debut_res = value; }
        }

        public DateTime Heure_fin_res
        {
            get { return heure_fin_res; }
            set { heure_fin_res = value; }
        }

        public int Id_client
        {
            get { return id_client; }
            set { id_client = value; }
        }

        public int Id_salle
        {
            get { return id_salle; }
            set { id_salle = value; }
        }

        public int Id_magasin
        {
            get { return id_magasin; }
            set { id_magasin = value; }
        }
    }
}