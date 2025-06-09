using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public class PedidoService
    {
        private readonly IPedidoRepository _repositorio;
        private readonly ILogger _logger;

        public PedidoService(IPedidoRepository repositorio, ILogger logger)
        {
            _repositorio = repositorio;
            _logger = logger;
        }

        public void SalvarPedido(Pedido pedido)
        {
            _repositorio.Guardar(pedido);
            _logger.Log($"Pedido {pedido.Id} salvo com sucesso.");
        }

        public void ListarPedidos()
        {
            var pedidos = _repositorio.ListarTodos();
            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Pedido {pedido.Id} - Cliente: {pedido.Cliente.Nombre} - Total: {pedido.Total:C}");
            }
        }
    }
}
