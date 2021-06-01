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
    public partial class AjtMissU : Form
    {

        int avion = 0;
        int train = 0;
        int voiturepriv = 0;
        int voiturepro = 0;
        int hebergement = 0;
        string nom_vehipro = "";
        string nom_vehipriv = "";
        int ChFiscaux_vehipro;
        int ChFiscaux_vehipriv;

        int pxtrain;
        int pxavion;
        double pxtotale;


        double coef;

        ObjInsert insert = new ObjInsert();



        public AjtMissU()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Gotoform(new Connexion());
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Gotoform(new MenuU());

        }

        private void AjtMissU_Load(object sender, EventArgs e)
        {
            label13.Text = Connexion.Compte;
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox1.Show();
            }
            else
            {
                hebergement = 0;
                LieuMS.Text = "";
            }
        }



        // ------------------- HERBERGEMENT-----------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            hebergement = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            groupBox1.Hide();
            LieuMS.Text = "";
        }


        // -------------------TRAIN -----------------------------
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                 train = 1;
                groupBox4.Show();
            }
            else
            {
                train = 0;
                pxtrain = 0;
            }      
   

        }
   
        private void button10_Click(object sender, EventArgs e)
        {
            pxtrain = 0;
            groupBox4.Hide();
            checkBox2.Checked = false;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            pxtrain = Convert.ToInt32(textBox8.Text);
            groupBox4.Hide();
        }
        // -------------------AVION -----------------------------
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                avion = 1;
                groupBox5.Show();
            }
            else
            {
                avion = 0;
            }


        }  
        private void button13_Click(object sender, EventArgs e)
        {
            pxavion = Convert.ToInt32(textBox12.Text);
            groupBox5.Hide();
        }  
        private void button12_Click(object sender, EventArgs e)
        {
            pxavion = 0;
            groupBox5.Hide();
            checkBox3.Checked = false;
        }

        // -------------------VOITURE PRIVEE -----------------------------

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                voiturepriv = 1;
                groupBox2.Show();

            }
            else
            {
                voiturepriv = 0;
            }
        }     
        private void button7_Click(object sender, EventArgs e)
        {
            nom_vehipriv = "";
            ChFiscaux_vehipriv = 0;
            groupBox2.Hide();
            checkBox4.Checked = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            nom_vehipriv = textBox10.Text;
            ChFiscaux_vehipriv = Convert.ToInt32(textBox9.Text);
            groupBox2.Hide();
        }


        // -------------------VOITURE PRO -----------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            nom_vehipro = "";
            ChFiscaux_vehipro = 0;
            groupBox3.Hide();
            checkBox5.Checked = false;

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                voiturepro = 1;
                groupBox3.Show();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("Select * from deplacement where type_vehi = 1 ", insert.constring());
                da.Fill(dt);
                listBox1.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    nom_vehipro = dr["Nom_vehi"].ToString();
                    listBox1.Items.Add(nom_vehipro);
                }

            }
            else
            {
                voiturepro = 0;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choix = listBox1.GetItemText(listBox1.SelectedItem);
            MySqlConnection con = new MySqlConnection(insert.constring());
            con.Open();
            MySqlCommand da = new MySqlCommand("Select * from deplacement where Nom_vehi Like '%" + choix + "%'", con);
            MySqlDataReader dr;
            dr = da.ExecuteReader();
            while (dr.Read())
            {
                nom_vehipro = dr["Nom_vehi"].ToString();
                ChFiscaux_vehipro = Convert.ToInt32(dr["Chfiscaux_vehi"]);

            }
            button3.Enabled = true;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Hide();
        }



        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sur ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //-----------------------------Creation de la voiture privé---------------------------------------- 
                if (voiturepriv == 1)
                {
                    insert.insertdata("insert into deplacement(Type_vehi ,Nom_vehi, ChFiscaux_vehi, Id_transport ) values('2','" + nom_vehipriv + "', '" + ChFiscaux_vehipriv + "' , '3' )");
                }

                //----------------------------creation de l'hebergement-------------------------------------------
                if (hebergement == 1)
                {
                    int i = 0;
                    MySqlConnection connexion = new MySqlConnection("database=pj_notedefrais_gsb; server=localhost; user id=root; pwd=");
                    connexion.Open();
                    MySqlCommand cmd = connexion.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select Nom_hbg from hebergement where Nom_hbg = '" + LieuMS.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter db = new MySqlDataAdapter(cmd);
                    db.Fill(dt);
                    i = Convert.ToInt32(dt.Rows.Count.ToString());
                    if (i == 0)
                        insert.insertdata("insert into hebergement(Nom_hbg	 ) values('" + LieuMS.Text + "')");
                }

                //-----------------------------Calculé le prix de la mission--------------------------------------------

                //pxtotale est a la fin egale a 
                //          prix avion + prix train + coeff(dedomagement)*km + nbr de nuit * 60 + nombre de repas *15
                //



                //Calcule px deplacement
                pxtotale = pxtrain + pxavion;
                MessageBox.Show("'" + pxtotale + "'");
                if (voiturepriv == 1)
                {
                    MySqlConnection connexion = new MySqlConnection(insert.constring());
                    connexion.Open();
                    MySqlCommand co = new MySqlCommand("Select * from deplacement where Type_vehi = '3' and nom_vehi Like '" + nom_vehipriv + "'", connexion);
                    MySqlDataReader read;
                    read = co.ExecuteReader();
                    while (read.Read())
                    {
                        ChFiscaux_vehipriv = Convert.ToInt32(read["Chfiscaux_vehi"]);
                    }

                    if (ChFiscaux_vehipriv == 0)
                        MessageBox.Show("Nombre de chevaux fiscaux invalide");
                    if (ChFiscaux_vehipriv <= 3 && ChFiscaux_vehipriv <= 3)
                    {
                        coef = 0.456;
                    }
                    if (ChFiscaux_vehipriv == 4)
                    {
                        coef = 0.523;
                    }
                    if (ChFiscaux_vehipriv == 5)
                    {
                        coef = 0.548;
                    }
                    if (ChFiscaux_vehipriv == 6)
                    {
                        coef = 0.574;
                    }
                    if (ChFiscaux_vehipriv >= 7)
                    {
                        coef = 0.601;
                    }
                    MessageBox.Show("'" + coef + "'");
                    pxtotale +=Convert.ToInt32(textBox11.Text) * coef;
                    MessageBox.Show("'" + pxtotale + "'");
                }

                 
                //Calcule nombre de jour
                double day;
                DateTime date = DateTime.Parse(textBox5.Text);
                DateTime date2 = DateTime.Parse(textBox6.Text);
                TimeSpan tsElapsed = date2.Subtract(date);
                day = tsElapsed.TotalDays - 1 ;
                MessageBox.Show("'" +  day + "'");

                pxtotale += day * 60;
                MessageBox.Show("'" + pxtotale + "'");

                //ajout prix repas 
                pxtotale += 15 * Convert.ToInt32(textBox3.Text);
                MessageBox.Show("'" + pxtotale + "'");

                //-------------------------Creation Mission base de donnée------------------------------

                //--- retrouve l'id de l'utilisateur connecter 
                int id =0;
                MySqlConnection con = new MySqlConnection(insert.constring());
                con.Open();
                MySqlCommand da = new MySqlCommand("Select * from utilisateur where nom_utl = '"+ Connexion.Compte + "'", con);
                MySqlDataReader dr;
                dr = da.ExecuteReader();
                while (dr.Read())
                {
                   id = Convert.ToInt32(dr["Id_utl"]);
                }
                con.Close();
                // ------ insert de la mission
                insert.insertdata("INSERT INTO `mission`(`Montant_ms`, `Nom_ms`, `Remarque_ms`, `Date_dbt_ms`, `Date_fin_ms`, `NbrRepas_ms`, `Id_utl`, `Id_ville`, `Valid_ms`) VALUES ('" + pxtotale + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox3.Text + "','" + id + "','" + textBox7.Text + "','0')");

                //--------------- joindre les donnée pour l'hebergement et le transport -------------

                // recherche de l'id de l'herbgement
                int id_hebergement = 0;
                if (hebergement == 1)
                {
                    con.Open();
                    MySqlCommand de = new MySqlCommand("Select Id_hbg from hebergement where Nom_hbg = '" + LieuMS.Text + "'", con);
                    dr = de.ExecuteReader();

                    while (dr.Read())
                    {
                        id_hebergement = Convert.ToInt32(dr["Id_hbg"]);
                    }
                    con.Close();
                }
                MessageBox.Show(" id hebergement trouver");
                // recherche de l'id de la mission
                int id_mission = 0;
                con.Open();
                MySqlCommand deidh = new MySqlCommand("Select Id_ms from mission where Nom_ms = '" + textBox1.Text + "'", con);
                dr = deidh.ExecuteReader();

                while (dr.Read())
                {
                    id_mission = Convert.ToInt32(dr["Id_ms"]);
                }
                con.Close();

                MessageBox.Show(" id mission trouver");
                // recherche des id pour chaque transport en voiture ( train  =  1 et avion = 2 )

                int id_transportpriv = 0;
                con.Open();
                if (voiturepriv == 1)
                {
                    
                    MySqlCommand co = new MySqlCommand("Select * from deplacement where and type_vehi = '2' and nom_vehi Like '" + nom_vehipriv + "'", con);
                    MySqlDataReader read;
                    read = co.ExecuteReader();
                    while (read.Read())
                    {
                        id_transportpriv = Convert.ToInt32(read["id_transport"]);
                    }

                }
                con.Close();

                MessageBox.Show(" id transport priv trouver");
                int id_transportpro = 0;
                con.Open();
                if ( voiturepro == 1)
                {
       
                    MySqlCommand co = new MySqlCommand("Select * from deplacement where Type_vehi = '1' and nom_vehi Like '" + nom_vehipro + "'", con);
                    MySqlDataReader read;
                    read = co.ExecuteReader();
                    while (read.Read())
                    {
                        id_transportpro = Convert.ToInt32(read["id_transport"]);
                    }

                }
                con.Close();
                MessageBox.Show(" id transport pro trouver");
                // insert pour joindre les fichier 

                // insert hebergement mission
                if (hebergement == 1)
                {
                    insert.insertdata("insert into prevoir(Id_ms ,Id_hbg,nbr_nuit) values('" + id_mission + "', '" + id_hebergement + "','"+ day + "')");
                }
                MessageBox.Show(" insert hebergement okay");

                //insert  mission transport
                if ( voiturepriv == 1)
                {
                    insert.insertdata("insert into deplacer(Id_ms ,Id_transport,nbr_km_dpl) values('" + id_mission + "', '" + id_transportpriv + "' , '" + textBox11 + "')");
                }
                MessageBox.Show(" insert voiture priv okay");

                if ( voiturepro == 1)
                {
                    MessageBox.Show("'"+id_transportpro+"'");
                    insert.insertdata("insert into deplacer(Id_ms ,Id_transport,nbr_km_dpl) values('" + id_mission + "', '" + id_transportpro + "' , '" + textBox11 + "')");
                }
                MessageBox.Show(" insert voiture prot okay");

                if (avion == 1)
                {
                    insert.insertdata("insert into deplacer(Id_ms ,Id_transport) values('" + id_mission + "', '2')");
                }
                MessageBox.Show(" insert aviob okay");

                if (train == 1)
                {
                    insert.insertdata("insert into deplacer(Id_ms ,Id_transport) values('" + id_mission + "', '1')");
                }
                MessageBox.Show(" insert train okay");

                //mission Crée
                MessageBox.Show("La mission a été crée");
                this.Gotoform(new MenuU());


            }

        }

    }
}
