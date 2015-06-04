using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaBibliotheque
{
    public class personnel
    {
        int id_personnel, id_magasin, id_poste, id_statut;






        string nom_personnel, prenom_personnel, tel_personnel, mail_personnel, adr_personnel_l1, adr_personnel_l2, ville_personnel, cp_personnel, login_personnel, mdp_personnel;





        DateTime date_entree;



        public personnel(int p_id, string p_nom, string p_prenom, string p_tel, string p_mail, string p_adr1, string p_adr2, string p_ville, string p_cp, string p_login, string p_mdp, DateTime p_date_entree, int p_id_magasin, int p_id_poste, int p_id_statut)
        {
            this.id_personnel = p_id;
            this.nom_personnel = p_nom;
            this.prenom_personnel = p_prenom;
            this.tel_personnel = p_tel;
            this.mail_personnel = p_mail;
            this.adr_personnel_l1 = p_adr1;
            this.adr_personnel_l2 = p_adr2;
            this.ville_personnel = p_ville;
            this.cp_personnel = p_cp;
            this.login_personnel = p_login;
            this.mdp_personnel = p_mdp;
            this.date_entree = p_date_entree;
            this.id_magasin = p_id_magasin;
            this.id_poste = p_id_poste;
            this.id_statut = p_id_statut;
        }
        public int Id_personnel
        {
            get { return id_personnel; }
            set { id_personnel = value; }
        }

        public string Nom_personnel
        {
            get { return nom_personnel; }
            set { nom_personnel = value; }
        }


        public string Prenom_personnel
        {
            get { return prenom_personnel; }
            set { prenom_personnel = value; }
        }
        public string Tel_personnel
        {
            get { return tel_personnel; }
            set { tel_personnel = value; }
        }

        public string Mail_personnel
        {
            get { return mail_personnel; }
            set { mail_personnel = value; }
        }

        public string Adr_personnel_l1
        {
            get { return adr_personnel_l1; }
            set { adr_personnel_l1 = value; }
        }

        public string Adr_personnel_l2
        {
            get { return adr_personnel_l2; }
            set { adr_personnel_l2 = value; }
        }

        public string Ville_personnel
        {
            get { return ville_personnel; }
            set { ville_personnel = value; }
        }


        public string Cp_personnel
        {
            get { return cp_personnel; }
            set { cp_personnel = value; }
        }


        public string Login_personnel
        {
            get { return login_personnel; }
            set { login_personnel = value; }
        }
        public string Mdp_personnel
        {
            get { return mdp_personnel; }
            set { mdp_personnel = value; }
        }


        public DateTime Date_entree
        {
            get { return date_entree; }
            set { date_entree = value; }
        }

        public int Id_magasin
        {
            get { return id_magasin; }
            set { id_magasin = value; }
        }

        public int Id_poste
        {
            get { return id_poste; }
            set { id_poste = value; }
        }

        public int Id_statut
        {
            get { return id_statut; }
            set { id_statut = value; }
        }

    
    }
}
