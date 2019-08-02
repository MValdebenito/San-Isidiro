using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Vendedor
    {
        private int idVendedor;
        private string rut;
        private string nombre;
        private string pass;
        private int idTipo;

        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pass { get => pass; set => pass = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
    }
}
