using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJGSB
{
    //Permet de se deplacer entre les differente form plus facilement

    public static class Controller
    {


        public static void Gotoform(this Form form, Form nextForm)
        {
            form.Hide();
            nextForm.Show();
        }

     
    }
}

