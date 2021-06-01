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
    public partial class MenuA : Form
    {
        public MenuA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Gotoform(new Connexion());
        }

        private void btn_cr_utl_Click(object sender, EventArgs e)
        {
            this.Gotoform(new AjtUtl());

        }

        private void MenuA_Load(object sender, EventArgs e)
        {
            lbl_compte.Text = Connexion.Compte;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Gotoform(new ListUtlA());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Gotoform(new AjtVehiculeA());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Gotoform(new ListMSA());
        }
    }
}
