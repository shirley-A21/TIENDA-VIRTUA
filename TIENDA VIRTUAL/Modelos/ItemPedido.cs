using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL.Modelos
{
    internal class ItemPedido
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public ItemPedido(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }
        public decimal ObtenerSubtotal()
        {
            return Producto.Precio * Cantidad;
        }
    }
}
