using TIENDA_VIRTUAL;
using static TIENDA_VIRTUAL.IPedidoRepository;

namespace TIENDA_VIRTUAL
{
    class Program
    {
        static void Main()
        {
            var cliente = new Cliente(1, "pepito del monte ", "pedro@mail.com", "12345678900");
            // Crear productos
            var prod1 = new Producto(1, "Camisa", 50m, "Ropa");
            var prod2 = new Producto(2, "Zapato", 120m, "Calzado");
            var prod3 = new Producto(3, "Pantalón", 80m, "Ropa");
            var prod4 = new Producto(4, "papa", 30m, "ingrediente ");
            var prod5 = new Producto(5, "paciencia", 200m, "virtud");
            var prod6 = new Producto(6, "buen humor", 1000m, "organo");
            var prod7 = new Producto(7, "cerebro", 10000m, "no funciono ");

            
            // Crear ítems del pedido
            var items = new List<ItemPedido>
            {
                new ItemPedido(prod1, 3), // 3 camisas
                new ItemPedido(prod2, 1), // 1 zapato
                new ItemPedido(prod3, 2) , // 2 pantalones
                new ItemPedido(prod4, 1), // 1 papa
                new ItemPedido(prod5, 3), // 3 paciencia
                new ItemPedido(prod6, 3), // 1 buen humor
                new ItemPedido(prod7, 5) // 1 cerebro
               
            };

            
            IDescuentoStrategy estrategia = new DescuentoPorCategoria("Ropa", 0.1m); // 10% en ropa
            IDescuentoStrategy estrategia2 = new DescuentoPorCategoria("Calzado", 0.2m); // 20% en calzado
            IDescuentoStrategy estrategia3 = new DescuentoPorCategoria("ingrediente ", 0.5m); // 50% en ingredientes
            IDescuentoStrategy estrategia4 = new DescuentoPorCategoria("virtud", 0.1m); // 10% en virtudes
            IDescuentoStrategy estrategia5 = new DescuentoPorCategoria("organo", 0.2m); // 20% en organos
            IDescuentoStrategy estrategia6 = new DescuentoPorCategoria("no funciono ", 0.5m); // 50% en no funciono



            // Crear pedido
            var pedido = new Pedido(1, cliente, items);

            // Crear estrategia de descuento por categoría "Ropa" con 10%
            IDescuentoStrategy descuento = new DescuentoPorCategoria("Ropa", 0.10m);

            // Mostrar resumen con descuento
            var resumen = new ResumenPedido();
            resumen.MostrarResumen(pedido, descuento);
        }
    }
}
