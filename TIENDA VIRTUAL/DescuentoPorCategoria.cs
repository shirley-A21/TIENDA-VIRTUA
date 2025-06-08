using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public class DescuentoPorCategoria : IDescuentoStrategy
    {
        private readonly string categoria;
        private readonly decimal porcentaje;
        public DescuentoPorCategoria(string categoria, decimal porcentaje)
        {
            this.categoria = categoria;
            this.porcentaje = porcentaje;
        }
        public decimal CalcularDescuento(Pedido pedido)
        {
            var totalCategoria = pedido.Items
              .Where(i => i.Producto.Categoria == categoria)
              .Sum(i => i.Subtotal());

            return totalCategoria * porcentaje;
        }
    } //solo a cierta categoria 
    
}

