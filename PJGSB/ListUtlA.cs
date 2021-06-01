using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Librairie MySQL ajouté précédemment dans les référence
using MySql.Data.MySqlClient;

namespace PJGSB
{
    public partial class ListUtlA : Form
    {
        //appel objet de class insert
        ObjInsert insert = new ObjInsert();


        public ListUtlA()
        {
            InitializeComponent();
            //remplissage de la comboBox pour le trie
            cbBox_filtre.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBox_filtre.Items.Add("nom_utl");
            cbBox_filtre.Items.Add("pnom_utl");
            cbBox_filtre.Items.Add("id_utl");
            cbBox_filtre.Items.Add("id_ville");
            cbBox_filtre.Items.Add("poste_utl");
            cbBox_filtre.SelectedItem = "nom_utl";
            list_utl.Items.Clear();

            //remplissage de la liste d'utilisateur
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from utilisateur" , insert.constring());
            da.Fill(dt);

           
            foreach (DataRow dr in dt.Rows)
            {
                string nom;
                nom = dr["nom_utl"].ToString();
                list_utl.Items.Add(nom);
            }
        }

        private void ListUtlA_Load(object sender, EventArgs e)
        {
      // on rappele sur quelle compte on s'est co
                lbl_compte.Text = Connexion.Compte;
       
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from utilisateur where " + cbBox_filtre.Text + " Like '%" + txtBox_filtre.Text + "%'", insert.constring());
            da.Fill(dt);
            list_utl.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string nom;
                nom = dr["nom_utl"].ToString();
                list_utl.Items.Add(nom);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //remplir les information lorsque que l'on clique sur un utiolisateur
            string choix = list_utl.GetItemText(list_utl.SelectedItem);
            MySqlConnection con = new MySqlConnection(insert.constring());
            con.Open();
            MySqlCommand da = new MySqlCommand("Select * from utilisateur where  " + cbBox_filtre.Text + " Like '%" + choix + "%'", con);
            MySqlDataReader dr;
            dr = da.ExecuteReader();
            while (dr.Read())
            {
                lbl_nom.Text = dr["nom_utl"].ToString();
                lbl_pnom.Text = dr["pnom_utl"].ToString();
                lbl_poste.Text = dr["poste_utl"].ToString();
                lbl_mdp.Text = dr["mdp_utl"].ToString();
                lbl_ville.Text = dr["id_ville"].ToString();
                int compte = Convert.ToInt32(dr["id_compte"]);
                if ( compte == 1)
                {
                    Radio_utl.Checked = true;
                }
                if (compte == 2)
                {
                    Radio_cpt.Checked = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuA fm = new MenuA();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Gotoform(new Connexion());
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //
            insert.insertdata("Update utilisateur SET mdp_utl ='"+ txtBox_mdp.Text +"' where  nom_utl Like '" + lbl_nom.Text + "'");
            MessageBox.Show(" Mot de passe modifier ");  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insert.insertdata("delete from utilisateur where  nom_utl Like '" + lbl_nom.Text + "'");
            MessageBox.Show("Utilisateur supprimer ");
        }


    }
}  
