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
    public partial class AjtUtl : Form
    {
        //appel objet de class insert
        ObjInsert insert = new ObjInsert();
        public AjtUtl()
        {
            InitializeComponent();
            listBox_utl.Items.Clear();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from utilisateur", insert.constring());
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string pnom;
                string nom;
                nom = dr["nom_utl"].ToString();
                pnom = dr["pnom_utl"].ToString();
                listBox_utl.Items.Add(pnom + nom);
            }
        }


     

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 2;
            if (radio_utl.Checked == true)
            {
                i = 2;
            }
            if (radio_cmpt.Checked == true)
            {
                i = 1;
            }

            insert.insertdata("insert into utilisateur(nom_utl, Pnom_utl, Mdp_utl, Poste_utl, ID_Compte, ID_Ville) values('" + txtbox_nom.Text + "', '" + txt_pnom.Text + "', '" + txtbox_mdp.Text + "', '" + txtbox_poste.Text + "', '" + i + "', '" + txtbox_ville.Text + "')");
            MessageBox.Show("Utilisateur ajouter");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("database=pj_notedefrais_gsb; server=localhost; user id=root; pwd=");

            try
            {
                connexion.Open();
                MessageBox.Show("GG bro on try");
            }
            catch (MySqlException co)
            {
                MessageBox.Show(co.ToString());
                MessageBox.Show("Marche pas bro");
                connexion.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from utilisateur where nom_utl Like '%" + txtBox_filtresimple.Text + "%'", insert.constring());
            da.Fill(dt);
            listBox_utl.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string pnom;
                string nom;
                nom = dr["nom_utl"].ToString();
                pnom = dr["pnom_utl"].ToString();
                listBox_utl.Items.Add(pnom + nom);
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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void AjtUtl_Load(object sender, EventArgs e)
        {
            lbl_compte.Text = Connexion.Compte;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

