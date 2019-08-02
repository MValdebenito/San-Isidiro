using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Log_Ingresos
    {
        private int idLog;
        private string descripcion;
        private string fecha;
        private string hora;

        public int IdLog { get => idLog; set => idLog = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
