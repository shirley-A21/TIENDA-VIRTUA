using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public class ItemPedido
    {//procuto dentro de un P. cantida etc
        public Producto Producto { get; }
        public int Cantidad { get; }

        public ItemPedido(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        public decimal Subtotal()
        {
            return Producto.Precio * Cantidad;
        }
    }
}
