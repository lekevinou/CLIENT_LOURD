using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class equipement
    {
        int id;
        string nom, prix, marque, reference, type;

        public equipement(int p_id, string p_nom, string p_prix,string p_reference, string p_marque, string p_type)
        {
            this.id = p_id;
            this.nom = p_nom;
            this.prix = p_prix;
            this.reference = p_reference;
            this.marque = p_marque;
            this.type = p_type;
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
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
