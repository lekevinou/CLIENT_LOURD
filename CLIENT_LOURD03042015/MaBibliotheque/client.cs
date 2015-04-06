using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class client
    {
        int id;
        string tel, prenom, nom, adresse1, adresse2, mail;
        public client(int p_id, string p_nom, string p_prenom, string p_adr1, string p_adr2, string p_tel, string p_mail)
        {
            this.id = p_id;
            this.prenom = p_prenom;
            this.nom = p_nom;
            this.adresse1 = p_adr1;
            this.adresse2 = p_adr2;
            this.tel = p_tel;
            this.mail = p_mail;

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public string Adresse2
        {
            get { return adresse2; }
            set { adresse2 = value; }
        }
        public string Adresse1
        {
            get { return adresse1; }
            set { adresse1 = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

    }
}
