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
    public partial class gestionClientView : Form
    {
        public gestionClientView()
        {
            InitializeComponent();
        }

        private void viewClient_Load(object sender, EventArgs e)
        {

            string critere = "";
            clientManager clientManager = new clientManager();
            List<client> clientList = new List<client>(); // On crée la liste de client
            clientList = clientManager.getListClient(critere); // La liste se compose de la liste clientList retourné par le clientManager
            //listViewClient.Items.Clear();  
            
            //foreach (client unClient in clientList) //On parcour la liste 
            //{
            //    ListViewItem item = new ListViewItem(unClient.Nom.ToString());
            //    listViewClient.CheckBoxes = true;
            //    item.SubItems.Add(unClient.Prenom.ToString());
            //    item.SubItems.Add(unClient.Adresse1.ToString());
            //    item.SubItems.Add(unClient.Adresse2.ToString());
            //    item.SubItems.Add(unClient.Tel.ToString());
            //    item.SubItems.Add(unClient.Mail.ToString());
            //    listViewClient.Items.Add(item); //On ajoute les items à la ListView
            //}

            foreach (client unClient in clientList)
            {
                dataGridClient.Rows.Add(unClient.Nom, 
                    unClient.Prenom,
                    unClient.Adresse1,
                    unClient.Adresse2,
                    unClient.Tel,
                    unClient.Mail);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ouverture de la page viewClient.cs.
            gestionClientAjout f = new gestionClientAjout();
            this.Hide();
            f.ShowDialog();
            // Fermeture de la page actuelle.
            this.Close();
        }

        private void btn_valider_recherche_Click(object sender, EventArgs e)
        {
            // Au clic sur le bouton rechercher, on reconstruit la listView
            string critere = text_rechercheClient.Text;
            clientManager clientManager = new clientManager();
            List<client> clientList = new List<client>(); // On crée la liste de client
            clientList = clientManager.getListClient(critere); // La liste se compose de la liste clientList retourné par le clientManager
            //listViewClient.Items.Clear();
            //foreach (client unClient in clientList) //On parcour la liste 
            //{
            //    ListViewItem item = new ListViewItem(unClient.Nom.ToString());
            //    item.SubItems.Add(unClient.Prenom.ToString());
            //    item.SubItems.Add(unClient.Adresse1.ToString());
            //    item.SubItems.Add(unClient.Adresse2.ToString());
            //    item.SubItems.Add(unClient.Tel.ToString());
            //    item.SubItems.Add(unClient.Mail.ToString());
            //    listViewClient.Items.Add(item); //On ajoute les items à la ListView
            //}

            dataGridClient.Rows.Clear();
            foreach (client unClient in clientList)
            {
                dataGridClient.Rows.Add(unClient.Nom,
                    unClient.Prenom,
                    unClient.Adresse1,
                    unClient.Adresse2,
                    unClient.Tel,
                    unClient.Mail);
            }
        }

        private void btn_refresh_list_view_client_Click(object sender, EventArgs e)
        {
            viewClient_Load(sender, e);
            text_rechercheClient.Text = string.Empty;

        }

        private void back_fromViewClient_Click(object sender, EventArgs e)
        {
            // Ouverture de la page viewClient.cs.
            gestionClient f = new gestionClient();
            this.Hide();
            f.ShowDialog();
            // Fermeture de la page actuelle.
            this.Close();
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
           // client clientSelectionne = listViewClient.SelectedItems.ToString();
        }

        private void dataGridClient_DoubleClick(object sender, EventArgs e)
        {
            testTextBox.Text = dataGridClient.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
