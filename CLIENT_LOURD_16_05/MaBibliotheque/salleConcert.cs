using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class salleConcert : salle
    {
        int nb_place;

        public salleConcert(int p_id_salle, string p_libelle_salle, int p_prix_salle_heure, int p_id_magasin, int p_nb_place)
            : base(p_id_salle, p_libelle_salle, p_prix_salle_heure, p_id_magasin)
        {
            this.nb_place = p_nb_place;
        }

        public int Nb_place
        {
            get { return nb_place; }
            set { nb_place = value; }
        }
    }
}
