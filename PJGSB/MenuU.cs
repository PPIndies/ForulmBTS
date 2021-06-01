using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJGSB
{
    public partial class MenuU : Form
    {
        public MenuU()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Gotoform(new Connexion());
        }

        private void MenuU_Load(object sender, EventArgs e)
        {
            label2.Text = Connexion.Compte;
        }

        private void btn_cr_utl_Click(object sender, EventArgs e)
        {
            this.Gotoform(new AjtMissU());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Gotoform(new ListMSU());
        }
    }
}
