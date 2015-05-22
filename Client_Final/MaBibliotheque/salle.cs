using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class salle
    {
<<<<<<< HEAD
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
=======
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

>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
        public string Libelle_salle
        {
            get { return libelle_salle; }
            set { libelle_salle = value; }
        }
<<<<<<< HEAD
=======
        

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

>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
        public int Prix_salle_heure
        {
            get { return prix_salle_heure; }
            set { prix_salle_heure = value; }
        }
<<<<<<< HEAD
=======

>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
        public int Id_magasin
        {
            get { return id_magasin; }
            set { id_magasin = value; }
        }

<<<<<<< HEAD
=======
        public int Id_salle
        {
            get { return id_salle; }
            set { id_salle = value; }
        }



>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
    }
}
