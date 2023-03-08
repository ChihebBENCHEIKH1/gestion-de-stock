using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionDeStock.BL
{
     class Myconnection
    {
        public SqlConnection con;
        public Myconnection()
        {
            con = new SqlConnection("Data Source=DESKTOP-672AMT3;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True");
        }
        public static string type;
        
    }
}
