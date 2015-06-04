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
<<<<<<< HEAD
            foreach(salle uneSalle in sallesList) //On remplit les colonnes du datagridview
            {
                // Une colonne = le libelle de la salle
                datagridview_ParJour.Columns.Add(uneSalle.Libelle_salle, uneSalle.Libelle_salle.ToString().ToUpper());
            }       

            for (int i = 0; i <= 24; i++ ) //Ajout dans la colonne vides, des horaires
            {
                datagridview_ParJour.Rows.Add(i + "h00");
=======
            int test = 0;
            datagridview_ParJour.Columns.Add("Salle1", "Salle 1");
            foreach(salle uneSalle in sallesList)
            {
                //test++;
                //MessageBox.Show(uneSalle.Libelle_salle);
                datagridview_ParJour.Columns.Add(uneSalle.Libelle_salle, uneSalle.Libelle_salle.ToString().ToLower());
            }
            MessageBox.Show(test.ToString());
            //string Test = "Test";
            
            //foreach (DataGridViewRow row in datagridview_ParJour.Rows)
            //{
            //    DataGridViewCellStyle monStyle = new DataGridViewCellStyle(datagridview_ParJour.Columns[0].DefaultCellStyle);

            //    DataGridViewCell Cellule = row.Cells["Salle1"];
            //    monStyle.ForeColor = Color.Blue;
            //    Cellule.Style = monStyle;
            //}

            //DataGridViewCell cell = datagridview_ParJour[1, 1];
            //cell.Style.BackColor = Color.Black;

            

            for (int i = 0; i <= 24; i++ ) //Ajout dans la colonne vides, des horaires
            {
                datagridview_ParJour.Rows.Add(i + "h00", "Occupée");

>>>>>>> b9e9e641cb7bdd683b335c1d84d6c52936a75fd9
            }
        }
    }
}
