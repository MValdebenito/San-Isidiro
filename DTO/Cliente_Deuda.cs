using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cliente_Deuda
    {
        private string rut;
        private int idVenta;
        private int credito;

        public string Rut { get => rut; set => rut = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public int Credito { get => credito; set => credito = value; }
    }
}
