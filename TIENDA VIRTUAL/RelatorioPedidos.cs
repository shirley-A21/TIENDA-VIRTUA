using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public class RelatorioPedidos
    {
        private readonly IPedidoRepository _repositorio;

        public RelatorioPedidos(IPedidoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public void Imprimir()
        {
            var pedidos = _repositorio.ListarTodos();
            Console.WriteLine("\n--- RELATÓRIO DE PEDIDOS ---");

            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Pedido #{pedido.Id} - Cliente: {pedido.Cliente.Nombre}");
                Console.WriteLine($"Data: {pedido.Fecha}");
                Console.WriteLine($"Total: R${pedido.Total}\n");
            }
        }

    }
}
