using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class Form1 : Form
    {
        PL.UserControl1 user = null;
        public Form1()
        {

            InitializeComponent();
            panel1.Size = new Size(229, 612);
            pnlpara.Visible = false;
            panel3.Visible = false;
            btnuti.Visible = false;
            UserControl1 US = new UserControl1();
            US.button5.Visible = false;
            US.button4.Visible = false;

        }
        public void DesactiverForm()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncomm.Enabled = false;
            btncat.Enabled = false;
            btnuti.Enabled = false;
            btnuti.Visible = false;
            btnrestaurer.Enabled = false;
            btndeconnexion.Enabled = false;
            btncopie.Enabled = false;
            pnlbut.Enabled = false;
            btnconnexion.Enabled = true;
            /*UserControl1 US = new UserControl1();
            US.button5.Visible = false;
            US.button4.Visible = false;
            User_liste_prod pr = new User_liste_prod();
            pr.buttsupprimer.Visible = false;
            pr.buttmodifier.Visible = false;
            US.button5.Enabled = false;
            US.button4.Enabled = false;
            pr.buttsupprimer.Enabled = false;
            pr.buttmodifier.Enabled = false;*/


        }
        public void DesactiverFormUtilisateur()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncomm.Enabled = false;
            btncat.Enabled = false;
            btnuti.Enabled = false;
            btnuti.Visible = false;
            btnrestaurer.Enabled = false;
            btndeconnexion.Enabled = false;
            btncopie.Enabled = false;
            pnlbut.Enabled = false;
            btnconnexion.Enabled = true;
            
            /* UserControl1 US = new UserControl1();
             US.button5.Visible = false;
             US.button5.Enabled = false;
             US.button4.Enabled = false;
             User_liste_prod pr = new User_liste_prod();
             pr.buttsupprimer.Visible = false;
             pr.buttsupprimer.Enabled = false;
             pr.buttmodifier.Enabled = false;*/

        }
        public void activerForm()
        {
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncomm.Enabled = true;
            btncat.Enabled = true;
            btnuti.Enabled = true;
            btnuti.Visible = true;
            btnrestaurer.Enabled = true;
            btndeconnexion.Enabled = true;
            btncopie.Enabled = true;
            pnlbut.Enabled = true;
            btnconnexion.Enabled = false;
            pnlpara.Visible = false;
            UserControl1 US = new UserControl1();
            US.button5.Visible = true;
            US.button4.Visible = true;

            /*UserControl1 US = new UserControl1();
            US.button5.Visible = true;
            US.button5.Enabled= true;
            US.button4.Enabled = true;
            User_liste_prod pr = new User_liste_prod();
            pr.buttsupprimer.Visible = true;
            pr.buttsupprimer.Enabled= true;
            pr.buttmodifier.Visible = true;*/

        }
        public void activerFormUtilisateur()
        {
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncomm.Enabled = true;
            btncat.Enabled = true;
            btnuti.FlatStyle = FlatStyle.Flat;
            btnuti.FlatAppearance.BorderColor = BackColor;
            btnuti.FlatAppearance.MouseOverBackColor = BackColor;
            btnuti.FlatAppearance.MouseDownBackColor = BackColor;
            btnuti.Enabled = false;
            btnuti.Visible = false;
            btnrestaurer.Enabled = true;
            btndeconnexion.Enabled = true;
            btncopie.Enabled = true;
            pnlbut.Enabled = true;
            btnconnexion.Enabled = false;
            pnlpara.Visible = false;
            
            /* UserControl1 US = new UserControl1();
             US.button5.Enabled= false;
             US.button5.Enabled = false;
             US.button4.Enabled = false;
             US.button4.Enabled = false;
             User_liste_prod pr = new User_liste_prod();
                 pr.buttsupprimer.Visible = false;
             pr.buttmodifier.Visible = false;
             US.button5.FlatAppearance.BorderColor = BackColor;
             US.button5.FlatAppearance.MouseOverBackColor = BackColor;
             US.button5.FlatAppearance.MouseDownBackColor = BackColor;
             US.button4.FlatAppearance.BorderColor = BackColor;
             US.button4.FlatAppearance.MouseOverBackColor = BackColor;
             US.button4.FlatAppearance.MouseDownBackColor = BackColor;*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           DesactiverForm();
            
            
            
          
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btnclient.Top;
           /* if (BL.Myconnection.type == "A")
            {
                UserControl1 US = new UserControl1();
                US.button5.Visible = true;
                US.button4.Visible = true;
                
            }
            else
            {
                UserControl1 US = new UserControl1();
                US.button5.Visible =false;
                US.button4.Visible =false;
            }*/
            
            panel3.Visible = true;
            if (!panel3.Controls.Contains(UserControl1.Instance))
            {
                panel3.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
            else
                UserControl1.Instance.BringToFront();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           pnlbut.Top = btnproduit.Top;
            /*if(BL.Myconnection.type=="U")
            {
                User_liste_prod us = new User_liste_prod();
                us.buttmodifier.Hide();
                us.buttsupprimer.Hide();
            }
            */
            panel3.Visible = true;
            if (!panel3.Controls.Contains(User_liste_prod.Instance))
            {
                panel3.Controls.Add(User_liste_prod.Instance);
                User_liste_prod.Instance.Dock = DockStyle.Fill;
                User_liste_prod.Instance.BringToFront();
            }
            else
                User_liste_prod.Instance.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btnuti.Top;
            panel3.Visible=true;
            if (!panel3.Controls.Contains(User_liste_utilisateur.Instance))
            {
                panel3.Controls.Add(User_liste_utilisateur.Instance);
                User_liste_utilisateur.Instance.Dock = DockStyle.Fill;
                User_liste_utilisateur.Instance.BringToFront();
            }
            else
                User_liste_utilisateur.Instance.BringToFront();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 229)
            {
                panel1.Size = new Size(82, 612);
            }
            else
            {
                panel1.Size = new Size(229, 612);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btncomm.Top;
            panel3.Visible = true;
            if (!panel3.Controls.Contains(Liste_commande.Instance))
            {
                panel3.Controls.Add(Liste_commande.Instance);
                Liste_commande.Instance.Dock = DockStyle.Fill;
                Liste_commande.Instance.BringToFront();
            }
            else
                Liste_commande.Instance.BringToFront();
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btncat.Top;
            panel3.Visible = true;
            if (!panel3.Controls.Contains(User_liste_categorie.Instance))
            {
                panel3.Controls.Add(User_liste_categorie.Instance);
                User_liste_categorie.Instance.Dock = DockStyle.Fill;
                User_liste_categorie.Instance.BringToFront();
            }
            else
                User_liste_categorie.Instance.BringToFront();
        }
    
    

    private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            pnlpara.Size = new Size(267, 191);
            pnlpara.Visible = !pnlpara.Visible;
        }

        private void pnlpara_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FormConnex frmc= new FormConnex(this);
            frmc.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btndeconnexion_Click(object sender, EventArgs e)
        {
            DesactiverForm();
            BL.Myconnection.type = "";
        }

        private void btnclient_Leave(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
