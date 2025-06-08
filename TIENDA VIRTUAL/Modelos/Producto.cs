using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL.Modelos
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public Producto(int id, string nombre, decimal precio, string categoria)
        {
            if (precio <=0)
                throw new ArgumentException("El precio debe ser mayor que cero.");
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
        }
       
    }
}
