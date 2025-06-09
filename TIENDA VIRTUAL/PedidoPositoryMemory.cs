using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public class PedidoRepositoryMemoria : IPedidoRepository
    {
        private readonly List<Pedido> pedidos = new List<Pedido>();

        public void Guardar(Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        public List<Pedido> ListarTodos()
        {
            return pedidos;
        }
    }
}
