using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

using MySql.Data.MySqlClient;
namespace PJGSB
{
    public partial class ListMSA : Form
    {
        ObjInsert insert = new ObjInsert();
        public ListMSA()
        {
            InitializeComponent();


            lbl_compte.Text = Connexion.Compte;
            lbl_nom.Text = lbl_compte.Text;
            cbbox_filtre.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_filtre.Items.Add("nom_ms");
            cbbox_filtre.Items.Add("remarque_ms");
            cbbox_filtre.Items.Add("date_dbt_ms");
            cbbox_filtre.Items.Add("date_fin_ms");
            cbbox_filtre.Items.Add("NbrRepas_ms");
            cbbox_filtre.Items.Add("Id_utl");
            cbbox_filtre.Items.Add("Id_ville");
            cbbox_filtre.Items.Add("Valid_ms");
            cbbox_filtre.Items.Add("Montant_ms");
            cbbox_filtre.SelectedItem = "nom_ms";
            listBox_mission.Items.Clear();
            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("Select * from mission", "database=pj_notedefrais_gsb; server=localhost; user id=root; pwd='' ; convert zero datetime=True");
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string nom;
                nom = dr["nom_ms"].ToString();
                listBox_mission.Items.Add(nom);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_ms = 0;
             int valider = 0;
            string choix = listBox_mission.GetItemText(listBox_mission.SelectedItem);
            MySqlConnection con = new MySqlConnection("database=pj_notedefrais_gsb; server=localhost; user id=root; pwd='' ; convert zero datetime=True");
            con.Open();
            //requete en fonction du filtre 
            MySqlCommand da = new MySqlCommand("Select * from mission where " + cbbox_filtre.Text + " Like '%" + choix + "%'", con);
            MySqlDataReader dr;
            dr = da.ExecuteReader();
            while (dr.Read())
            {
                //voir les donnée selectionné
                id_ms = Convert.ToInt32(dr["id_ms"]);
                lbl_nom.Text = dr["nom_ms"].ToString();
                lbl_pnom.Text = dr["remarque_ms"].ToString();
                lbl_poste.Text = dr["date_dbt_ms"].ToString();
                label16.Text = dr["date_fin_ms"].ToString();
                lbl_nbr_repas.Text = dr["NbrRepas_ms"].ToString();
                label17.Text = dr["montant_ms"].ToString();

                DateTime debut = DateTime.Parse(lbl_poste.Text);
                DateTime fin = DateTime.Parse(label16.Text);


                lbl_poste.Text = Convert.ToString("'" + Convert.ToDateTime(debut).ToShortDateString() + "'");
                label16.Text = Convert.ToString("'" + Convert.ToDateTime(fin).ToShortDateString() + "'");

                valider = Convert.ToInt32(dr["valid_ms"]);
            }
            if (valider == 0)
            {
                radio_button.Enabled = true;
                radio_button.Checked = false;


            }
            if (valider == 1)
            {
                radio_button.Enabled = false;
                radio_button.Checked = true;

            }

            DataTable dt2 = new DataTable();
            con.Close();
            listbox_vehi.Items.Clear();
            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from deplacement, deplacer where deplacement.Id_transport = deplacer.Id_transport and id_ms = " + id_ms, con);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {

                string nom;
                nom = dr2["Nom_transport"].ToString();
                listbox_vehi.Items.Add(nom);
            }
            if (radio_button.Checked == true)
            {
                radio_button.Enabled = false;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from mission where " + cbbox_filtre.Text + " Like '%" + txtbox_filtre.Text + "%'", "database=pj_notedefrais_gsb; server=localhost; user id=root; pwd='' ; convert zero datetime=True");
            da.Fill(dt);
            listBox_mission.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string nom;
                nom = dr["nom_ms"].ToString();
                listBox_mission.Items.Add(nom);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_button.Enabled == true)
            {
                if (radio_button.Checked == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Etes vous sur d'accepter ?", "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int id_ms = 0;

                        string choix = listBox_mission.GetItemText(listBox_mission.SelectedItem);
                        MySqlConnection con = new MySqlConnection("database=pj_notedefrais_gsb; server=localhost; user id=root; pwd='' ; convert zero datetime=True");
                        con.Open();
                        MySqlCommand da = new MySqlCommand("Select * from mission where " + cbbox_filtre.Text + " Like '%" + choix + "%'", con);
                        MySqlDataReader dr;
                        dr = da.ExecuteReader();
                        while (dr.Read())
                        {
                            id_ms = Convert.ToInt32(dr["id_ms"]);
                        }
                        insert.insertdata("Update mission SET Valid_ms ='1' where  id_ms Like '" + id_ms + "'");
                        MessageBox.Show(" Mission valider ");
                    }

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter ="PDF file|*.pdf", ValidateNames = true })
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph("Note de frais"));
                        doc.Add(new iTextSharp.text.Paragraph(Environment.NewLine));
                        doc.Add(new iTextSharp.text.Paragraph(Environment.NewLine));
                        doc.Add(new iTextSharp.text.Paragraph(Environment.NewLine));
                        doc.Add(new iTextSharp.text.Paragraph("Demandeur :" + lbl_nom + " " + lbl_pnom));
                        doc.Add(new iTextSharp.text.Paragraph(Environment.NewLine));
                        doc.Add(new iTextSharp.text.Paragraph("Poste : " + lbl_poste + " " + lbl_poste));
                        doc.Add(new iTextSharp.text.Paragraph(Environment.NewLine));
                        doc.Add(new iTextSharp.text.Paragraph(Environment.NewLine));
                        doc.Add(new iTextSharp.text.Paragraph("Vehicule utilisé : "));
                        doc.Add(new iTextSharp.text.Paragraph(Convert.ToString(listbox_vehi)));
                        doc.Add(new iTextSharp.text.Paragraph("Prix totale remboursé :" + lbl_prix + "€"));
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
    }
}
