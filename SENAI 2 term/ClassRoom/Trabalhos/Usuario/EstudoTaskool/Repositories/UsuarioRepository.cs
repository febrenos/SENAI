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
        private static List<Usuario> usuarios;
        private static int contador = 1;

        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();
            }
        }

        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }
      
        public void adicionar(Usuario usuario)
        {
            usuario.codigo = contador;

            usuarios.Add(usuario);
            contador++;
        }

        public void editar(Usuario usuario)
        {
            // pegar a posição o objeto dentro da lista
            Usuario u = usuarios.Find(x => x.codigo == usuario.codigo);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }
    }
}
