using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public static class PedidoFactory
    {
        public static Pedido CrearPedido(int id, Cliente cliente, List<ItemPedido> items)
        {
            return new Pedido(id, cliente, items);
        }
    }// centraliza , si se cambia el como lo creo es solo modificar aqui y... ya?
}
