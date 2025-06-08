using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public class DescuentoPorCantidad : IDescuentoStrategy
    {
        private readonly int cantidadMinima;
        private readonly decimal porcentaje;

        public DescuentoPorCantidad(int cantidadMinima, decimal porcentaje)
        {
            this.cantidadMinima = cantidadMinima;
            this.porcentaje = porcentaje;
        }

        public decimal CalcularDescuento(Pedido pedido)
        {
            var totalDescuento = pedido.Items
                .Where(i => i.Cantidad >= cantidadMinima)
                .Sum(i => i.Subtotal() * porcentaje);

            return totalDescuento;
        }
    }
}
