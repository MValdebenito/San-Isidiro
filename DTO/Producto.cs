using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private string marca;
        private int precioUnitario;
        private int stock;
        private int idFamilia;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int Stock { get => stock; set => stock = value; }
        public int IdFamilia { get => idFamilia; set => idFamilia = value; }
        public string Marca { get => marca; set => marca = value; }
    }
}
