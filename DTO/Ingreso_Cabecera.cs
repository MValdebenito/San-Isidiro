using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Ingreso_Cabecera
    {
        private int idEntrega;
        private int idVendedor;
        private int idProveedor;
        private DateTime fecha;
        private int total_bultos;
        private int iva;
        private int total_compra;

        public int IdEntrega { get => idEntrega; set => idEntrega = value; }
        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Total_bultos { get => total_bultos; set => total_bultos = value; }
        public int Iva { get => iva; set => iva = value; }
        public int Total_compra { get => total_compra; set => total_compra = value; }
    }
}
