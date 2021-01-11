using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class PedidoRepository
    {
        private const string PATH = "Database/Pedido.csv";
        public PedidoRepository()
        {
            if (!File.Exists(PATH)){
                File.Create(PATH).Close();

            }
        }
        public bool Inserir(Pedido pedido)
        {
            var linha = new string[] {PrepararPedidosCSV(pedido)};
            File.AppendAllLines(PATH, linha);

            return true;
        }

        private string PrepararPedidosCSV(Pedido pedido)
        {
            Cliente c = pedido.Cliente;      //c = cliente
            Hamburguer h = pedido.Hamburguer;//h = hamburguer
            Shake s = pedido.Shake;          //s = shake

            return $"cliente_nome={c.Nome};cliente_endereco={c.Endereco};cliente_telefone={c.Telefone};cliente_email={c.Email};hamburguer_nome+{h.Nome};hamburguer_precp={h.Preco};shake_nome{s.Nome};shake_preco={s.Preco};data_pedido={pedido.DataDoPedido};preco_total={pedido.Precototal}"; 
        }
    }
}