using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MaBibliotheque
{
    public class bdd
    {
        //public SqlConnection MaConnection = new SqlConnection(@"Data Source=KEVIN-TOSH;Initial Catalog=gamilonbase;Integrated Security=True");
        public SqlConnection MaConnection = new SqlConnection(@"Data Source=PC-THOMAS;Initial Catalog=gamilonbase;Integrated Security=True");
        public SqlDataReader dr;
        public string req;
    }
}
