using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MaBibliotheque
{
    public class cp_ville
    {
        int id_ville;
        string code_postal, nom_ville;

        public cp_ville(int p_id_ville, string p_code_postal, string p_nom_ville)
        {
            this.id_ville = p_id_ville;
            this.code_postal = p_code_postal;
            this.nom_ville = p_nom_ville;
        }
        public int Id_ville
        {
            get { return id_ville; }
            set { id_ville = value; }
        }
        public string Nom_ville
        {
            get { return nom_ville; }
            set { nom_ville = value; }
        }

        public string Code_postal
        {
            get { return code_postal; }
            set { code_postal = value; }
        }
    }
}
