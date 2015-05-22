using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MaBibliotheque
{

    public class fournitManager
    {
        private SqlConnection maConnection;

        public void addFournit(fournit unFournit)
        {
            this.maConnection.Open();
            string req = "INSERT INTO FOURNIT VALUES('" + unFournit.Id_equipement + "','" + unFournit.Num_reservation + "')";
            SqlCommand cmd = new SqlCommand(req, maConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            this.maConnection.Close();
        }
    }
}
