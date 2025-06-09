using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string mensaje)
        {
            Console.WriteLine($"[LOG] {mensaje}");
        }
        //implementacion de la interfaz ILogger, que imprime mensajes en la consola.
    }   // junto com i blogger 
}
