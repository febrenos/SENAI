using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoTaskool
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            
        }

        //variavel para definir a contagem de 5
        int contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            lblContador.Text = contador.ToString();
            picImagem.Visible = !picImagem.Visible;
            

            if (contador == 5)
            {
                timer1.Enabled = false;
                this.Hide();
                new frmLogin().ShowDialog();
                this.Close();

            }

        }
    }
}
