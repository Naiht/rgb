using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rgb
{
    class validaV
    {

        //ValidarVacios
        public bool vacio = false;
        public bool validarGB(GroupBox gb)
        {
            foreach (Control oControls in gb.Controls)
            {
                if (oControls is TextBox & oControls.Text == String.Empty)
                {
                    vacio = true;
                }
            }

            if (vacio)
            {
                vacio = false;
                return true;
            }
            else
            {
                vacio = false;
                return false;
            }

        }

        public void limpiar(GroupBox gb)
        {
            foreach (Control oControls in gb.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = "";
                }
            }
        }
    }
}
