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
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Client_LOURD
{
    public partial class login : Form
    {
        private SqlConnection maConnection;
        public login()
        {
            InitializeComponent();
            bdd connection = new bdd();
            this.maConnection = connection.MaConnection;
        }

        private void quitter_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bdd cnx = new bdd();
        private void login_Load(object sender, EventArgs e)
        {
            maConnection.Open();
        }

        private void connect_btn_Click(object sender, EventArgs e)
        {
            //La valeur rentré par l'utilisateur est stocké dans une variable
            string mdpstr = password_textBox.Text; 
            
            MD5 md5Hash = MD5.Create();

            //Variable qui va contenir le mot de passe Encodé rentré par l'utilisateur.
            string mdpstrHash = GetMd5Hash(md5Hash, mdpstr);

            //Requête qui récupère le mot de passe en fonction de l'username rentré.
            string req = "SELECT mdp_magasin FROM MAGASIN WHERE username_magasin ='" + username_textBox.Text + "'";
            
            try
            {
                SqlCommand MaCommande = new SqlCommand(req, maConnection);
                SqlDataReader reader = MaCommande.ExecuteReader();
                reader.Read();
                   
                // Si le mot de passe récupéré grâce à la requête == au mdp rentré par l'utilisateur
                if (reader["mdp_magasin"].ToString() == mdpstrHash)
                {
                    //this.Focus();
                    //Alors on est connecté et on affiche la fenêtre d'accueil
                    Index Index = new Index(username_textBox.Text);
                    Index.Show();
                    this.Hide();
                    //MessageBox.Show("Connecté");
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect");
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Login ou mot de passe incorrect");
            }
 
        }

        //Methode Encodage mot de passe.
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
