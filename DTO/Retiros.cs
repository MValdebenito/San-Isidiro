using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Retiros
    {
        private int idRetiro;
        private int idPRoducto;
        private int cantidad;
        private string motivo;

        public int IdRetiro { get => idRetiro; set => idRetiro = value; }
        public int IdPRoducto { get => idPRoducto; set => idPRoducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Motivo { get => motivo; set => motivo = value; }
    }
}
