using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class salle
    {
        int id_salle, id_magasin, prix_salle_heure, nb_place;
        string libelle_salle;
        float taille_salle;

        public salle(int p_id_salle,
            int p_id_magasin,
            int p_prix_salle_heure,
            int p_nb_place,
            string p_libelle_salle,
            float p_taille_salle)
        {
            this.id_salle = p_id_salle;
            this.id_magasin = p_id_magasin;
            this.prix_salle_heure = p_prix_salle_heure;
            this.nb_place = p_nb_place;
            this.libelle_salle = p_libelle_salle;
            this.taille_salle = p_taille_salle;

        }

        public string Libelle_salle
        {
            get { return libelle_salle; }
            set { libelle_salle = value; }
        }
        

        public float Taille_salle
        {
            get { return taille_salle; }
            set { taille_salle = value; }
        }
        public int Nb_place
        {
            get { return nb_place; }
            set { nb_place = value; }
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

        public int Id_salle
        {
            get { return id_salle; }
            set { id_salle = value; }
        }



    }
}
