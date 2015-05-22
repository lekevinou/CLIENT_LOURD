using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class fournit
    {
        int id_four, id_equipement, num_reservation;

        public fournit(int p_id_four, int p_id_equipement, int p_num_reservation)
        {
            this.id_four = p_id_four;
            this.id_equipement = p_id_equipement;
            this.num_reservation = p_num_reservation;

        }

        public int Id_four
        {
            get { return id_four; }
            set { id_four = value; }
        }

        public int Id_equipement
        {
            get { return id_equipement; }
            set { id_equipement = value; }
        }

        public int Num_reservation
        {
            get { return num_reservation; }
            set { num_reservation = value; }
        }
    }
}
