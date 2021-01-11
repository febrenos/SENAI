using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EstudoTaskool
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Login | Taskool";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //para bloquear o Ctrl C + Ctrl V
            tbxUsuario.ShortcutsEnabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite o usuário.", "Erro");
            }
            else
            {
                MessageBox.Show("Bem Vindo", "Entrada");
                new FrmPrincipal().ShowDialog();

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //esconde a label
            lblCaps.Visible = isCapsLockActive();
        }

        private void tbxUsuario_Enter(object sender, EventArgs e)
        {
            lblCaps.Visible = isCapsLockActive();
        }

        private bool isCapsLockActive()
        {
            return Control.IsKeyLocked(Keys.CapsLock);
        }

        private void tbxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            lblCaps.Visible = isCapsLockActive();
        }

        private void tbxUsuario_Leave(object sender, EventArgs e)
        {
            lblCaps.Visible = false;
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            //para funcionar esse processo precisa alterar a configura
            System.Diagnostics.Process.Start("osk.exe");
            tbxUsuario.Focus();
        }
    }

}