using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ingreso_Detalle
    {
        private int idEntrega;
        private int idProducto;
        private int cantidad;
        private int subTotal;

        public int IdEntrega { get => idEntrega; set => idEntrega = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int SubTotal { get => subTotal; set => subTotal = value; }
    }
}
