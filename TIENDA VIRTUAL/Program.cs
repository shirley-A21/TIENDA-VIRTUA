using TIENDA_VIRTUAL;

class Program
{
    static void Main(string[] args)
    {
        // Crear productos
        var prod1 = new Producto(1, "Mouse", 100, "Eletrônicos");
        var prod2 = new Producto(2, "Camiseta", 80, "Roupas");

        // Crear cliente
        var cliente = new Cliente(1, "Carlos", "carlos@email.com", "12345678900");

        // Crear itens do pedido
        var item1 = new ItemPedido(prod1, 2); // 2 Mouses
        var item2 = new ItemPedido(prod2, 1); // 1 Camiseta

        // Criar pedido via Factory
        var pedido = PedidoFactory.CrearPedido(1, cliente, new List<ItemPedido> { item1, item2 });

        Console.WriteLine($"Total antes do desconto: {pedido.Total}");

        // Aplicar desconto por categoria
        var estrategiaDesconto = new DescuentoPorCategoria("Eletrônicos", 0.10m); // 10%
        pedido.AplicarDescuento(estrategiaDesconto);

        Console.WriteLine($"Total depois do desconto: {pedido.Total}");
    }
}
