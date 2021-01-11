using EstudoTaskool.Models;
using EstudoTaskool.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoTaskool.Views
{
    public partial class frmListaUsuario : Form
    {
        public frmListaUsuario()
        {
            InitializeComponent();
        }        

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            UsuarioRepository repository = new UsuarioRepository();

            dgvListaAluno.DataSource = repository.buscarTodos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();

            dgvListaAluno.DataSource = null;

            UsuarioRepository repository = new UsuarioRepository();
            dgvListaAluno.DataSource = repository.buscarTodos();
        }

        private void dgvListaAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dgvListaAluno.Rows[e.RowIndex];

            string nome = linha.Cells[1].Value.ToString();
            string email = linha.Cells[2].Value.ToString();
            string userName = linha.Cells[3].Value.ToString();
            string senha = linha.Cells[4].Value.ToString();
            string telefone = linha.Cells[5].Value.ToString();
            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

            Usuario usuario = new Usuario
            {
                codigo = codigo,
                nome = nome,
                email = email,
                senha = senha,
                telefone = telefone,
                usuario = userName,
                
            };

            new frmCadastro(usuario).ShowDialog();

            dgvListaAluno.DataSource = null;
            UsuarioRepository repository = new UsuarioRepository();
            dgvListaAluno.DataSource = repository.buscarTodos();
        }
    }
}
