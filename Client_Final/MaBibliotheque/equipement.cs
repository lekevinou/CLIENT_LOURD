using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class equipement
    {
<<<<<<< HEAD
        int id, id_type;
        string nom, prix, marque, reference;

        public equipement(int p_id, string p_nom, string p_prix, string p_marque, string p_reference, int p_id_type)
=======
        int id;
        string nom, prix, marque, reference, type;

        public equipement(int p_id, string p_nom, string p_prix, string p_reference, string p_marque, string p_type)
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
        {
            this.id = p_id;
            this.nom = p_nom;
            this.prix = p_prix;
<<<<<<< HEAD
            this.marque = p_marque;
            this.reference = p_reference;
            this.id_type = p_id_type;
=======
            this.reference = p_reference;
            this.marque = p_marque;
            this.type = p_type;
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
        }

        public int Id
        {
<<<<<<< HEAD
            get { return id; }
            set { id = value; }
        }

=======
           get { return id; }
           set { id = value; }
       }
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
        public string Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }
        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }
<<<<<<< HEAD
        public int Id_type
        {
            get { return id_type; }
            set { id_type = value; }
        }
=======
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
       
>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
    }
}
