using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //string Test = "Test";
            datagridview_ParJour.Columns.Add("Salle1", "Salle 1");
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

            }
        }
    }
}
