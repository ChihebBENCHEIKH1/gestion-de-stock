using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionDeStock.PL
{
    public partial class frm_client_commande : Form
    {
        private dbStockContext db;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-672AMT3;Initial Catalog=GESTION_DE_STOCK;Integrated Security=True");

        public frm_client_commande()
        {
            InitializeComponent();
            db= new dbStockContext();
        }

        private void frm_client_commande_Load(object sender, EventArgs e)
        {
            
        string v = "select ID_Client as ID,Nom_Client as Nom,Prenom_Client as Prénom,Adresse_Client as Adresse,Telephonne_Client as Télephone,Pays_Client as Pays,Ville_Client as Ville,Email as Mail from Client";
            SqlDataAdapter sda = new SqlDataAdapter(v, conn);
            DataSet ds = new System.Data.DataSet();
            sda.Fill(ds);
            dvgclient.DataSource = ds.Tables[0];

        }

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgclient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
