using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public class Pedido
    {
        public int Id { get; }
        public Cliente Cliente { get; }
        public List<ItemPedido> Items { get; }
        public DateTime Fecha { get; }
        public decimal Total { get; private set; }

        public Pedido(int id, Cliente cliente, List<ItemPedido> items)
        {
            Id = id;
            Cliente = cliente;
            Items = items;
            Fecha = DateTime.Now;
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            Total = Items.Sum(item => item.Subtotal());
        }

        public void AplicarDescuento(IDescuentoStrategy estrategia)
        {
            decimal descuento = estrategia.CalcularDescuento(this);
            Total -= descuento;
        }
    }
}
