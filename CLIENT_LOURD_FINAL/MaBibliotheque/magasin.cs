using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class magasin
    {
        int id_magasin;


        string adr_magasin, tel_magasin, mail_magasin, ville_magasin, cp_magasin;



        public magasin(int p_id, string p_adr_magasin, string p_tel_magasin, string p_mail_magasin, string p_ville_magasin, string p_cp_magasin)
        {
            this.id_magasin = p_id;
            this.adr_magasin = p_adr_magasin;
            this.tel_magasin = p_tel_magasin;
            this.mail_magasin = p_mail_magasin;
            this.ville_magasin = p_ville_magasin;
            this.cp_magasin = p_cp_magasin;

        }


        public int Id_magasin
        {
            get { return id_magasin; }
            set { id_magasin = value; }
        }
        public string Adr_magasin
        {
            get { return adr_magasin; }
            set { adr_magasin = value; }
        }

        public string Tel_magasin
        {
            get { return tel_magasin; }
            set { tel_magasin = value; }
        }

        public string Mail_magasin
        {
            get { return mail_magasin; }
            set { mail_magasin = value; }
        }
        public string Ville_magasin
        {
            get { return ville_magasin; }
            set { ville_magasin = value; }
        }
        public string Cp_magasin
        {
            get { return cp_magasin; }
            set { cp_magasin = value; }
        }

    }
}
