using EstudoTaskool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoTaskool.Repositories
{
    public class UsuarioRepository

    {
        //3. Lista que irá armazenar os dados do usuário para carregar no DataGridView
        // a declaração static fará a criação na memória - se ela já existir ele não cria novamente

        private static List<Usuario> usuarios;
        //Contador - id do usuário
        private static int contador = 1;

        //4. Contrutor do repositório
        public UsuarioRepository()
        {
            //se a lista estiver vazia - cria uma instacia da lista
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();


                //Dados previamente adicionados na lista para facilitar teste do editar e excluir
                usuarios.Add(new Usuario
                {
                    codigo = 1,
                    nome = "Erik",
                    email = "erik@email",
                    senha = "1234",
                    telefone = "123456789",
                    usuario = "evitelli"
                }
               );
                contador++;
                usuarios.Add(new Usuario
                {
                    codigo = 2,
                    nome = "Marcelo",
                    email = "marcelo@gmail",
                    senha = "1234",
                    telefone = "123456789",
                    usuario = "marcelinho"
                }
                );
                contador++; 
            }
        }
        //5. Criar método para retornar todos os usuários
        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }
        //6. método que irá adicionar usuários
        public void adicionar(Usuario usuario)
        {
            usuario.codigo = contador;

            usuarios.Add(usuario);
            contador++;
        }
        //11. Altera os dados da lista
        public void editar(Usuario usuario)
        {

            // pegar a posição o objeto dentro da lista - no método tradicional
            //Usuario u;
            //foreach (Usuario x in usuarios)
            //{
            //    if (x.codigo == usuario.codigo)
            //    {
            //        u = x;
            //    }
            //}

            //Pega a posição do objeto dentro da lista
            //funcao lambda para pegar o índice do item que será alterado
            //lambda é uma ação anonima para aplicar uma regra

            // pegar a posição o objeto dentro da lista
            Usuario u = usuarios.Find(x => x.codigo == usuario.codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        //Remove dados da lista
        public void deletar(int codigo)
        {
            // recupero o usuário atraves do código
            Usuario usuario = usuarios.Find(x => x.codigo == codigo);

            // removo o usuário da lista;
            usuarios.Remove(usuario);
        }
    }
}
