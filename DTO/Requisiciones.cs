using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Requisiciones
    {
        private int idRetiro;
        private int idVendedor;

        public int IdRetiro { get => idRetiro; set => idRetiro = value; }
        public int IdVendedor { get => idVendedor; set => idVendedor = value; }
    }
}
