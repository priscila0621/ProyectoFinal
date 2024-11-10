using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public struct RegistroHoras
    {
        public int EmpleadoID { get; set; }  // ID del empleado al que pertenece el registro de horas
        public DateTime Fecha { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public double HorasTrabajadas { get; set; }
        public double HorasExtras { get; set; }
    }
}
