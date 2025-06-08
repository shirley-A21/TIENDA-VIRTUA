using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIENDA_VIRTUAL
{
    public class Cliente
    {
        public int Id { get; }
        public string Nombre { get; }
        public string Email { get; }
        public string Cpf { get; }

        public Cliente(int id, string nombre, string email, string cpf)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            Cpf = cpf;
        }
    }
}
