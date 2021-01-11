using Senai.WSTowerWebApi.DataBaseFirst.Domains;
using Senai.WSTowerWebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WSTowerWebApi.DataBaseFirst.Repositories
{
    public class SelecaoRepository : ISelecaoRepository
    {
        WSTowerContext ctx = new WSTowerContext();

        public void Atualizar(int id, Selecao selecaoAtualizada)
        {
            throw new NotImplementedException();
        }

        public Selecao BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Selecao novaSelecao)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Selecao> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
