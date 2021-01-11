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
        UsuarioRepository repository = new UsuarioRepository();
        public frmListaUsuario()
        {
            InitializeComponent();
        }

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            //Inclusão manual - esse responsabilidade é da classe repositories
            // 2. Será criado uma lista para popular o datagrid
            //List<Usuario> usuarios = new List<Usuario>();
            //Usuario usuario = new Usuario
            //{
            //    codigo = 1,
            //    nome = "Lidiane",
            //    telefone = "111",
            //    senha = "123",
            //    email = "email",
            //    usuario = "erik"

            //};
            //usuarios.Add(usuario);
            //dgvListaAluno.DataSource = usuario;

            //2. Chama o método para carregar os dados no datagridview

            carregaLista();
        }
        //7. Chamar o método que adiciona
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //chama o form de cadastro
            new frmCadastro().ShowDialog();
            //Chama o método para carregar na lista
            carregaLista();
        }
        //9. Captura os dado item selecionado no datagrid
        private void dgvListaAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //captura a linha que foi selecionada
            DataGridViewRow linha = dgvListaAluno.Rows[e.RowIndex];
            //guarda nas variáveis os conteúdos das células
            string nome = linha.Cells[1].Value.ToString();
            string email = linha.Cells[2].Value.ToString();
            string userName = linha.Cells[3].Value.ToString();
            string senha = linha.Cells[4].Value.ToString();
            string telefone = linha.Cells[5].Value.ToString();
            //esse campo precisa ser convertido pois é numérico
            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
            //Joga nas propriedades do objeto usuario
            Usuario usuario = new Usuario
            {
                codigo = codigo,
                nome = nome,
                email = email,
                senha = senha,
                telefone = telefone,
                usuario = userName,

            };
            //Chama o formulário de cadastro passando a classe usuario

            new frmCadastro(usuario).ShowDialog();
            //chama o método para carregar o datagrid
            carregaLista();
        }

        private void dgvListaAluno_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    DataGridViewRow linha = dgvListaAluno.Rows[e.RowIndex];

                    int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
                    
                    repository.deletar(codigo);

                    carregaLista();
                }
            }
        }

        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dgvListaAluno.DataSource = null;
            dgvListaAluno.DataSource = repository.buscarTodos();
            alterarContador();
        }

        private void filtroTextbox_TextChanged(object sender, EventArgs e)
        {
            dgvListaAluno.DataSource = null;

            // filtra as lista recebida do repositório, verificando se o nome, 
            // email, usuario, contém o que está no campo filtro.
            dgvListaAluno.DataSource = repository.buscarTodos().FindAll(x =>
                x.nome.ToUpper().Contains(filtroTextbox.Text.ToUpper()) ||
                x.email.ToUpper().Contains(filtroTextbox.Text.ToUpper()) ||
                x.usuario.ToUpper().Contains(filtroTextbox.Text.ToUpper()) 
            );

            alterarContador();
            
        }

        private void alterarContador()
        {
            //2 itens de 10
            lblContador.Text = $"{dgvListaAluno.RowCount} itens de {repository.buscarTodos().Count}";
        }
    }
}
