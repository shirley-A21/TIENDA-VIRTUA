using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIENDA_VIRTUAL.Modelos;

namespace TIENDA_VIRTUAL.Fabrica_de_pedidos
{
    internal static class PedidoFactory
    {
        //NO NECESITAS CREAR INSTANCIA PRAR USARLA!! 
        public static Pedido CrearPedido(int id, Cliente cliente, List<ItemPedido> items)
        {
            return new Pedido(id, cliente, items, DateTime.Now);
        }
        //recibe clieente con su lista e devulve pedido
    }
}
