using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public struct Deduccion
    {
        public int EmpleadoID { get; set; }
        public string TipoDeduccion { get; set; }
        public double Monto { get; set; }
    }
}
