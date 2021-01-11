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
            //Incrementa o valor do contador - a cada tick do timer
            contador++;
            //Monstra o valor do contador no label (display do contador)
            lblContador.Text = contador.ToString();
            //Inverte a propriedade visile do picturebox
            picImagem.Visible = !picImagem.Visible;
            
            //verifica se deu 5 segundos
            if (contador == 5)
            {
                //desabilita o timer
                timer1.Enabled = false;
                //esconde o form splash
                this.Hide();
                //apresenta o Login
                new frmLogin().ShowDialog();
                this.Close();

            }

        }
    }
}
