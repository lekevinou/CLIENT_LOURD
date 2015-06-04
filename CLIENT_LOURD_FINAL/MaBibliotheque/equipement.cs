using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class equipement
    {
        int id, id_type;
        string nom, prix, marque, reference;

        public equipement(int p_id, string p_nom, string p_prix, string p_marque, string p_reference, int p_id_type)
        {
            this.id = p_id;
            this.nom = p_nom;
            this.prix = p_prix;
            this.marque = p_marque;
            this.reference = p_reference;
            this.id_type = p_id_type;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

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
        public int Id_type
        {
            get { return id_type; }
            set { id_type = value; }
        }
    }
}
