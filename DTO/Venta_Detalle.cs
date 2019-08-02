using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Venta_Detalle
    {
        private int idVenta;
        private int idProducto;
        private string nombre;
        private int cantidad;
        private int subtotal;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Subtotal { get => subtotal; set => subtotal = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        
    }
}
