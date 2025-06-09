using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public static class PedidoFactory
    {
        public static Pedido CrearPedido(int id, Cliente cliente, List<ItemPedido> itens, IDescuentoStrategy estrategiaDescuento,ILogger logger)
        {
            logger.Log("Creando pedido...");

            var data = DateTime.Now;
            var pedido = new Pedido(1, cliente, itens);

            logger.Log("Aplicando descuento...");
            pedido.AplicarDescuento(estrategiaDescuento);

            logger.Log($"Pedido creado con total: {pedido.Total:C}");
            return pedido; 
        }
    }
}
