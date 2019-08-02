using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Familia_Producto
    {
        private int idFamilia;
        private string nombre;
        private string descripcion;

        public int IdFamilia { get => idFamilia; set => idFamilia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
