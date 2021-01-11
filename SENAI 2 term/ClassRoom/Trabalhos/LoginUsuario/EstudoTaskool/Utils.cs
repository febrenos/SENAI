using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoTaskool
{
    class Utils
    {

        public static bool temCamposVazio(Form form)
        {
            //varrer os objeos do formulário
            foreach (Control c in form.Controls)
            {
                //guardar as caixas de texto
                TextBox tbx = c as TextBox;
                //verificar se estão preenchidas
                if (tbx != null && tbx.Text.Trim().Length == 0)
                {
                    //retorna que tem campos vazios
                    return true;
                }
            }
            //retornar que Não tem campos vazios
            return false;
        }
    }
}
