using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL.Modelos
{
    internal class Cliente
    {
        public int Id { get; }
        public string Nombre { get;  }
        public string Email { get; }
        public string CPF { get;  }
        public Cliente(int id, string nombre, string email, string cpf)
        {
           
            Id = id;
            Nombre = nombre;
            Email = email;
            CPF = cpf;
        }
    }
}
