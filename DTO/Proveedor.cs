using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Proveedor
    {
        private int idProveedor;
        private string nombre;
        private string rut;
        private string descripcion;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
