using ExemploWebApiBd.Contexts;
using ExemploWebApiBd.Domains;
using Microsoft.AspNetCore.DataProtection.XmlEncryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploWebApiBd.Repositories
{
    public class SelecaoRepository
    {
        //Método para buscar dados na tabela através do Context
        //e carregar numa lista
        public List<Selecao> Listar()
        {
            using (WebApiBDContext ctx = new WebApiBDContext())
            {
                return ctx.Selecao.ToList();
            }
        }

        //Método para cadastrar dados. Passando os dados através da classe
        public void Cadastrar(Selecao selecao)
        {
            using (WebApiBDContext ctx = new WebApiBDContext())
            {
                ctx.Selecao.Add(selecao);
                ctx.SaveChanges();
            }
        }

        //Método para remover o item. Recebe o id do item que será removido (parâmetro da chamada rest)
        public void Deletar(int id)
        {
            using (WebApiBDContext ctx = new WebApiBDContext())
            {
                Selecao selecaoId = ctx.Selecao.Find(id);
                ctx.Selecao.Remove(selecaoId);
                ctx.SaveChanges();
            }
        }

        //Método que busca um item na tabela. Recebe o id para fazer a busca
        public Selecao BuscarPorId(int id)
        {
            using (WebApiBDContext ctx = new WebApiBDContext())
            {
                return ctx.Selecao.FirstOrDefault(x => x.Id == id);
            }
        }

        //Método para atualizar o registro no BD. Recebe a classe / Busca o o id do item)
        public void Atualizar(Selecao selecao)
        {
            using (WebApiBDContext ctx = new WebApiBDContext())
            {
                Selecao selecaoAtuaizada = ctx.Selecao.FirstOrDefault(x => x.Id == selecao.Id);
                selecaoAtuaizada.Nome = selecao.Nome;
                ctx.Selecao.Update(selecaoAtuaizada);
                ctx.SaveChanges();
            }
        }
    }
}
