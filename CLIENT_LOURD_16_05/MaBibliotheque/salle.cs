using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class salle
    {
        int id_salle, id_magasin, prix_salle_heure;
        string libelle_salle;

        public salle(int p_id_salle,
            string p_libelle_salle,
            int p_prix_salle_heure,
            int p_id_magasin
            )
        {
            this.id_salle = p_id_salle;
            this.libelle_salle = p_libelle_salle;
            this.prix_salle_heure = p_prix_salle_heure;
            this.id_magasin = p_id_magasin;
            


        }
        public int Id_salle
        {
            get { return id_salle; }
            set { id_salle = value; }
        }
        public string Libelle_salle
        {
            get { return libelle_salle; }
            set { libelle_salle = value; }
        }
        public int Prix_salle_heure
        {
            get { return prix_salle_heure; }
            set { prix_salle_heure = value; }
        }
        public int Id_magasin
        {
            get { return id_magasin; }
            set { id_magasin = value; }
        }

    }
}
