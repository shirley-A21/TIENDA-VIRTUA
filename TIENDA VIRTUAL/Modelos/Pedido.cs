using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL.Modelos
{
    internal class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Items { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorTotal { get; private set; }
        public Pedido(int id, Cliente cliente, List<ItemPedido> items,DateTime fecha)
        {
            Id = id;
            Cliente = cliente;
            Items = items;
            fecha = fecha;
            ValorTotal = CalcularTotal();

        }
        private decimal CalcularTotal()
        {
            return Items.Sum(item => item.ObtenerSubtotal());
        }
        public void AplicarDescuetno(IDescuentoStrategy estrategia)
        {
            ValorTotal = estrategia.CalcularDescuetno(this);
        }

    }
}
