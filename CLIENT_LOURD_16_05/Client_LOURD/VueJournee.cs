using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaBibliotheque;

namespace Client_LOURD
{
    public partial class VueJournee : Form
    {
        public VueJournee()
        {
            InitializeComponent();
        }

        private void VueJournee_Load(object sender, EventArgs e)
        {
            salleManager salleManager = new salleManager();
            List<salle> sallesList = new List<salle>();
            sallesList = salleManager.getListSalles();
            foreach(salle uneSalle in sallesList) //On remplit les colonnes du datagridview
            {
                // Une colonne = le libelle de la salle
                datagridview_ParJour.Columns.Add(uneSalle.Libelle_salle, uneSalle.Libelle_salle.ToString().ToUpper());
            }       

            for (int i = 0; i <= 24; i++ ) //Ajout dans la colonne vides, des horaires
            {
                datagridview_ParJour.Rows.Add(i + "h00");
            }
        }
    }
}
