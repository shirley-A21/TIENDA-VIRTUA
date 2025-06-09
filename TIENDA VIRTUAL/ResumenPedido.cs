using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    internal class ResumenPedido
    {
        
        public void MostrarResumen(Pedido pedido, IDescuentoStrategy estrategia)
        {
            Console.WriteLine($"Pedido #{pedido.Id} - Cliente: {pedido.Cliente.Nombre}");
            Console.WriteLine($"Fecha: {pedido.Fecha}\n");

            Console.WriteLine("Productos:");

            foreach (var item in pedido.Items)
            {
                Console.WriteLine($"- {item.Producto.Nombre} x{item.Cantidad} = {item.Subtotal():C}");
            }

            decimal descuento = estrategia.CalcularDescuento(pedido);
            Console.WriteLine($"\nDescuento aplicado: {descuento:C}");

            decimal totalConDescuento = pedido.Total - descuento;
            Console.WriteLine($"Total con descuento: {totalConDescuento:C}");
        }// ahora si ya aparece la listita 
    }
}

