using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public interface IDescuentoStrategy
    {
        decimal CalcularDescuento(Pedido pedido);
    } // define como cal.multiples estra
}
