using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shake {get;set;} // {get;set;} pega o conjunto de informação do shake e aplica na lista 

        public PedidoViewModel()
        {
            this.Hamburgueres = new List<Hamburguer>(); // da uma lista vazia para o usuário nao fzr merda
            this.Shake = new List<Shake>();
        }
    }

}