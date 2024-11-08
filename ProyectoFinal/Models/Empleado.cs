using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public struct Empleado
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Posicion { get; set; }
        public string Departamento { get; set; }
        public decimal SalarioBase { get; set; }
        public DateTime FechaContratacion { get; set; }
    }
}
