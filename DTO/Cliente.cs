using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cliente
    {
        private string rut;
        private string nombre;
        private string correo;
        private string direccion;
        private int numero;
        private int totalDeuda;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Numero { get => numero; set => numero = value; }
        public int TotalDeuda { get => totalDeuda; set => totalDeuda = value; }
    }
}
