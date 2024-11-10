using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public struct Nomina
    {
        public int EmpleadoID { get; set; }
        public double SalarioBase { get; set; }
        public double HorasTrabajadas { get; set; }
        public double HorasExtras { get; set; }
        public double TotalDeducciones { get; set; }
        public double SalarioNeto { get; set; }
        public DateTime FechaCalculo { get; set; }  // Fecha en la que se calculó la nómina
    }
}
