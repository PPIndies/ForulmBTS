using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace PJGSB
{
    public partial class AjtVehiculeA : Form
    {

        //appel objet de class insert
        ObjInsert insert = new ObjInsert();
        public AjtVehiculeA()
        {
            InitializeComponent();
            btn_suppr.Enabled = false;

            list_vehi.Items.Clear();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from deplacement where type_vehi = 1", insert.constring());
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string nom;
                nom = dr["Nom_vehi"].ToString();  
                list_vehi.Items.Add(nom);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Gotoform(new MenuA());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Gotoform(new Connexion());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from deplacement where type_vehi = 1 and Nom_vehi Like '%" + txtbox_nom_vehi.Text + "%'", insert.constring());
            da.Fill(dt);
            list_vehi.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string nom;
                nom = dr["Nom_vehi"].ToString();
                list_vehi.Items.Add(nom);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            insert.insertdata("insert into deplacement (Nom_transport ,Type_vehi ,Nom_vehi, ChFiscaux_vehi) values('Voiture','1','" + txtbox_nom_vehi.Text + "', '" + txtbox_nbr_chevaux.Text + "')");
            MessageBox.Show("Vahicule d'entreprise ajouter");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from deplacement where type_vehi = 1 ", insert.constring());
            da.Fill(dt);
            list_vehi.Items.Clear();
      
            foreach (DataRow dr in dt.Rows)
            {
                string nom;
                nom = dr["Nom_vehi"].ToString();
                list_vehi.Items.Add(nom);
            }
            MessageBox.Show("yo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insert.insertdata("DELETE FROM deplacement WHERE Nom_vehi = '" + txtbox_nom_vehi.Text + "' and ChFiscaux_vehi = '" + txtbox_nbr_chevaux.Text + "'");
            MessageBox.Show("Voiture supprimé");

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from deplacement where type_vehi = 1 ", insert.constring());
            da.Fill(dt);
            list_vehi.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string nom;
                nom = dr["Nom_vehi"].ToString();
                list_vehi.Items.Add(nom);
            }

            txtbox_nom_vehi.Text = "";
            txtbox_nbr_chevaux.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choix = list_vehi.GetItemText(list_vehi.SelectedItem);
            MySqlConnection con = new MySqlConnection(insert.constring());
            con.Open();
            MySqlCommand da = new MySqlCommand("Select * from deplacement where Nom_vehi Like '%" + choix + "%'", con);
            MySqlDataReader dr;
            dr = da.ExecuteReader();
            while (dr.Read())
            {
                txtbox_nom_vehi.Text = dr["Nom_vehi"].ToString();
                txtbox_nbr_chevaux.Text = dr["Chfiscaux_vehi"].ToString();

            }
            btn_suppr.Enabled = true;
            btn_cree.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btn_cree.Enabled = true;
            btn_suppr.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            btn_cree.Enabled = true;
            btn_suppr.Enabled = false;

        }
    }
}
