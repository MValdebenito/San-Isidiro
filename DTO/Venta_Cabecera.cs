using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Venta_Cabecera
    {
        private int idVenta;
        private int idVendedor;
        private string fecha;
        private string hora;
        private int iva;
        private int totalNeto;
        private int idEstado;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public int Iva { get => iva; set => iva = value; }
        public int TotalNeto { get => totalNeto; set => totalNeto = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
    }
}
