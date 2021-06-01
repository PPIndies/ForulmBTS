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
    public partial class ListMSU : Form
    {
   
        public ListMSU()
        {
            InitializeComponent();

            ObjInsert insert = new ObjInsert();
            Compte.Text = Connexion.Compte;
            label13.Text = Compte.Text;
            label6.Visible = false;
            radioButton1.Enabled = false;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("nom_ms");
            comboBox1.Items.Add("remarque_ms");
            comboBox1.Items.Add("date_dbt_ms");
            comboBox1.Items.Add("date_fin_ms");
            comboBox1.Items.Add("NbrRepas_ms");
            comboBox1.Items.Add("Id_utl");
            comboBox1.Items.Add("Id_ville");
            comboBox1.Items.Add("Valid_ms");
            comboBox1.Items.Add("Montant_ms");
            comboBox1.SelectedItem = "nom_ms";
            listBox1.Items.Clear();
            DataTable dt = new DataTable();

            int id_utl = 0;
            MySqlConnection con = new MySqlConnection(insert.constring());
            con.Open();
            MySqlCommand da = new MySqlCommand("Select * from utilisateur where nom_utl = '" + Connexion.Compte + "'", con);
            MySqlDataReader dr;
            dr = da.ExecuteReader();
            while (dr.Read())
            {
                id_utl = Convert.ToInt32(dr["Id_utl"]);
            }
            label6.Text = Convert.ToString(id_utl);
            con.Close();


            MySqlDataAdapter da3 = new MySqlDataAdapter("Select * from mission where id_utl ='"+ id_utl+"'", "database=pj_notedefrais_gsb; server=localhost; user id=root; pwd='' ; convert zero datetime=True");
            da3.Fill(dt);

            foreach (DataRow dr3 in dt.Rows)
            {
                string nom;
                nom = dr3["nom_ms"].ToString();
                listBox1.Items.Add(nom);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from mission where " + comboBox1.Text + " Like '%" + textBox1.Text + "%' and  id_utl ='" + label6.Text + "'","database=pj_notedefrais_gsb; server=localhost; user id=root; pwd='' ; convert zero datetime=True");
            da.Fill(dt);
            listBox1.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string nom;
                nom = dr["nom_ms"].ToString();
                listBox1.Items.Add(nom);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_ms = 0;
            int valider = 0;
            string choix = listBox1.GetItemText(listBox1.SelectedItem);
            MySqlConnection con = new MySqlConnection("database=pj_notedefrais_gsb; server=localhost; user id=root; pwd='' ; convert zero datetime=True");
            con.Open();
            MySqlCommand da = new MySqlCommand("Select * from mission where " + comboBox1.Text + " Like '%" + choix + "%' and  id_utl ='" + label6.Text + "' ", con);
            MySqlDataReader dr;
            dr = da.ExecuteReader();
            while (dr.Read())
            {

                id_ms = Convert.ToInt32(dr["id_ms"]);
                label13.Text = dr["nom_ms"].ToString();
                label14.Text = dr["remarque_ms"].ToString();
                label15.Text = dr["date_dbt_ms"].ToString();
                label16.Text = dr["date_fin_ms"].ToString();
                label12.Text = dr["NbrRepas_ms"].ToString();
                label18.Text = dr["montant_ms"].ToString();

                DateTime debut = DateTime.Parse(label15.Text);
                DateTime fin = DateTime.Parse(label16.Text);


                label15.Text = Convert.ToString("'" + Convert.ToDateTime(debut).ToShortDateString() + "'");
                label16.Text = Convert.ToString("'" + Convert.ToDateTime(fin).ToShortDateString() + "'");

                valider = Convert.ToInt32(dr["valid_ms"]);
            }
            if (valider == 0)
            {

                radioButton1.Checked = false;


            }
            if (valider == 1)
            {

                radioButton1.Checked = true;

            }

            DataTable dt2 = new DataTable();
            con.Close();
            listBox2.Items.Clear();
            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from deplacement, deplacer where deplacement.Id_transport = deplacer.Id_transport and id_ms = " + id_ms, con);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {

                string nom;
                nom = dr2["Nom_transport"].ToString();
                listBox2.Items.Add(nom);
            }
            if (radioButton1.Checked == true)
            {
                radioButton1.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Gotoform(new Connexion());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Gotoform(new MenuU());
        }
    }
  
}
