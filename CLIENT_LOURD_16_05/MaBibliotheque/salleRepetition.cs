using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class salleRepetition : salle
    {
        float taille_salle;

        public salleRepetition(int p_id_salle, string p_libelle_salle, int p_prix_salle_heure, int p_id_magasin, float p_taille_salle)
            : base(p_id_salle, p_libelle_salle, p_prix_salle_heure, p_id_magasin)
        {
            this.taille_salle = p_taille_salle;

        }

        public float Taille_salle
        {
            get { return taille_salle; }
            set { taille_salle = value; }
        }
    }
}
