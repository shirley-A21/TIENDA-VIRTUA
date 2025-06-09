using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public class Producto
    {
        public int Id { get; }
        public string Nombre { get; }
        public decimal Precio { get; }
        public string Categoria { get; }

        public Producto(int id, string nombre, decimal precio, string categoria)
        {
            if (precio <= 0) throw new ArgumentException("El precio debe ser mayor que cero.");

            Id = id;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }
    }
}
