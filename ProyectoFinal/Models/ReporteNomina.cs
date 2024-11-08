using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public struct ReporteNomina
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCalculo { get; set; }
        public double SalarioNeto { get; set; }

    }
}
