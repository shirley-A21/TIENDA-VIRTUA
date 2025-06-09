using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public interface IPedidoRepository
    {
        void Guardar(Pedido pedido);
        List<Pedido> ListarTodos();
    }
    //define contrato , que op debe estar disponible 
    //implementa a memory
    //mezcle el que se debe hacr con el como se hace 
}
