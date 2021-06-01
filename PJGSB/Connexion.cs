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
    public partial class Connexion : Form
    {
        public static string Compte = "unknowm";
        MySqlConnection connexion = new MySqlConnection("database=pj_notedefrais_gsb; server=localhost; user id=root; pwd=");
        public Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            connexion.Open();
            MySqlCommand cmd = connexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from utilisateur where Nom_utl ='" + txtBox_id.Text + "' and Mdp_utl ='" + txtBox_mdp.Text + "' and ID_Compte =1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if(i == 0)
                {
                int j = 0;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from utilisateur where Nom_utl ='" + txtBox_id.Text + "' and Mdp_utl ='" + txtBox_mdp.Text + "' and ID_Compte =2";
                cmd.ExecuteNonQuery();
                Compte = txtBox_id.Text ;
                da.Fill(dt);
                j = Convert.ToInt32(dt.Rows.Count.ToString());

                if (j == 0)
                {
                    label3.Text = "Mot de passe ou identifiant invalide";
                    connexion.Close();
                }
                else
                {
                    Compte = txtBox_id.Text;
                    this.Gotoform(new MenuA());

                }
            }
                else
                {
                Compte = txtBox_id.Text;
                this.Gotoform(new MenuU());
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connexion.Open();
                MessageBox.Show("GG bro on try");
                connexion.Close();
            }
            catch (MySqlException co)
            {
                MessageBox.Show(co.ToString());
                MessageBox.Show("Marche pas bro");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtBox_mdp.PasswordChar = '*';
        }
    }
}
